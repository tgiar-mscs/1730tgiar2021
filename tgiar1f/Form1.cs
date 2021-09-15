using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tgiar1f
{
    public partial class frmCurrencyConverter2 : Form
    {
        public frmCurrencyConverter2()
        {
            InitializeComponent();
        }

        private void frmCurrencyConverter2_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuros.BackgroundImage = picEurosDim.Image;
            txtRate.Text = "0.7179976";
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtUSD.Text = "0.00";
            txtUSDTotal.Text = "0.00";
            txtCurrency.Focus();
        }


        private void btnAustrailia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuros.BackgroundImage = picEurosDim.Image;
            txtRate.Text = "0.7179976";
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtUSD.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnBhutan_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnEuros.BackgroundImage = picEurosDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            txtRate.Text = "0.0139831";
            lblCurrency.Text = btnBhutan.Text + ": ";
            txtUSD.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnCostaRica_Click(object sender, EventArgs e)
        {
            btnCostaRica.BackgroundImage = picCostaRica.Image;
            btnEuros.BackgroundImage = picEurosDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            txtRate.Text = "0.00176122";
            lblCurrency.Text = btnCostaRica.Text + ": ";
            txtUSD.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnEuros_Click(object sender, EventArgs e)
        {
            btnEuros.BackgroundImage = picEuros.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            txtRate.Text = "1.15528";
            lblCurrency.Text = btnEuros.Text + ": ";
            txtUSD.Text = "0.00";
            txtCurrency.Focus();
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSD.Text = (
                Convert.ToDecimal(txtCurrency.Text) * Convert.ToDecimal(txtRate.Text)
                ).ToString("0.00");
            txtCurrency.Focus();
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtUSDTotal.Text = (
                Convert.ToDecimal(txtUSD.Text) + Convert.ToDecimal(txtUSDTotal.Text)
                ).ToString("0.00");
            lblEquation.Text = lblEquation.Text + " + " +  txtUSDTotal.Text;
            txtCurrency.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuros.BackgroundImage = picEurosDim.Image;
            txtRate.Text = "0.7179976";
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtUSD.Text = "0.00";
            txtUSDTotal.Text = "0.00";
            txtCurrency.Focus();
            lblEquation.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
