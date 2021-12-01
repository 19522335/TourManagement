using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour
{
    public class DataConnection
    {
        public string conStr { get; set; }
        public DataConnection()
        {
            //conStr = "Data Source= DESKTOP-QLEJV95\\SQLEXPRESS; Initial Catalog=TourManagement; Integrated Security=True";
            conStr = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=TourManagement;Integrated Security=True";
        }

        private static DataConnection _Ins;
        public static DataConnection Ins
        {
            get
            {
                if (_Ins == null)
                {
                    _Ins = new DataConnection();
                }
                return _Ins;
            }
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }

    }
}
