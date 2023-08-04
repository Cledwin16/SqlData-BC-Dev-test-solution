using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewClient
{
    public static class DBConnection
    {
        public static string CnnVal(string name) 
        {
            String Value = ConfigurationManager.ConnectionStrings[name].ConnectionString;
            return Value;
        }
    }
}
