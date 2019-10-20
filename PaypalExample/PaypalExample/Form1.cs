using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaypalEngine;

namespace PaypalExample
{
    public partial class Form1 : Form
    {
        EngineData Valor = EngineData.Instance();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GetToken_Click(object sender, EventArgs e)
        {
            GetTokenAccess();
        }

        private async void GetTokenAccess()
        {
            PaypalEngineCode Funcion = new PaypalEngineCode();
            RespuestaPaypalToken resultado = new RespuestaPaypalToken();
            resultado = await Funcion.GetTokenAccess("ASkS5hVqL10HOWswIX2ktbB5-B-owxJynGDiKeE41Nd-2-NXAhD9nIPX99H3zOpCfw2_pHzqPcN8wkOD", 
                                                     "EKxAMafaLpeF04j9sioqIgzS-Y_nbjf3JCIq_6eL_12gCWnCKvEOpPsU5aChzgX386EQlFqmordebMze",
                                                     "client_credentials", "https://api.sandbox.paypal.com/v1/oauth2/token");
            Valor.RespuestaPaypalToken = resultado;
            richText.Text = resultado.access_token;
        }

        private void CreateOrder_Click(object sender, EventArgs e)
        {
            CreateOrderPaypal();
        }

        private async void CreateOrderPaypal()
        {
            PaypalEngineCode Funcion = new PaypalEngineCode();
            RespuestaCreateOrder resultado = new RespuestaCreateOrder();
            resultado = await Funcion.CreateOrder(Valor.RespuestaPaypalToken.access_token, "https://api.sandbox.paypal.com/v2/checkout/orders", "Curso-Sudoku", "Curso-Sudoku", "11.19");
            Valor.RespuestaCreateOrder = resultado;
            richText.Text = resultado.id;
        }

        private void DetailsOrder_Click(object sender, EventArgs e)
        {
            DetailsOrderPaypal();
        }

        private async void DetailsOrderPaypal()
        {
            PaypalEngineCode Funcion = new PaypalEngineCode();
            RespuestaDetailsOrder resultado = new RespuestaDetailsOrder();
            resultado = await Funcion.DetailsOrder(Valor.RespuestaPaypalToken.access_token, "https://api.sandbox.paypal.com/v2/checkout/orders/" + Valor.RespuestaCreateOrder.id);
            Valor.RespuestaDetailsOrder = resultado;
            richText.Text = resultado.status + " " + resultado.id + " " + resultado.intent;
        }
    }
}
