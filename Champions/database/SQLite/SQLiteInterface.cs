using System;
using System.Collections.Generic;

public class SQLiteInterface
{
	interface SQLiteInterface()
	{
		public void SQLiteCommadProcced(string sql);

		public DataTable SQLiteGetDataTable(string sql);

		public List<string[]> SQLiteGetListArrays(string sql);
	}	
}
