using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace Champions.database.SQLite
{
    public class ChampionDatabase : ISQLite
    {
        SqliteConnection SqlConnection;
        SqliteCommand SqlCommand;
        SqliteDataReader SqlReader;
        public ChampionDatabase()
        {
            if (!SetUpConnection())
            {
                throw new NotSupportedException();
            }
        }
        /// <summary>
        /// Closes connetion to database
        /// </summary>
        public void CloseConnection()
        {
            try
            {
                SqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when closing connection: " + ex.ToString());
            }
        }
        /// <summary>
        /// Opens connection to database
        /// </summary>
        public void OpenConnection()
        {
            try
            {
                SqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured when opening connection: " + ex.ToString());
            }
        }
        /// <summary>
        /// Creates inner file if not existing
        /// Then set SqlConnection. Return bool according to result
        /// </summary>
        /// <returns>if the setup was succesfull</returns>
        public bool SetUpConnection()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Method proceeds sql param
        /// </summary>
        /// <param name="sql">Desired sql</param>
        public void SQLiteCommadProcced(string sql)
        {
            OpenConnection();
            SqlCommand = SqlConnection.CreateCommand();
            SqlCommand.CommandText = sql;
            SqlCommand.ExecuteNonQuery();
            CloseConnection();
        }
        /// <summary>
        /// Method returns DataTable according to sql
        /// </summary>
        /// <param name="sql">Desired sql</param>
        /// <returns>Datable filled with data</returns>
        public DataTable SQLiteGetDataTable(string sql)
        {
            DataTable Result = new DataTable();

            OpenConnection();

            SqlCommand = SqlConnection.CreateCommand();
            SqlCommand.CommandText = sql;

            SqlReader = SqlCommand.ExecuteReader();

            Result.Load(SqlReader);

            CloseConnection();

            return Result;
        }
        /// <summary>
        /// List of strings of arrays
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>List of strings of arrays filled with data. First contains header</returns>
        public List<string[]> SQLiteGetListArrays(string sql)
        {
            throw new NotImplementedException();
        }
    }
}
