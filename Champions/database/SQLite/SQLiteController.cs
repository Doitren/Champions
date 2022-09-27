using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Champions.database.SQLite
{
    public class SQLiteController
    {
        public ChampionDatabase ChampionsDatabase;

        public SQLiteController()
        {
            SetupDatabases();
        }

        void SetupDatabases()
        {
            this.ChampionsDatabase = new ChampionDatabase();
        }
    }
}
