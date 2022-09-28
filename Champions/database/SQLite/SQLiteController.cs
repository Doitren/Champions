using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Champions.database.SQLite
{
    public class SQLiteController
    {
        public ChampionDatabase ChampionsDatabase { get; set; }

        public SQLiteController()
        {
            SetupDatabases();
        }

        void SetupDatabases()
        {
            this.ChampionsDatabase = new ChampionDatabase();
            CreateTablesChampion();
        }
        void CreateTablesChampion()
        {
            if(this.ChampionsDatabase != null && this.ChampionsDatabase.CheckConnectionStatus())
            {
                this.ChampionsDatabase.SQLiteCommadProcced("" +
                    "CREATE TABLE " +
                        "CHAMPIONS(id INT PRIMARY KEY AUTOINCREMENT," +
                                   "name VARCHAR(30)," +
                                   "gender VARCHAR(8)," +
                                   "nationality VARCHAR(30)," +
                                   "role VARCHAR(10)," +
                                   "weaponType VARCHAR(20)," +
                                   "origin VARCHAR(30));");
            }
        }
    }
}
