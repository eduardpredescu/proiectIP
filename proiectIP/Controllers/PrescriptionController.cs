using System.Collections.Generic;
using System.Data.OleDb;
using proiectIP.Models;

namespace proiectIP.Controllers
{
    class PrescriptionController
    {
        private static string conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=.\BazaDeDateIP.accdb";
        private static DatabaseController db = new DatabaseController(conn, null, null);

        public static List<Prescription> getAll()
        {
            db.Connection.Open();
            db.Command = new System.Data.OleDb.OleDbCommand("SELECT " +
                "pr.ID, " +
                "m.MedicName, " +
                "m.MedicSpecialisation," +
                "p.PatientName" +
                "p.PatientSurname" +
                "p.PatientBloodType" +
                "pr.PrescriptionText" +
                " FROM Prescription pr JOIN Medic m " +
                "ON pr.Medic_ID = m.ID " +
                "JOIN Patient p " +
                "ON pr.Patient_ID = p.ID", db.Connection);
            db.Reader = db.Command.ExecuteReader();

            List<Prescription> prList = new List<Prescription>();

            while (db.Reader.Read())
            {
                prList.Add(new Prescription((int)db.Reader[0],
                    (string)db.Reader[1],
                    (string)db.Reader[2],
                    (string)db.Reader[3],
                    (string)db.Reader[4],
                    (string)db.Reader[5],
                    (string)db.Reader[6]));
            }

            db.Reader.Close();

            return prList;
        }

        public static List<Prescription> getPatientPrescription(int id)
        {
            db.Connection.Open();
            db.Command = new System.Data.OleDb.OleDbCommand("SELECT m.MedicName," +
                " m.MedicSpecialisation, " +
                "pr.prescriptionText FROM Medic m INNER JOIN Prescription pr " +
                "ON m.ID = pr.Medic_ID WHERE pr.Patient_ID = @id", db.Connection);
            db.Command.Parameters.AddWithValue("@id", id);
            db.Reader = db.Command.ExecuteReader();

            List<Prescription> prList = new List<Prescription>();

            while (db.Reader.Read())
            {
                prList.Add(new Prescription((string)db.Reader[0],
                    (string)db.Reader[1],
                    (string)db.Reader[2]));
            }

            db.Reader.Close();

            return prList;
        }

        public static bool savePrescription(string prescriptionText, int medicID, int patientID)
        {
            bool dataAdded = false;
            db.Connection.Open();
            db.Command = new OleDbCommand("INSERT INTO Prescription (Medic_ID, Patient_ID, PrescriptionText) VALUES " +
                "(@medicId, @patientId, @prescriptionText)", db.Connection);

            db.Command.Parameters.AddWithValue("@medicId", medicID);
            db.Command.Parameters.AddWithValue("@patientId", patientID);
            db.Command.Parameters.AddWithValue("@prescriptionText", prescriptionText);

            try
            {
                db.Command.ExecuteNonQuery();
                dataAdded = true;
                db.Connection.Close();
            } catch (OleDbException ex)
            {
                db.Connection.Close();
            }

            return dataAdded;
        }
    }
}
