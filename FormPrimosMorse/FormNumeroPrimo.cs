using FormPrimosMorse.Contratos.Request;
using FormPrimosMorse.Contratos.Responses;
using FormPrimosMorse.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace FormPrimosMorse
{
    public partial class FormNumeroPrimo : Form
    {
        public FormNumeroPrimo()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Principal form1 = new Principal();
            form1.Show();
            this.Hide();
        }
        // VERIFICA QUE EL VALOR NO SEA NULO, RECIBE EL NUMERO QUE SE DESEA VERIFICAR Y DEVUELVE LA VERIFICACION + LA LISTA DE NUMEROS PRIMOS DEL 1 AL 100 AL FORM
        private void btnComprobar_Click(object sender, EventArgs e)
        {
            string numeroS = txtIngreso.Text; 

            HttpClient client = new HttpClient();

            if (string.IsNullOrWhiteSpace(numeroS))
            {
                MessageBox.Show("Debe ingresar un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelLista.Text = "";
                labelResultado.Text = "";
                labelTexto.Text = "";
                return;
            }
            int.TryParse(numeroS, out int numeroI);
            var responses = new ClientRest(BaseAPI.Backend).GetResponse<ListaPrimosResponses, EsPrimoRequest>(HttpMethod.Get, "/Primo/listaprimos", null);
            labelTexto.Text = "Números primos del 1 al 100:\n";
            string numerosPrimosTexto = string.Join(", ", responses.Valores);
            labelLista.Text = numerosPrimosTexto;

            var request = new EsPrimoRequest { Numero = numeroI };
            var response = new ClientRest(BaseAPI.Backend).GetResponse<EsPrimoResponses, EsPrimoRequest>(HttpMethod.Post, "/Primo/esprimo", request);

            if (response.EsPrimo)
            {
                labelResultado.Text = numeroI + " es primo.";
                return;
            }
            labelResultado.Text = numeroI + " no es primo.";
        }
        /// <summary>
        /// NO PERMITE INGRESAR VALORES QUE NO SEAN NUMERICOS ENTEROS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textIngreso_TextChanged(object sender, EventArgs e)
        {
            string texto = txtIngreso.Text;

            if (!string.IsNullOrWhiteSpace(texto))
            {
                if (!int.TryParse(texto, out int numero))
                {
                    MessageBox.Show("Debe ingresar un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIngreso.Text = "";
                }
            }
        }
    }
}
