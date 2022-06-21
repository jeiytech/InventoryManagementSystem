using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace firstProject
{
    class sqlConnect
    {

        public static SqlConnection Connect() {

            SqlConnection Conn = null;

            try
            {
                Conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\HP\Documents\inventoryMgmt.mdf;Integrated Security = True; Connect Timeout = 30");
            }catch(SqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return Conn;
        }
    }
}
