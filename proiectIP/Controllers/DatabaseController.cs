using System.Data.OleDb;

namespace proiectIP.Controllers
{
    class DatabaseController
    {
        private OleDbConnection connection;
        private OleDbDataReader reader;
        private OleDbCommand command;

        public OleDbConnection Connection { get => connection; set => connection = value; }
        public OleDbDataReader Reader { get => reader; set => reader = value; }
        public OleDbCommand Command { get => command; set => command = value; }

        public DatabaseController(string conn, OleDbDataReader reader, OleDbCommand command)
        {
            this.connection = new OleDbConnection(conn);
            this.reader = reader;
            this.command = command;
        } 
    }
}
