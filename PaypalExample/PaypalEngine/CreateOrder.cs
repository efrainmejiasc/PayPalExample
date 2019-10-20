using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaypalEngine
{
    public class CreateOrder
    {
        public string intent { get; set; }
        public List<PurchaseUnit> purchase_units { get; set; }

        public class PurchaseUnit
        {
            public string reference_id { get; set; }
            public string description { get; set; }
            public Amount amount { get; set; }
        }

        public class Amount
        {
            public string currency_code { get; set; }
            public string value { get; set; }
        }
    }
}
