using System.Collections.Generic;
using proiectIP.Models;

namespace proiectIP.Controllers
{
    class MedicController
    {
        private static string conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\BazaDeDateIP.accdb";
        private static DatabaseController db = new DatabaseController(conn, null, null);

        public static List<Medic> getAll()
        {
            db.Connection.Open();
            db.Command = new System.Data.OleDb.OleDbCommand("SELECT * FROM Medic", db.Connection);
            db.Reader = db.Command.ExecuteReader();

            List<Medic> mList = new List<Medic>();

            while (db.Reader.Read())
            {
                mList.Add(new Medic((int)db.Reader[0],
                    (string)db.Reader[1],
                    (string)db.Reader[2],
                    (string)db.Reader[3]));
            }

            db.Reader.Close();
            db.Connection.Close();
            return mList;
        }

        public static Medic getByUsername(string username)
        {
            db.Connection.Open();
            db.Command = new System.Data.OleDb.OleDbCommand("SELECT Medic.* FROM MedicLogin INNER JOIN Medic " +
                "ON MedicLogin.Medic_ID = Medic.ID WHERE MedicLogin.MedicEmail = @username", db.Connection);
            db.Command.Parameters.AddWithValue("@username", username);
            db.Reader = db.Command.ExecuteReader();

            Medic m;
            if (db.Reader.Read())
            {
                m =  new Medic((int)db.Reader[0], (string)db.Reader[1], (string)db.Reader[2], (string)db.Reader[3]);   
            }
            else m = new Medic(-1, "NONE", "", "");
            db.Reader.Close();
            db.Connection.Close();
            return m;
        }

        public static Medic getById(int id)
        {
            db.Connection.Open();
            db.Command = new System.Data.OleDb.OleDbCommand("SELECT Medic.* FROM MedicLogin INNER JOIN Medic " +
                "ON MedicLogin.Medic_ID = Medic.ID WHERE MedicLogin.Medic_ID = @id", db.Connection);
            db.Command.Parameters.AddWithValue("@id", id);
            db.Reader = db.Command.ExecuteReader();

            Medic m;
            if (db.Reader.Read())
            {
                m = new Medic((int)db.Reader[0], (string)db.Reader[1], (string)db.Reader[2], (string)db.Reader[3]);

            }
            else m = new Medic(-1, "NONE", "", "");
            db.Reader.Close();
            db.Connection.Close();
            return m;
        }
    }
}
