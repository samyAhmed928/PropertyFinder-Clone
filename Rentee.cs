using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Drawing;
using System.IO;

namespace prop_finder
{
    public struct Rate
    {
        public string u_email, u_fname, _u_lname;
        public Image u_pic;
        public int Rating;
        public string comment;

        public Rate(string u_email, string u_fname, string u_lname, Image u_pic, int rating, string comment)
        {
            this.u_email = u_email;
            this.u_fname = u_fname;
            _u_lname = u_lname;
            this.u_pic = u_pic;
            Rating = rating;
            this.comment = comment;
        }
    }
    public class Rentee : User
    {

        //CREATE TABLE Rentees(rentee_email varchar(255) primary key,
        //CONSTRAINT rentee_fk_user_email FOREIGN KEY(rentee_email) REFERENCES users(user_email)
        //user_email  VARCHAR(255) primary key,user_password VARCHAR(20), first_name VARCHAR(50), last_name VARCHAR(5
        string ordb;
        OracleConnection conn;
        public Rentee(string rentee_email, string user_password, string firstName, string lastName)
        {
            this.User_Email = rentee_email;
            this.Password = user_password;
            this.FirstName = firstName;
            this.LastName = lastName;
            ordb = "Data Source=ORCL;User Id=Property_finder;Password=prop_finder";
            conn = new OracleConnection(ordb);
        }
        public Rentee(string rentee_email, string user_password, string firstName, string lastName, byte[] image_array)
        {
            this.User_Email = rentee_email;
            this.Password = user_password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.profile_image = image_array;
            ordb = "Data Source=ORCL;User Id=Property_finder;Password=prop_finder";
            conn = new OracleConnection(ordb);
        }
        public bool applyforrent(Property p, decimal suggested_price, string msg)
        {
            conn.Open();
            try
            {
                OracleCommand command = new OracleCommand();
                command.CommandType = CommandType.Text;
                command.Connection = conn;
                command.CommandText = "INSERT INTO Rent_requests values(:rentee_email, :prop_id ,:message ,:suggested_price )";
                command.Parameters.Add("rentee_email", this.User_Email);
                command.Parameters.Add("prop_id", p.PropertyId);
                command.Parameters.Add("message", msg);
                command.Parameters.Add("suggested_price", suggested_price);
                int r = command.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch (OracleException ex)
            {
                if (ex.Number == 1 && ex.Message.Contains("REQ_PK"))
                {
                    conn.Close();

                    return false;
                }

            }
            return true;



        }
        //public List<Property> search(string city)
        //{
        //    conn.Open();
        //    List<Property> properties = new List<Property>();

        //    OracleCommand command = new OracleCommand();
        //    command.Connection = conn;
        //    command.CommandText = "select_properties_1";
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.Parameters.Add("PCity", city);
        //    command.Parameters.Add("prp", OracleDbType.RefCursor, ParameterDirection.Output);
        //    OracleDataReader reader = command.ExecuteReader();


        //    while (reader.Read())
        //    {
        //        int propertyId = Convert.ToInt32(reader["property_id"]);
        //        string Property_ListerEmail = reader["prop_lister_email"].ToString();
        //        string type = reader["property_type"].ToString();
        //        decimal startPrice = Convert.ToDecimal(reader["start_price"]);
        //        decimal endPrice = Convert.ToDecimal(reader["end_price"]);
        //        int numRooms = Convert.ToInt32(reader["num_rooms"]);
        //        int numBathrooms = Convert.ToInt32(reader["num_bathrooms"]);
        //        string cityy = reader["City"].ToString();
        //        string street = reader["street"].ToString();
        //        string buildingNumber = reader["building_number"].ToString();
        //        string description = reader["description"].ToString();
        //        decimal area = Convert.ToDecimal(reader["area"]);
        //        string status = reader["status"].ToString();
        //        string phoneNumber = reader["phone_number"].ToString();

        //        Property property = new Property(propertyId, Property_ListerEmail, type, startPrice, endPrice, numRooms, numBathrooms, cityy, street, buildingNumber, description, area, status, phoneNumber);
        //        properties.Add(property);
        //    }
        //    conn.Close();
        //    return properties;


        //}

        public List<Property> search(string city)
        {
            List<Property> properties = new List<Property>();

            //command.CommandText = "SELECT * FROM properties WHERE area <= :area";
            //OracleCommand command = new OracleCommand("select_properties_1", conn)
            using (OracleCommand command = new OracleCommand("select_properties_1", conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("PCity", OracleDbType.Varchar2, ParameterDirection.Input).Value = city;
                command.Parameters.Add("prp", OracleDbType.RefCursor, ParameterDirection.Output);

                conn.Open();
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int propertyId = Convert.ToInt32(reader["property_id"]);
                        string Property_ListerEmail = reader["prop_lister_email"].ToString();
                        string type = reader["property_type"].ToString();
                        decimal startPrice = Convert.ToDecimal(reader["start_price"]);
                        decimal endPrice = Convert.ToDecimal(reader["end_price"]);
                        int numRooms = Convert.ToInt32(reader["num_rooms"]);
                        int numBathrooms = Convert.ToInt32(reader["num_bathrooms"]);
                        string cityy = reader["City"].ToString();
                        string street = reader["street"].ToString();
                        string buildingNumber = reader["building_number"].ToString();
                        string description = reader["description"].ToString();
                        decimal area = Convert.ToDecimal(reader["area"]);
                        string status = reader["status"].ToString();
                        string phoneNumber = reader["phone_number"].ToString();

                        Property property = new Property(propertyId, Property_ListerEmail, type, startPrice, endPrice, numRooms, numBathrooms, cityy, street, buildingNumber, description, area, status, phoneNumber);
                        properties.Add(property);
                    }
                }
            }
            conn.Close();
            return properties;
        }


        public List<Property> search_DB(decimal area)
        {
            conn.Open();
            List<Property> properties = new List<Property>();
            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            //command.CommandText = "SELECT * FROM properties WHERE area <= :area";
            command.CommandText = "SELECT * FROM properties WHERE area <= :area";
            command.CommandType = CommandType.Text;
            command.Parameters.Add("area", OracleDbType.Decimal).Value = area;
            OracleDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                int propertyId = Convert.ToInt32(reader["property_id"]);
                string Property_ListerEmail = reader["prop_lister_email"].ToString();
                string type = reader["property_type"].ToString();
                decimal startPrice = Convert.ToDecimal(reader["start_price"]);
                decimal endPrice = Convert.ToDecimal(reader["end_price"]);
                int numRooms = Convert.ToInt32(reader["num_rooms"]);
                int numBathrooms = Convert.ToInt32(reader["num_bathrooms"]);
                string city = reader["City"].ToString();
                string street = reader["street"].ToString();
                string buildingNumber = reader["building_number"].ToString();
                string description = reader["description"].ToString();
                decimal Area = Convert.ToDecimal(reader["area"]);
                string status = reader["status"].ToString();
                string phoneNumber = reader["phone_number"].ToString();

                Property property = new Property(propertyId, Property_ListerEmail, type, startPrice, endPrice, numRooms, numBathrooms, city, street, buildingNumber, description, Area, status, phoneNumber);
                properties.Add(property);
            }
            reader.Close();
            conn.Close();
            return properties;
        }



        public void Rate(Property p, string Comment, int rating)
        {
            conn.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.CommandText = "INSERT INTO Rates values(:rentee_email ,:prop_id , :rating , :rate_comment )";
            command.Parameters.Add("rentee_email", this.User_Email);
            command.Parameters.Add("prop_id", p.PropertyId);
            command.Parameters.Add("rating", rating);
            command.Parameters.Add("rate_comment", Comment);
            int r = command.ExecuteNonQuery();
            conn.Close();
        }

        public List<Rate> get_Rates(int prop_id)
        {
            conn.Open();
            List<Rate> rates= new List<Rate>();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.CommandText = "SELECT R.RENTEE_EMAIL, U.FIRST_NAME, U.LAST_NAME, U.PROFILE_PIC, R.RATING, R.RENTEE_COMMENT FROM PROPERTY_FINDER.RATES R INNER JOIN PROPERTY_FINDER.USERS U ON R.RENTEE_EMAIL = U.USER_EMAIL WHERE R.PROP_ID = :propId";
           

            command.Parameters.Add("p_id", prop_id);

            OracleDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                //int propertyId = Convert.ToInt32(reader["property_id"]);
                string u_email = reader["RENTEE_EMAIL"].ToString();
                string u_fname = reader["FIRST_NAME"].ToString();
                string u_lname = reader["LAST_NAME"].ToString();
                byte[] prof_pic =(byte[]) reader["PROFILE_PIC"];
                int rate = Convert.ToInt32(reader["RATING"]);
                string comment = reader["RENTEE_COMMENT"].ToString();
                Image image;

                using (MemoryStream ms = new MemoryStream(prof_pic))
                {
                    image = Image.FromStream(ms);
                }
                Rate r = new Rate(u_email, u_fname, u_lname, image, rate, comment);
                rates.Add(r);

            }
            reader.Close();
            conn.Close();
            return rates;

        }
    }
}
   

