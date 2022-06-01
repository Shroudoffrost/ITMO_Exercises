using System.Configuration;

namespace Data_adapter_tinkering
{
    internal class Sql_tools
    {
        public static string Query = "SELECT * FROM Customers";
        public static string DB_credentials = ConfigurationManager.ConnectionStrings["db_credentials"].ConnectionString;
    }
}
