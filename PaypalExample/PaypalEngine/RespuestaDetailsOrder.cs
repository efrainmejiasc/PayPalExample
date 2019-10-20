using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaypalEngine
{
    public class RespuestaDetailsOrder
    {
        public string id { get; set; }
        public string status { get; set; }
        public string intent { get; set; }
        public List<PurchaseUnit> purchase_units { get; set; }
        public DateTime create_time { get; set; }
        public List<Link> links { get; set; }

        public class Amount
        {
            public string currency_code { get; set; }
            public string value { get; set; }
        }

        public class PurchaseUnit
        {
            public string reference_id { get; set; }
            public Amount amount { get; set; }
        }

        public class Link
        {
            public string href { get; set; }
            public string rel { get; set; }
            public string method { get; set; }
        }
    }
}
