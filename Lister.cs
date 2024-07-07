using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;



namespace prop_finder
{


    public class Lister : User
    {


        public string Company_name { get; set; }
        public string Phone_number { get; set; }
        public string Job_title { get; set; }

        string ordb;
        OracleConnection conn;


        public Lister( string firstName, string lastName, string email, string password, string company_name, string job_title, string phone_number)
        {

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.User_Email = email;
            this.Company_name = company_name;
            this.Phone_number = phone_number;
            this.Job_title = job_title;
            ordb = "Data Source=ORCL;User Id=Property_finder;Password=prop_finder";
            conn = new OracleConnection(ordb);
        }

        public Lister(string firstName, string lastName, string email, string password, string company_name, string job_title, string phone_number, byte[] image_bytes)
        {

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.User_Email = email;
            this.Company_name = company_name;
            this.Phone_number = phone_number;
            this.Job_title = job_title;
            this.profile_image = image_bytes;
            ordb = "Data Source=ORCL;User Id=Property_finder;Password=prop_finder";
            conn = new OracleConnection(ordb);
        }

        //property_id INT PRIMARY KEY,prop_lister_email varchar(255), property_type VARCHAR(50), start_price DECIMAL(10,2),
        //end_price DECIMAL(10,2), num_rooms INT, num_bathrooms INT, city VARCHAR(50), street VARCHAR(50), building_number VARCHAR(20),
        //description VARCHAR(255),area DECIMAL(10,2),status Number(1), phone_number VARCHAR(20),
        //CONSTRAINT property_fk_lister_emailFOREIGN KEY(prop_lister_email)
        //REFERENCES Listers(lister_email)

        public bool List_property(Property p)
        {

            conn.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.CommandText = "INSERT INTO properties(prop_lister_email, property_type, start_price, end_price, num_rooms, num_bathrooms, city, street, building_number, description, area, status, phone_number) values(:prop_lister_email, :property_type,:start_price, :end_price, :num_rooms, :num_bathrooms,:city, :street, :building_number, :description, :area, :status, :phone_number)";


            
            command.Parameters.Add("prop_lister_email", this.User_Email);
            command.Parameters.Add("property_type", p.Type);
            command.Parameters.Add("start_price", p.StartPrice);
            command.Parameters.Add("end_price", p.EndPrice);
            command.Parameters.Add("num_rooms", p.NumRooms);
            command.Parameters.Add("num_bathrooms", p.NumBathrooms);
            command.Parameters.Add("city", p.City);
            command.Parameters.Add("street", p.Street);
            command.Parameters.Add("building_number", p.BuildingNumber);
            command.Parameters.Add("description", p.Description);
            command.Parameters.Add("area", p.Area);
            command.Parameters.Add("status", p.Status);
            command.Parameters.Add("phone_number", p.PhoneNumber);

            int r = command.ExecuteNonQuery();
            conn.Close();

            if(r<=0)
            {
                return false;
            }
            return true;

        }
        //public void Update_property(int property_id, byte status, decimal start_price, decimal end_price, OracleConnection conn)
        //{
        //    //conn.Open();
        //    OracleCommand command = new OracleCommand();
        //    command.CommandType = CommandType.Text;
        //    command.Connection = conn;
        //    command.CommandText = "UPDATE properties SET status = :status, start_price = :start_price, end_price = :end_price WHERE property_id = :property_id";

        //    command.Parameters.Add("status", status);
        //    command.Parameters.Add("start_price", start_price);
        //    command.Parameters.Add("end_price", end_price);
        //    command.Parameters.Add("property_id", property_id);

        //    int r = command.ExecuteNonQuery();
        //    //conn.Close();

        //}
        public void Delete_property(int property_id)
        {

            conn.Open();

            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.CommandText = "DELETE FROM Property WHERE property_id = :property_id";

            command.Parameters.Add("property_id", property_id);

            int r = command.ExecuteNonQuery();
            conn.Close();

        }

        public void Update_property(ref OracleDataAdapter adapter,ref DataSet ds)
        {
            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        public List<Property> search_DB_Dis(string L_email, ref OracleDataAdapter adapter,ref DataSet ds)
        {

            string constr = "Data Source=ORCL;User Id=Property_finder;Password=prop_finder";
            string cmdstr = "SELECT * FROM properties WHERE prop_lister_email = :lister_email";

            ds = new DataSet();
            adapter = new OracleDataAdapter(cmdstr, constr);

            adapter.SelectCommand.Parameters.Add(":lister_email",L_email);


            adapter.Fill(ds);

            List<Property> properties = new List<Property>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                int propertyId = Convert.ToInt32(row["property_id"]);
                string Property_ListerEmail = row["prop_lister_email"].ToString();
                string type = row["property_type"].ToString();
                decimal startPrice = Convert.ToDecimal(row["start_price"]);
                decimal endPrice = Convert.ToDecimal(row["end_price"]);
                int numRooms = Convert.ToInt32(row["num_rooms"]);
                int numBathrooms = Convert.ToInt32(row["num_bathrooms"]);
                string cityy = row["City"].ToString();
                string street = row["street"].ToString();
                string buildingNumber = row["building_number"].ToString();
                string description = row["description"].ToString();
                decimal area = Convert.ToDecimal(row["area"]);
                string status = row["status"].ToString();
                string phoneNumber = row["phone_number"].ToString();

                Property property = new Property(propertyId, Property_ListerEmail, type, startPrice, endPrice, numRooms, numBathrooms, cityy, street, buildingNumber, description, area, status, phoneNumber);
                properties.Add(property);
            }

            return properties;
        }


        //public void Update_property(int property_id, byte status, decimal start_price, decimal end_price)
        //{
        //    string constr = "Data Source=orcl; User Id=scott;Password=tiger;";
        //    string cmdstr = "SELECT * FROM properties WHERE property_id = :property_id";

        //    using (OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, constr))
        //    {
        //        adapter.SelectCommand.Parameters.Add("property_id", OracleDbType.Int32).Value = property_id;

        //        DataSet ds = new DataSet();
        //        adapter.Fill(ds);

        //        if (ds.Tables[0].Rows.Count > 0)
        //        {
        //            DataRow row = ds.Tables[0].Rows[0];
        //            row["status"] = status;
        //            row["start_price"] = start_price;
        //            row["end_price"] = end_price;

        //            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
        //            adapter.Update(ds.Tables[0]);
        //        }
        //    }
        //}


        //public List<Property> search_DB_Dis(string L_email)
        //{
        //    string constr = "Data Source=ORCL; User Id=hr; password=hr;";
        //    string cmdstr = "SELECT * FROM properties WHERE prop_lister_email = :lister_email";
        //    OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, constr);
        //    adapter.SelectCommand.Parameters.Add(":lister_email", OracleDbType.Varchar2, 50).Value = L_email;

        //    DataSet ds = new DataSet();
        //    adapter.Fill(ds);

        //    List<Property> properties = new List<Property>();
        //    foreach (DataRow row in ds.Tables[0].Rows)
        //    {
        //        int propertyId = Convert.ToInt32(row["property_id"]);
        //        string Property_ListerEmail = row["prop_lister_email"].ToString();
        //        string type = row["property_type"].ToString();
        //        decimal startPrice = Convert.ToDecimal(row["start_price"]);
        //        decimal endPrice = Convert.ToDecimal(row["end_price"]);
        //        int numRooms = Convert.ToInt32(row["num_rooms"]);
        //        int numBathrooms = Convert.ToInt32(row["num_bathrooms"]);
        //        string cityy = row["City"].ToString();
        //        string street = row["street"].ToString();
        //        string buildingNumber = row["building_number"].ToString();
        //        string description = row["description"].ToString();
        //        decimal area = Convert.ToDecimal(row["area"]);
        //        byte status = Convert.ToByte(row["status"]);
        //        string phoneNumber = row["phone_number"].ToString();

        //        Property property = new Property(propertyId, Property_ListerEmail, type, startPrice, endPrice, numRooms, numBathrooms, cityy, street, buildingNumber, description, area, status, phoneNumber);
        //        properties.Add(property);
        //    }

        //    return properties;
        //}


        //Property property = new Property(propertyId, Property_ListerEmail, type, startPrice, endPrice, numRooms, numBathrooms, cityy, street, buildingNumber, description, Area, status, phoneNumber);
        //properties.Add(property);


        //public Property check_properties(string phone_number, OracleConnection conn)
        //{
        //    OracleCommand command = new OracleCommand();
        //    command.CommandType = CommandType.Text;
        //    command.Connection = conn;
        //    command.CommandText = "SELECT * FROM Property WHERE phone_number = :phone_number";

        //    command.Parameters.Add("phone_number", phone_number);

        //    OracleDataReader reader = command.ExecuteReader();

        //    if (reader.Read())
        //    {
        //        Property p = new Property((int)reader[0]);

        //        p.ListerId = reader.GetInt32(1);
        //        p.Type = reader.GetString(2);
        //        p.StartPrice = (decimal)reader[3];
        //        p.EndPrice = (decimal)reader[4];
        //        p.NumRooms = reader.GetInt32(5);
        //        p.NumBathrooms = reader.GetInt32(6);
        //        p.City = reader.GetString(7);
        //        p.Street = reader.GetString(8);
        //        p.BuildingNumber = reader.GetString(9);
        //        p.Description = reader.GetString(10);
        //        p.Area = reader.GetDecimal(11);
        //        p.Status = reader.GetString(12);
        //        p.PhoneNumber = reader.GetString(13);
        //        reader.Close();
        //        return p;
        //    }
        //    else
        //    {
        //        reader.Close();
        //        return null;
        //    }
        //}




    }
}
