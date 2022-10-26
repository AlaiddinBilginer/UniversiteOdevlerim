using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OtomasyonProje
{
   
    class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection connection = new SqlConnection("veritabanı bağlantısı");
            connection.Open();
            return connection;
        }
    }
}
