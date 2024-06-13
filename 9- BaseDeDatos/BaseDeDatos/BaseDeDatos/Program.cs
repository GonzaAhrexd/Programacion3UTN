using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace BaseDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(SqlConnection cn = new SqlConnection())
            {
            cn.ConnectionString = GetConnectionString();
            // La idea de ADO.NET es utilizar la menor cantidad posible el estado de open
            cn.Open();
            Console.WriteLine(cn.State);


            }

        }

        private static string GetConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "GONZA\\SQLEXPRESS";
            builder.InitialCatalog = "ObrasSociales";
            builder.IntegratedSecurity = true;
            String connectionString = builder.ConnectionString;

            return connectionString;
        }
    }
}
