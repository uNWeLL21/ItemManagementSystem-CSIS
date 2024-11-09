using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Item_Management_System___CSIS.DB_Connection
{
    class Database
    {
        private const string DB_HOST = "localhost";
        public const string DB_NAME = "tmdinventory";
        private const string DB_USERNAME = "root";
        private const string DB_PASSWORD = "";

        private string ConnString = $"SERVER={DB_HOST};USER ID={DB_USERNAME};PASSWORD={DB_PASSWORD};DATABASE={DB_NAME}";
        public MySqlConnection DBConnection = new MySqlConnection();

        public string TableName { get; set; }
        public List<string> Columns { get; set; }
        public List<string> WhereOR { get; set; }
        public List<string> WhereAND { get; set; }
        public string Join { get; set; }
        public string OrderBy { get; set; }

        private string sqlQuery = " ";

        public Database()
        {
            DBConnection = new MySqlConnection(ConnString);
        }

        public void OpenDB()
        {
            try
            {
                if (DBConnection == null)
                {

                    DBConnection.Open();
                }
                else if (DBConnection.State != System.Data.ConnectionState.Open)
                {

                    DBConnection.Open();
                }
                else
                {
                    DBConnection.Open();
                }
            }
            catch (Exception ex)
            {
                Debug.Print($"ERROR: {ex.Message}");

            }

        }

        public void CloseDB()
        {
            DBConnection.Close();
        }

        // retrieve data
        public DataTable GetRows()
        {
            sqlQuery = $"SELECT * FROM {TableName} ";

            // select columns
            if (Columns != null && Columns.Count > 0)
            {
                sqlQuery = $"SELECT {string.Join(", ", Columns)} FROM {TableName} ";
            }

            // join table
            if (Join != null && Join != "")
            {
                sqlQuery += $" {Join} ";
            }

            // filter w/ OR operator
            if (WhereOR != null && WhereOR.Count > 0)
            {
                string whereClause = string.Join($" OR ", WhereOR);
                sqlQuery += $" WHERE ({whereClause})";
                if (WhereAND != null || WhereAND.Count > 0)
                {
                    sqlQuery += $" AND ";
                }
            }

            // filter w/ AND operator
            if (WhereAND != null && WhereAND.Count > 0)
            {
                if (WhereOR == null || WhereOR.Count == 0)
                {
                    sqlQuery += $" WHERE ";
                }
                string whereClause = string.Join($" AND ", WhereAND);
                sqlQuery += $" ({whereClause})";
            }

            // sort data
            if (OrderBy != null && OrderBy != "")
            {
                sqlQuery += $" ORDER BY {OrderBy} ";
            }

            using (MySqlCommand cmd = new MySqlCommand(sqlQuery, DBConnection))
            {
                DataTable dt = new DataTable();
                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    Debug.Print($"ERROR: {ex.Message}");
                    this.CloseDB();
                }
                return dt;
            }
        }

        // adding, updating and deleting
        public bool ExecuteQuery(string sql)
        {
            this.OpenDB();
            using (MySqlCommand cmd = new MySqlCommand(sql, DBConnection))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.Print($"ERROR: {ex.Message}");
                    this.CloseDB();
                }
                return false;
            }
        }

        // get the ID of selected value from CB
        public string getNumber(string cb, List<string> list, List<string> ID)
        {
            int i = 0;
            foreach (string item in list)
            {
                if (item == cb)
                {
                    return ID[i];
                }
                i++;
            }
            return null;
        }

        // check existance
        public bool Unique(string value, string collumn, string table)
        {
            using (var connection = new MySqlConnection(ConnString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = $"SELECT COUNT(*) FROM {table} WHERE {collumn} = @value";
                    command.Parameters.AddWithValue("@value", value);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        // split string
        public string splitString(string str, int index, char spliter)
        {
            string[] Str = str.Split(spliter);
            return Str[index];
        }

        // validate creadentials
        public bool Validate(string username, string password)
        {
            using (var connection = new MySqlConnection(ConnString))
            {
                connection.Open();
                string query = $"SELECT Password, Validity, Role, UserID, Username FROM users WHERE Username = @username";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    using (var reader = command.ExecuteReader())
                    {
                        // check if user exist
                        if (reader.Read())
                        {
                            string result = reader["Password"].ToString();
                            DateTime validData = DateTime.Parse(reader["Validity"].ToString());

                            // check password
                            if (password != result)
                            {
                                MessageBox.Show("Invalid password!");
                                return false;
                            }

                            // check validity
                            if (validData < DateTime.Now)
                            {
                                MessageBox.Show($"User validity expire as of {splitString(validData.ToString(), 0, ' ')}!");
                                return false;
                            }
                            UserInfo.Instance.Initialize(reader["UserID"].ToString(), reader["Role"].ToString(), reader["Username"].ToString());
                            MessageBox.Show("Login Successfully!");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Invalid username!");
                            return false;
                        }
                    }
                }
            }
        }
    }
}
