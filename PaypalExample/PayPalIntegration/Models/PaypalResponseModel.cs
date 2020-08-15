using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayPalIntegration.Models
{
    public class PaypalResponseModel
    {
        public string OrderId { get; set; }

        public string PayerId { get; set; }

        public string PaymentId { get; set; }

        public string FacilitatorAccessToken { get; set; }
    }
}