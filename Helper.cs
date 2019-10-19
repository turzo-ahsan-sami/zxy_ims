using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZXY_IMS
{
    public static class Helper
    {
        public static string SqlConnectionString(string dbname = "")
        {
            string dbName = "db_zxy_ims";
            return  ConfigurationManager.ConnectionStrings[dbName].ConnectionString;
        }
    }
}
