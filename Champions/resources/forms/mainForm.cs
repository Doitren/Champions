using Champions.database.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Champions
{
    public partial class mainForm : Form
    {
        SQLiteController SqliteControler;
        public mainForm()
        {
            InitializeComponent();

            SetupDatabase();

            defaultState();
        }

        private void defaultState()
        {
            timer_Tick(null, null);
        }

        /// <summary>
        /// Setup the database configuration
        /// </summary>
        void SetupDatabase()
        {
            this.SqliteControler = new SQLiteController();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            bool connectionSQLite = false;

            connectionSQLite = SqliteControler.ChampionsDatabase.CheckConnectionStatus();

            if (connectionSQLite)
            {
                sqliteConnectionLbl.Text = "SQLite database: Připojená";
            }
            else
            {
                sqliteConnectionLbl.Text = "SQLite database: Nepřipojená";
            }
        }
    }
}
