using FormPrimosMorse.Contratos.Request;
using FormPrimosMorse.Contratos.Responses;
using FormPrimosMorse.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace FormPrimosMorse
    
{
    /// <summary>
    /// CLASS DEL FORMULARIO CODIGOMORSE
    /// </summary>
    public partial class FormCodigoMorse : Form
    {
        public FormCodigoMorse()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Principal frm = new Principal();
            frm.Show();
            this.Close();
        }
        /// <summary>
        /// VERIFICA EL TIPO DE TEXTO INGRESADO Y LO TRABAJA PARA DEVOLVER LO ESPERADO AL FORM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnTraducir_Click(object sender, EventArgs e)
        {
            string texto = txtBoxTransformado.Text;

            Regex regex = new Regex("^[\\-\\.\\s]+$");
            if (regex.IsMatch(texto))
            {
                labelEnQue.Text = "El texto se transformo en escritura convencional";
                var request = new MorseDecodificadoRequest { TextoCodificado = texto };
                var response = new ClientRest(BaseAPI.Backend).GetResponse<MorseDecodificadoResponses,MorseDecodificadoRequest>(HttpMethod.Post, "/morse/decodificado", request);
                labelTransformado.Text = response.TextoDecodificado;
            }
            else
            {
                labelEnQue.Text = "El texto se transformo en codigo morse";
                var request = new MorseCodificadoRequest { TextoDecodificado = texto };
                var response = new ClientRest(BaseAPI.Backend).GetResponse<MorseCodificadoResponses, MorseCodificadoRequest>(HttpMethod.Post, "/morse/codificar", request);
                labelTransformado.Text = response.TextoCodificado;
            }
        }
    }
}
