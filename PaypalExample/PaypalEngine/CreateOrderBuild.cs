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
        public string BuildCreateOrder(string idProduct , string product)
        {
            string resultado = string.Empty;
            CreateOrder order = new CreateOrder
            {
                intent = "CAPTURE",
                purchase_units = PurchaseUnit(idProduct,product),


            };
            resultado = JsonConvert.SerializeObject(order);
            return resultado;
        }

        public List<CreateOrder.PurchaseUnit> PurchaseUnit(string idProduct, string product)
        {
            List<CreateOrder.PurchaseUnit> lista = new List<CreateOrder.PurchaseUnit>();
            CreateOrder.PurchaseUnit single = new CreateOrder.PurchaseUnit()
            {
                reference_id = idProduct,
                description = product,
                amount = new CreateOrder.Amount()
                {

                },
            };
            lista.Add(single);
            return lista;
        }
    }
}
