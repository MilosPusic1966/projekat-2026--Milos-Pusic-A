using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace projekat_2026__Milos_Pusic_A
{
    internal class konekcija
    {
        static public SqlConnection Connect(string gde)
        {
            string CS;
            CS = ConfigurationManager.ConnectionStrings[gde].ConnectionString;
            return new SqlConnection(CS);
        }
    }
}
