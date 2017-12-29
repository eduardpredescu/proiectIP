using static BCrypt.Net.BCrypt;
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
            db.Connection.Close();
            
            return loginStatus;
        }
    }
}
