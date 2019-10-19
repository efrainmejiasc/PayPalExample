using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PaypalEngine
{
    public class PaypalEngineCode
    {

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
    }
}
