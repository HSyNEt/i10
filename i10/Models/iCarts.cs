using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace i10.Models
{
    public class iCarts
    {
        public int Id { get; set; }
        public string account_id { get; set; }
        public int product_id { get; set; }
        public string product_name { get; set; }

        public string product_descript { get; set; }
        public string product_price { get; set; }
        public int product_qua { get; set; }
        public string product_img { get; set; }
    }
}