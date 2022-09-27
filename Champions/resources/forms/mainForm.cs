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
        }
         /// <summary>
        /// Setup the database configuration
        /// </summary>
        static void SetupDatabase()
        {
            SQLiteController SqliteControler = new SQLiteController();
        }
    }
}
