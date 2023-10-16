using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace AutoRepairShop.Data
{
    public class DataContext
    {
        private static DataContext _instance;
        private string _connectionString;
        private MySqlConnection _dbConection;

        public Action<string> Logger;

        public DataContext(string connectionString, Action<string> logger)
        {
            _instance = this;
            _connectionString = connectionString;
            _dbConection = new MySqlConnection(_connectionString);
            Logger = logger;
        }

        public static DataContext GetInstance()
        {
            if (_instance == null)
                throw new ArgumentNullException("Instace is null, create him.");
            return _instance;
        }

        public MySqlConnection Connection
        {
            get { return _dbConection; }
        }

        public void TestConnection()
        {
            try
            {
                _dbConection.Open();
            }
            catch (Exception ex)
            {
                Logger(ex.Message);
            }
            _dbConection.Close();
        }

        public DataTable QueryReturn(string query, params MySqlParameter[] parameters)
        {
            DataTable table = new DataTable();
            try
            {
                _dbConection.Open();
                MySqlCommand command = new MySqlCommand(query, _dbConection);
                foreach (var param in parameters)
                    command.Parameters.Add(param);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(table);
            }
            catch (Exception ex)
            {
                Logger(ex.Message + "\n" + query);
            }
            _dbConection.Close();
            return table;
        }

        public void QueryExecute(string query, params MySqlParameter[] parameters)
        {
            try
            {
                _dbConection.Open();
                MySqlCommand command = new MySqlCommand(query, _dbConection);
                foreach (var param in parameters)
                    command.Parameters.Add(param);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Logger(ex.Message + "\n" + query);
            }
            _dbConection.Close();
        }
    }
}
