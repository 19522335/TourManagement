using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour
{
    public static class ConnectStringDB
    {
        public static string GetConnectString()
        {
            return @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=TourManagement;Integrated Security=True";
        }
    }
}
