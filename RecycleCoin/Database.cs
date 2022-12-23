using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RecycleCoin
{
    public class Database
    {
        public SqlConnection conn;
        public SqlCommand cmd;
        public void Baglan()
        {
            conn = new SqlConnection("Data Source="+LoginInfo.pcName+";Initial Catalog=RecycleCoin;Integrated Security=True");
        }
    }
}
