using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace MyBlindMusic
{
    class Class1
    {
        public SqlConnection cnx = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=blind-test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public SqlDataReader dr;
        public string s;
        public string bs;
        public string max;
    }
}
