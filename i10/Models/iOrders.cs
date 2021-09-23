using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace i10.Models
{
    public class iOrders
    {
        public int id { get; set; }
        public int product_id { get; set; }

        public string product_name { get; set; }

        public string account_id { get; set; }

        public string order_delivery { get; set; }

        public string order_price { get; set; }
    }
}