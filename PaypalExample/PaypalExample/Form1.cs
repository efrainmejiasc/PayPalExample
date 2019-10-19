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
        }


    }
}
