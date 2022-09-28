using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Champions.database.SQLite
{
    interface ISQLite
    {
        bool SetUpConnection();
        bool CheckConnectionStatus();
        void SQLiteCommadProcced(string sql);
        void OpenConnection();
        void CloseConnection();
        DataTable SQLiteGetDataTable(string sql);
        List<string[]> SQLiteGetListArrays(string sql);
    }
}
