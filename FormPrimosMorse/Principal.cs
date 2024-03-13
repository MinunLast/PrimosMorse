using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrimosMorse
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnPrimo_Click(object sender, EventArgs e)
        {
            FormNumeroPrimo primo = new FormNumeroPrimo();
            primo.Show();
            this.Hide();
        }

        private void btnMorse_Click(object sender, EventArgs e)
        {
            FormCodigoMorse morse = new FormCodigoMorse();
            morse.Show();
            this.Hide();
        }

        private async void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
