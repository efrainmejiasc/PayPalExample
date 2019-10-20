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

        public string BuildCreateOrder(string idProduct , string product, string value, string merchantId)
        {
            string resultado = string.Empty;
            CreateOrder order = new CreateOrder
            {
                intent = "CAPTURE",
                purchase_units = PurchaseUnit(idProduct,product,value,merchantId),
                application_context = new CreateOrder.ApplicationContext
                {
                    return_url = "https://www.paypal.com/apex/api/redirect/success/p4p_ordersv2/updateOrder?isInteractive=true&userId=1571508072667&productId=18",
                    cancel_url = "https://www.paypal.com/apex/api/redirect/cancel/p4p_ordersv2/approvePayment?isInteractive=true&userId=1571508072667&productId=18"
                }

            };
            resultado = JsonConvert.SerializeObject(order);
            return resultado;
        }

        private List<CreateOrder.PurchaseUnit> PurchaseUnit(string idProduct, string product, string value, string merchantId)
        {
            List<CreateOrder.PurchaseUnit> lista = new List<CreateOrder.PurchaseUnit>();
            CreateOrder.PurchaseUnit item = new CreateOrder.PurchaseUnit()
            {
                reference_id = idProduct,
                description = product,
                amount = new CreateOrder.Amount()
                {
                    currency_code = currencyId,
                    value = value,
                    breakdown = new CreateOrder.Breakdown()
                    {
                        item_total = new CreateOrder.ItemTotal
                        {
                            currency_code = currencyId,
                            value = value,
                        },
                        shipping = new CreateOrder.Shipping()
                        {
                            currency_code = currencyId,
                            value = "0",
                        },
                        handling = new CreateOrder.Handling
                        {
                            currency_code = currencyId,
                            value = "0"

                        },
                        tax_total = new CreateOrder.TaxTotal
                        {
                            currency_code = currencyId,
                            value = "0"
                        },
                        gift_wrap = new CreateOrder.GiftWrap
                        {
                            currency_code = currencyId,
                            value = "0"

                        },
                        shipping_discount = new CreateOrder.ShippingDiscount
                        {
                            currency_code = currencyId,
                            value = "0"

                        }
                    },
                },
                payee = new CreateOrder.Payee()
                {
                    merchant_id = merchantId
                },
                items = ListItem(),
                shipping = new CreateOrder.Shipping2
                {
                    address = new CreateOrder.Address
                    {
                        address_line_1 = "500 Hillside Street",
                        address_line_2 = "#1000",
                        admin_area_1 = "CA",
                        admin_area_2 = "San Jose",
                        postal_code = "95131",
                        country_code = "US"
                    }
                },
                shipping_method = "United Postal Service",
                payment_instruction = new CreateOrder.PaymentInstruction()
                {
                    disbursement_mode = "DELAYED",
                    platform_fees = PlatformFee()
                },
                payment_group_id = 1,
                custom_id = "custom_value_1571509051489",
                invoice_id = "invoice_number_1571509051489",
                soft_descriptor = "Payment Camera Shop"
            };
            lista.Add(item);
            return lista;
        }


        private List<CreateOrder.Item> ListItem()
        {
            List<CreateOrder.Item> lista = new List<CreateOrder.Item>();
            CreateOrder.Item item = new CreateOrder.Item()
            {
                name = "Levis 501 Selvedge STF",
                sku = "5158936",
                unit_amount = new CreateOrder.UnitAmount()
                {
                    currency_code = currencyId,
                    value = "25.00"

                },
                tax = new CreateOrder.Tax()
                {
                    currency_code = currencyId,
                    value = "0.00"
                },
                quantity = "1",
                category = "PHYSICAL_GOODS"
            };
            lista.Add(item);
            return lista;
        }

        private List<CreateOrder.PlatformFee> PlatformFee()
        {
            List<CreateOrder.PlatformFee> lista = new List<CreateOrder.PlatformFee>();
            CreateOrder.PlatformFee item = new CreateOrder.PlatformFee()
            {
                 amount = new CreateOrder.Amount2
                 {
                       currency_code = "USD",
				       value = "2.00"
                 },
				 payee = new CreateOrder.Payee2 {
                 email_address = "service.connected@partnerplace.example.com"
                 }
            };
            lista.Add(item);
            return lista;
        }

    }
}


