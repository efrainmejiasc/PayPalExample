using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaypalEngine
{
    public class RespuestaCreateOrder
    {
        public string id { get; set; }
        public string status { get; set; }
        public List<Link> links { get; set; }

        public class Link
        {
            public string href { get; set; }
            public string rel { get; set; }
            public string method { get; set; }
        }

    }
}
