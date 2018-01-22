using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace OTC_Handler
{
    internal class DatabaseManager
    {
       public DatabaseManager()
        {

        }

        public void setup()
        {

        }

        private string databaseName = string.Empty;
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }

        public string Password { get; set; }
        private MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        private static DatabaseManager _instance = null;
        public static DatabaseManager Instance()
        {
            if (_instance == null)
                _instance = new DatabaseManager();
            return _instance;
        }

        public bool IsConnect()
        {
            if (Connection == null)
            {
                if (string.IsNullOrEmpty(databaseName))
                    return false;
                string connstring = string.Format("Server=localhost; database={0}; UID=root; password=;", databaseName);
                connection = new MySqlConnection(connstring);
                connection.Open();
            }

            return true;
        }

        public void Close()
        {
            connection.Close();
        }
    }
}