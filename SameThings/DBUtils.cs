using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SameThings
{
  class DBUtils
  {
    public static SqlConnection GetDBConnection()
    {
      //Data Source=NGOCBX-PC;Initial Catalog=SameThings;Integrated Security=True
      string datasource = @"NGOCBX-PC";

      string database = "SameThings";
      string username = "xuanngoc";
      string password = "123";

      return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
    }

  }
}
