using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PaypalEngine
{
    public class PaypalEngineCode
    {
        //Un token de portador le permite completar acciones en nombre y con la aprobación del propietario del recurso
        public async Task<RespuestaPaypalToken> GetTokenAccess(string clientId , string keySecret,string clientCredentials ,string endPointTokenPaypal)
        {
            string respuesta = string.Empty;
            RespuestaPaypalToken resultado = new RespuestaPaypalToken();
            using (HttpClient client = new HttpClient())
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(clientId + ":" + keySecret);
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                client.DefaultRequestHeaders.Add("accept-language", "en_ES");
                client.DefaultRequestHeaders.Add("accept", "application/json");
                Uri url = new Uri(endPointTokenPaypal, UriKind.Absolute);
                List<KeyValuePair<string, string>> formData = new List<KeyValuePair<string, string>>();
                formData.Add(new KeyValuePair<string, string>("grant_type", clientCredentials));
                HttpContent content = new FormUrlEncodedContent(formData);
                HttpResponseMessage response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsStringAsync();
                    resultado = JsonConvert.DeserializeObject<RespuestaPaypalToken>(respuesta);
                }
            }

            return resultado;
        }

        //Un pedido representa un pago entre dos o más partes.Use la API de pedidos para crear, actualizar, recuperar, autorizar y capturar pedidos
        public async Task<RespuestaCreateOrder> CreateOrder(string accessToken,string EndPointCreateOrderPaypal, string idProduct, string product, string value)
        {
            string respuesta = string.Empty;
            RespuestaCreateOrder resultado = new RespuestaCreateOrder();
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.Add("accept-language", "en_ES");
                CreateOrderBuild Funcion = new CreateOrderBuild();
                string jsonCreateOrder = Funcion.BuildCreateOrderSingle(idProduct, product, value);
                HttpResponseMessage response = await client.PostAsync(EndPointCreateOrderPaypal, new StringContent(jsonCreateOrder, Encoding.UTF8, "application/json"));
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsStringAsync();
                    resultado = JsonConvert.DeserializeObject<RespuestaCreateOrder>(respuesta);
                }
            }
              
            return resultado;
        }

        //Muestra detalles de un pedido, por ID.
        public async Task <RespuestaDetailsOrder> DetailsOrder (string accessToken , string EndPointDetailsOrderPaypal)
        {
            string respuesta = string.Empty;
            RespuestaDetailsOrder resultado = new RespuestaDetailsOrder();
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.Add("accept-language", "en_ES");
                HttpResponseMessage response = await client.GetAsync(EndPointDetailsOrderPaypal);
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsStringAsync();
                    resultado = JsonConvert.DeserializeObject<RespuestaDetailsOrder>(respuesta);
                }
            }

            return resultado;
        }

    }
}
