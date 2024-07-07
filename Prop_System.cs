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
using System.Drawing;

namespace prop_finder
{

    class Prop_System
    {
        string ordb;
        OracleConnection conn;

        public Prop_System()
        {
            ordb = "Data Source=ORCL;User Id=Property_finder;Password=prop_finder";
            conn = new OracleConnection(ordb);
        }
        public Lister Lister_LogIn(string email, string passwordd)
        {
            Lister L = null;
            conn.Open();

            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = "lister_login";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("mail", OracleDbType.Varchar2, ParameterDirection.Input).Value = email;
            command.Parameters.Add("pass", OracleDbType.Varchar2, ParameterDirection.Input).Value = passwordd;

            command.Parameters.Add("FName", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            command.Parameters.Add("LName", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            command.Parameters.Add("LMail", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            command.Parameters.Add("Passw_out", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;

            command.Parameters.Add("CName", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            command.Parameters.Add("JTitle", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            command.Parameters.Add("PNumber", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;

            // Add a new parameter to retrieve the profile_pic column
            command.Parameters.Add("profile_pic", OracleDbType.Blob, ParameterDirection.Output);

            command.ExecuteNonQuery();

            string firstName = command.Parameters["FName"].Value.ToString();
            string lastName = command.Parameters["LName"].Value.ToString();
            string Email = command.Parameters["LMail"].Value.ToString();
            string pass = command.Parameters["Passw_out"].Value.ToString();
            string CName = command.Parameters["CName"].Value.ToString();
            string JTitle = command.Parameters["JTitle"].Value.ToString();
            string PNumber = command.Parameters["PNumber"].Value.ToString();

            // Retrieve the profile_pic value from the OracleParameter
            byte[] profilePic = (byte[])command.Parameters["profile_pic"].Value;

            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(pass))
            {
                return null;
            }

            L = new Lister(firstName, lastName, Email, pass, CName, JTitle, PNumber, profilePic);
            

            conn.Close();

            return L;
        }

        //public Lister Lister_LogIn(string email, string passwordd)
        //{
        //    Lister L = null;
        //    conn.Open();

        //    OracleCommand command = new OracleCommand();
        //    command.Connection = conn;
        //    command.CommandText = "lister_login";
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.Parameters.Add("mail", OracleDbType.Varchar2, ParameterDirection.Input).Value = email;
        //    command.Parameters.Add("pass", OracleDbType.Varchar2, ParameterDirection.Input).Value = passwordd;

        //    command.Parameters.Add("FName", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
        //    command.Parameters.Add("LName", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
        //    command.Parameters.Add("LMail", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
        //    command.Parameters.Add("Passw_out", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;

        //    command.Parameters.Add("CName", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
        //    command.Parameters.Add("JTitle", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
        //    command.Parameters.Add("PNumber", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;

        //    command.ExecuteNonQuery();

        //    string firstName = command.Parameters["FName"].Value.ToString();
        //    string lastName = command.Parameters["LName"].Value.ToString();
        //    string Email = command.Parameters["LMail"].Value.ToString();
        //    string pass = command.Parameters["Passw_out"].Value.ToString();
        //    string CName = command.Parameters["CName"].Value.ToString();
        //    string JTitle = command.Parameters["JTitle"].Value.ToString();
        //    string PNumber = command.Parameters["PNumber"].Value.ToString();
        //    if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(pass))
        //    {
        //        return null;
        //    }

        //    L = new Lister(firstName, lastName,Email, pass, CName, JTitle, PNumber);

        //    conn.Close();

        //    return L;
        //}

        //public Rentee rentee_LogIn(string email, string passwordd)
        //{
        //    conn.Open();

        //    OracleCommand command = new OracleCommand();
        //    command.Connection = conn;
        //    command.CommandText = "rentee_login";
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.Parameters.Add("mail", OracleDbType.Varchar2, ParameterDirection.Input).Value = email;
        //    command.Parameters.Add("pass", OracleDbType.Varchar2, ParameterDirection.Input).Value = passwordd;
        //    command.Parameters.Add("FName", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
        //    command.Parameters.Add("LName", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
        //    command.Parameters.Add("EMail", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
        //    command.Parameters.Add("Passw", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
        //    command.ExecuteNonQuery();

        //    string firstName = command.Parameters["FName"].Value.ToString();
        //    string lastName = command.Parameters["LName"].Value.ToString();
        //    string Email = command.Parameters["EMail"].Value.ToString();
        //    string pass = command.Parameters["Passw"].Value.ToString();

        //    if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(pass))
        //    {
        //        return null;
        //    }

        //    Rentee R = new Rentee(Email, pass, firstName, lastName);
        //    conn.Close();

        //    return R;

        //}

        public Rentee rentee_LogIn(string email, string passwordd)
        {
            conn.Open();

            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandText = "rentee_login";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("mail", OracleDbType.Varchar2, ParameterDirection.Input).Value = email;
            command.Parameters.Add("pass", OracleDbType.Varchar2, ParameterDirection.Input).Value = passwordd;
            command.Parameters.Add("FName", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            command.Parameters.Add("LName", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            command.Parameters.Add("EMail", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            command.Parameters.Add("Passw", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            command.Parameters.Add("ProfilePic", OracleDbType.Blob, ParameterDirection.Output);
            command.ExecuteNonQuery();

            string firstName = command.Parameters["FName"].Value.ToString();
            string lastName = command.Parameters["LName"].Value.ToString();
            string Email = command.Parameters["EMail"].Value.ToString();
            string pass = command.Parameters["Passw"].Value.ToString();

            byte[] profilePicBytes = null;
            OracleBlob blob = command.Parameters["ProfilePic"].Value as OracleBlob;
            if (blob != null && blob.Length > 0)
            {
                profilePicBytes = new byte[blob.Length];
                blob.Read(profilePicBytes, 0, (int)blob.Length);
            }

            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(pass))
            {
                return null;
            }

            Rentee R = new Rentee(Email, pass, firstName, lastName, profilePicBytes);
            conn.Close();

            return R;
        }


        public bool sign_up_rentee(Rentee rentee)
        {
            conn.Open();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            //user, first , last , pass , email
            command.CommandText = "INSERT INTO Users(user_email,user_password ,first_name, last_name,PROFILE_PIC) VALUES(:user_email, :user_password ,:first_name,:last_name,:image_array) ";



            command.Parameters.Add("user_email", rentee.User_Email);
            command.Parameters.Add("user_password", rentee.Password);
            command.Parameters.Add("first_name", rentee.FirstName);
            command.Parameters.Add("last_name", rentee.LastName);
            command.Parameters.Add(":image_array", OracleDbType.Blob).Value = rentee.profile_image;


            int r = command.ExecuteNonQuery();
            if(r<=0)
            {
                conn.Close();
                return false;
            }
            OracleCommand command2 = new OracleCommand();
            command2.CommandType = CommandType.Text;
            command2.Connection = conn;
            command2.CommandText = "INSERT INTO rentees(rentee_email) VALUES(:rentee_email) ";

            command2.Parameters.Add("rentee_email", rentee.User_Email);
            int r2 = command2.ExecuteNonQuery();
            if (r2 <= 0)
            {
                conn.Close();

                return false;
            }

            
            conn.Close();
            return true;

        }

        public bool sign_up_lister(Lister L)
        {
            conn.Open();

            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            //user, first , last , pass , email
            command.CommandText = "INSERT INTO Users(user_email,user_password ,first_name, last_name,PROFILE_PIC) VALUES(:user_email, :user_password ,:first_name,:last_name,:image_array) ";



            command.Parameters.Add("user_email", L.User_Email);
            command.Parameters.Add("user_password", L.Password);
            command.Parameters.Add("first_name", L.FirstName);
            command.Parameters.Add("last_name", L.LastName);
            command.Parameters.Add(":image_array", OracleDbType.Blob).Value = L.profile_image;


            command.Parameters.Add("user_email", L.User_Email);
            command.Parameters.Add("user_password", L.Password);
            command.Parameters.Add("first_name", L.FirstName);
            command.Parameters.Add("last_name", L.LastName);
            


            int r = command.ExecuteNonQuery();
            if (r <= 0)
            {
                conn.Close();
                return false;
            }

            OracleCommand command2 = new OracleCommand();
            command2.CommandType = CommandType.Text;
            command2.Connection = conn;
            command2.CommandText = "INSERT INTO Listers(lister_email, company_name, job_title, phone_number) VALUES(:lister_email, :company_name,:job_title,:phone_number)";

            command2.Parameters.Add("lister_email", L.User_Email);
            command2.Parameters.Add("company_name", L.Company_name);
            command2.Parameters.Add("job_title", L.Job_title);
            command2.Parameters.Add("phone_number", L.Phone_number);
            int r2 = command2.ExecuteNonQuery();
            if (r2 <= 0)
            {
                conn.Close();

                return false;
            }


            conn.Close();
            return true;

        }
    }
    }
