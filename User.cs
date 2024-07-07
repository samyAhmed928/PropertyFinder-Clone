using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.IO;

namespace prop_finder
{
    public class User
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string User_Email { get; set; }

        public byte[] profile_image { get; set; }
        //public void Insert()
        //{
        //    using (SqlConnection connection = new SqlConnection(ConnectionString))
        //    {
        //        string query = "INSERT INTO User values(:user_email, :user_password, :first_name, :last_name)";
        //                       //"VALUES (@Email, @Password, @FirstName, @LastName)";
        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.Parameters.AddWithValue("first_name", FirstName);
        //        command.Parameters.AddWithValue("last_name", LastName);
        //        command.Parameters.AddWithValue("user_password", Password);
        //        command.Parameters.AddWithValue("user_email", User_Email);
        //        connection.Open();
        //        command.ExecuteNonQuery();
        //    }
        //}

        //public void Update()
        //{
        //    using (SqlConnection connection = new SqlConnection(ConnectionString))
        //    {
        //        string query = "UPDATE User " +
        //                       "SET first_name = @FirstName, last_name = @LastName, password = @Passwordd" +
        //                       "WHERE email = @Email";
        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@FirstName", FirstName);
        //        command.Parameters.AddWithValue("@LastName", LastName);
        //        command.Parameters.AddWithValue("@Passwordd", Password);
        //        command.Parameters.AddWithValue("@Email", User_Email);
        //        connection.Open();
        //        command.ExecuteNonQuery();
        //    }
        //}

        //public void Delete()
        //{
        //    using (SqlConnection connection = new SqlConnection(ConnectionString))
        //    {
        //        string query = "DELETE FROM User " +
        //                       "WHERE email = @Email";
        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@Email", User_Email);
        //        connection.Open();
        //        command.ExecuteNonQuery();
        //    }
        //}

        //public static User GetById(string Email)
        //{
        //    using (SqlConnection connection = new SqlConnection(ConnectionString))
        //    {
        //        string query = "SELECT * FROM User " +
        //                       "WHERE email = @Email";
        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@Email", userId);
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            return new User
        //            {
        //                UserId = reader.GetInt32(reader.GetOrdinal("user_id")),
        //                FirstName = reader.GetString(reader.GetOrdinal("first_name")),
        //                LastName = reader.GetString(reader.GetOrdinal("last_name")),
        //                Password = reader.GetString(reader.GetOrdinal("passwordd")),
        //                Email = reader.GetString(reader.GetOrdinal("email"))
        //            };
        //        }
        //        return null;
        //    }
        //}

        //public List<Property> search(string city, OracleConnection conn)
        //{
        //    //conn.Open();
        //    List<Property> properties = new List<Property>();

        //    OracleCommand command = new OracleCommand();
        //    command.Connection = conn;
        //    command.CommandText = "select_properties_1";
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.Parameters.Add("city", city);
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
        //        byte status = Convert.ToByte(reader["status"]);
        //        string phoneNumber = reader["phone_number"].ToString();

        //        Property property = new Property(propertyId, Property_ListerEmail, type, startPrice, endPrice, numRooms, numBathrooms, cityy, street, buildingNumber, description, area, status, phoneNumber);
        //        properties.Add(property);
        //    }

        //    return properties;
        //    //conn.Close();

        //}

        //public List<Property> search_DB(string area, OracleConnection conn)
        //{
        //    //conn.Open();
        //    List<Property> properties = new List<Property>();

        //    using (OracleCommand command = conn.CreateCommand())
        //    {
        //        command.CommandText = "SELECT * FROM properties WHERE area > :area";
        //        command.Parameters.Add(new OracleParameter("area", OracleDbType.Varchar2, area, ParameterDirection.Input));

        //        using (OracleDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                int propertyId = Convert.ToInt32(reader["property_id"]);
        //                string Property_ListerEmail = reader["prop_lister_email"].ToString();
        //                string type = reader["property_type"].ToString();
        //                decimal startPrice = Convert.ToDecimal(reader["start_price"]);
        //                decimal endPrice = Convert.ToDecimal(reader["end_price"]);
        //                int numRooms = Convert.ToInt32(reader["num_rooms"]);
        //                int numBathrooms = Convert.ToInt32(reader["num_bathrooms"]);
        //                string city = reader["City"].ToString();
        //                string street = reader["street"].ToString();
        //                string buildingNumber = reader["building_number"].ToString();
        //                string description = reader["description"].ToString();
        //                decimal Area = Convert.ToDecimal(reader["area"]);
        //                byte status = Convert.ToByte(reader["status"]);
        //                string phoneNumber = reader["phone_number"].ToString();

        //                Property property = new Property(propertyId, Property_ListerEmail, type, startPrice, endPrice, numRooms, numBathrooms, city, street, buildingNumber, description, Area, status, phoneNumber);
        //                properties.Add(property);
        //            }
        //        }
        //    }

        //    return properties;
        //    //conn.Close();
        //}



    }
}
