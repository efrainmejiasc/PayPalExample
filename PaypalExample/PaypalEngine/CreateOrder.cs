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
        public ApplicationContext application_context { get; set; }

        public class PurchaseUnit
        {
            public string reference_id { get; set; }
            public string description { get; set; }
            public Amount amount { get; set; }
            public Payee payee { get; set; }
            public List<Item> items { get; set; }
            public Shipping2 shipping { get; set; }
            public string shipping_method { get; set; }
            public PaymentInstruction payment_instruction { get; set; }
            public int payment_group_id { get; set; }
            public string custom_id { get; set; }
            public string invoice_id { get; set; }
            public string soft_descriptor { get; set; }
        }

        public class ItemTotal
        {
            public string currency_code { get; set; }
            public string value { get; set; }
        }

        public class Shipping
        {
            public string currency_code { get; set; }
            public string value { get; set; }
        }

        public class Handling
        {
            public string currency_code { get; set; }
            public string value { get; set; }
        }

        public class TaxTotal
        {
            public string currency_code { get; set; }
            public string value { get; set; }
        }

        public class GiftWrap
        {
            public string currency_code { get; set; }
            public string value { get; set; }
        }

        public class ShippingDiscount
        {
            public string currency_code { get; set; }
            public string value { get; set; }
        }

        public class Breakdown
        {
            public ItemTotal item_total { get; set; }
            public Shipping shipping { get; set; }
            public Handling handling { get; set; }
            public TaxTotal tax_total { get; set; }
            public GiftWrap gift_wrap { get; set; }
            public ShippingDiscount shipping_discount { get; set; }
        }

        public class Amount
        {
            public string currency_code { get; set; }
            public string value { get; set; }
            public Breakdown breakdown { get; set; }
        }

        public class Payee
        {
            public string merchant_id { get; set; }
        }

        public class UnitAmount
        {
            public string currency_code { get; set; }
            public string value { get; set; }
        }

        public class Tax
        {
            public string currency_code { get; set; }
            public string value { get; set; }
        }

        public class Item
        {
            public string name { get; set; }
            public string sku { get; set; }
            public UnitAmount unit_amount { get; set; }
            public Tax tax { get; set; }
            public string quantity { get; set; }
            public string category { get; set; }
        }

        public class Address
        {
            public string address_line_1 { get; set; }
            public string address_line_2 { get; set; }
            public string admin_area_1 { get; set; }
            public string admin_area_2 { get; set; }
            public string postal_code { get; set; }
            public string country_code { get; set; }
        }

        public class Shipping2
        {
            public Address address { get; set; }
        }

        public class Amount2
        {
            public string currency_code { get; set; }
            public string value { get; set; }
        }

        public class Payee2
        {
            public string email_address { get; set; }
        }

        public class PlatformFee
        {
            public Amount2 amount { get; set; }
            public Payee2 payee { get; set; }
        }

        public class PaymentInstruction
        {
            public string disbursement_mode { get; set; }
            public List<PlatformFee> platform_fees { get; set; }
        }

        public class ApplicationContext
        {
            public string return_url { get; set; }
            public string cancel_url { get; set; }
        }

    }
}
