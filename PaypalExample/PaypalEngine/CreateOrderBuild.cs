using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaypalEngine
{
    public class CreateOrderBuild
    {
        private string currencyId = "USD";


        public string BuildCreateOrderSingle(string idProduct, string product, string value)
        {
            string resultado = string.Empty;
            CreateOrder order = new CreateOrder
            {
                intent = "CAPTURE",
                purchase_units = PurchaseUnit(idProduct, product, value)
            };
            resultado = JsonConvert.SerializeObject(order);
            return resultado;
        }

        private List<CreateOrder.PurchaseUnit> PurchaseUnit(string idProduct, string product, string value)
        {
            List<CreateOrder.PurchaseUnit> lista = new List<CreateOrder.PurchaseUnit>();
            CreateOrder.PurchaseUnit item = new CreateOrder.PurchaseUnit()
            {
                reference_id = idProduct,
                description = product,
                amount = new CreateOrder.Amount()
                {
                    currency_code = currencyId,
                    value = value
                }
            };
            lista.Add(item);
            return lista;
        }


      

    }
}


