using System.Collections.Generic;
using System.Data.OleDb;
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
            db.Command = new OleDbCommand("SELECT * FROM Patient", db.Connection);
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
            db.Command = new OleDbCommand("SELECT Patient.* FROM PatientLogin INNER JOIN Patient " +
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
            db.Command = new OleDbCommand("SELECT Patient.* FROM PatientLogin INNER JOIN Patient " +
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

        public static int savePatient(string name, string surname, string bloodType)
        {
            int newId = -1;
            db.Connection.Open();
            db.Command = new OleDbCommand("INSERT INTO Patient (PatientName, PatientSurname, PatientBloodType) VALUES " +
                "(@name, @surname, @bloodType)", db.Connection);

            db.Command.Parameters.AddWithValue("@name", name);
            db.Command.Parameters.AddWithValue("@surname", surname);
            db.Command.Parameters.AddWithValue("@bloodType", bloodType);

            try
            {
                db.Command.ExecuteNonQuery();
                OleDbCommand cmd = new OleDbCommand("SELECT @@IDENTITY", db.Connection);
                newId = (int)cmd.ExecuteScalar();
                db.Connection.Close();
            }
            catch
            {
                db.Connection.Close();
            }

            return newId;
        }

    }
}
