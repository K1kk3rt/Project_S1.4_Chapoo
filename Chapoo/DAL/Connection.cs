using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public static class Connection
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=194.171.20.101;Initial Catalog=RBS_1718_DB01;Persist Security Info=True;User ID=RBS_1718_grp01;Password=DmTvu91L3w");
        }
    }
}
