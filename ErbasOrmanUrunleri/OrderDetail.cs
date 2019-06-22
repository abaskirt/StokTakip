using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ErbasOrmanUrunleri
{
    public class OrderDetail
    {
        public int quantity
        {
            get;
            set;
        }
        public int productId
        {
            get;
            set;
        }
        public string productName
        {
            get;
            set;
        }
        public string mainProductName
        {
            get;
            set;
        }
    }
}
