using System.Collections.Generic;
using proiectIP.Models;

namespace proiectIP.Controllers
{
    class PatientController
    {
        private static string conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\BazaDeDateIP.accdb";
        private static DatabaseController db = new DatabaseController(conn, null, null);

        public static List<Patient> getAll()
        {
            db.Connection.Open();
            db.Command = new System.Data.OleDb.OleDbCommand("SELECT * FROM Patient", db.Connection);
            db.Reader = db.Command.ExecuteReader();

            List<Patient> pList = new List<Patient>();

            while (db.Reader.Read())
            {
                pList.Add(new Patient((int)db.Reader[0],
                    (string)db.Reader[1],
                    (string)db.Reader[2],
                    (string)db.Reader[3]));
            }

            db.Reader.Close();
            db.Connection.Close();
            return pList;
        }

        public static Patient getByUsername(string username)
        {
            db.Connection.Open();
            db.Command = new System.Data.OleDb.OleDbCommand("SELECT Patient.* FROM PatientLogin INNER JOIN Patient " +
                "ON PatientLogin.Patient_ID = Patient.ID WHERE PatientLogin.PatientEmail = @username", db.Connection);
            db.Command.Parameters.AddWithValue("@username", username);
            db.Reader = db.Command.ExecuteReader();

            Patient p;

            if (db.Reader.Read()) p = new Patient((int)db.Reader[0], (string)db.Reader[1], (string)db.Reader[2], (string)db.Reader[3]);
            else p = new Patient(-1, "NONE", "", "");
            db.Reader.Close();
            db.Connection.Close();
            return p;

        }

        public static Patient getById(int id)
        {
            db.Connection.Open();
            db.Command = new System.Data.OleDb.OleDbCommand("SELECT Patient.* FROM PatientLogin INNER JOIN Patient " +
                "ON PatientLogin.Patient_ID = Patient.ID WHERE PatientLogin.Patient_ID = @id", db.Connection);
            db.Command.Parameters.AddWithValue("@id", id);
            db.Reader = db.Command.ExecuteReader();

            Patient p;

            if (db.Reader.Read()) p = new Patient((int)db.Reader[0], (string)db.Reader[1], (string)db.Reader[2], (string)db.Reader[3]);
            else p = new Patient(-1, "NONE", "", "");
            db.Reader.Close();
            db.Connection.Close();
            return p;

        }

    }
}
