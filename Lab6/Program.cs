using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection myConnect = new SqlConnection("Server=trunglnpa00124-lab6.mssql.somee.com; user id=trunglnpa00124; password=Khanhvy0211;database=trunglnpa00124-lab6");
            try
            {
                myConnect.Open();
                Console.WriteLine(myConnect.State.ToString());
                Console.WriteLine("Ket noi thanh cong!");
                Console.WriteLine("Version 1");
                Console.ReadLine();
            }
            catch (SqlException ex)
            {
                
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
