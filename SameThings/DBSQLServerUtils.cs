using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient ;

namespace SameThings
{
  class DBSQLServerUtils
  {
    public static SqlConnection
                 GetDBConnection(string datasource, string database, string username, string password)
    {

      // Data Source=NGOCBX-PC;Initial Catalog=SameThings;Integrated Security=True
      string connString = @"Data Source=" + datasource + ";Initial Catalog="
                  + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password
                  + "Trusted_Connection=true;Integrated Security=True";

      SqlConnection conn = new SqlConnection(connString);

      return conn;
    }
  }
}
