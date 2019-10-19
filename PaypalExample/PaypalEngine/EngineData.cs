using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaypalEngine
{
    public class EngineData
    {
        private static EngineData valor;
        public static EngineData Instance()
        {
            if ((valor == null))
            {
                valor = new EngineData();
            }
            return valor;
        }

        public RespuestaPaypalToken RespuestaPaypalToken { get; set; }
    }
}
