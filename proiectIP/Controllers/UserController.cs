using static BCrypt.Net.BCrypt;
using System;
namespace proiectIP.Controllers
{
    class UserController
    {
        private static string conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\BazaDeDateIP.accdb";
        private static DatabaseController db = new DatabaseController(conn, null, null);

        public static bool Login(string username, string password, bool type)
        {
            bool loginStatus = false;


            db.Connection.Open();
            string table = type ? "MedicLogin" : "PatientLogin";
            string condition = " WHERE ";
            condition = " WHERE ";
            condition += type ? 
                "MedicEmail = @email" : 
                "PatientEmail = @email";
            db.Command = new System.Data.OleDb.OleDbCommand("SELECT Password FROM " + table + condition, db.Connection);
            db.Command.Parameters.AddWithValue("@email", username);
            db.Reader = db.Command.ExecuteReader();
            if (db.Reader.Read())
            {
                loginStatus = Verify(password,(string) db.Reader[0]) ? true : false;
            }
            db.Reader.Close();
            db.Connection.Close();

            return loginStatus;
        }

        public static bool insertPatient(string username, string password, int patientId)
        {
            bool dataInserted = false;
            db.Connection.Open();

            db.Command = new System.Data.OleDb.OleDbCommand("INSERT INTO PatientLogin(PatientEmail, [Password], Patient_ID) VALUES (@username, @password, @patientId)", db.Connection);
            db.Command.Parameters.AddWithValue("@username", username);
            db.Command.Parameters.AddWithValue("@password", HashPassword(password));
            db.Command.Parameters.AddWithValue("@patientId", patientId);
            
            try
            {
                db.Command.ExecuteNonQuery();
                dataInserted = true;
                db.Connection.Close();
            } catch (System.Data.OleDb.OleDbException ex)
            {
                Console.WriteLine(ex);
                db.Connection.Close();
            }
           
            return dataInserted;
        }
    }
}
