using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsAndUnitTesting
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double[] estratos = new double[] { 0, 0, 0, 0, 0, 0 };
            int edadResponsables = 0;
            int familiasSinAyuda = 0;
            double sumDonaciones = 0;

            foreach (Familia familia in Main.familias)
            {
                estratos[familia.Estrato - 1] += familia.Ayuda;
                edadResponsables += familia.Edad;
                sumDonaciones += familia.Ayuda;

                if(familia.Ayuda == 0)
                {
                    familiasSinAyuda += 1;
                }
            }

            // ayudas por estrato
            lblEstrato1.Text = "Estrato 1: " + estratos[0].ToString();
            lblEstrato2.Text = "Estrato 2: " + estratos[1].ToString();
            lblEstrato3.Text = "Estrato 3: " + estratos[2].ToString();
            lblEstrato4.Text = "Estrato 4: " + estratos[3].ToString();
            lblEstrato5.Text = "Estrato 5: " + estratos[4].ToString();
            lblEstrato6.Text = "Estrato 6: " + estratos[5].ToString();

            // Edad promedio encargados familias
            if (Main.familias.Count > 0)
            {
                lblEdadPromedio.Text = (edadResponsables / Main.familias.Count).ToString();
            } else
            {
                lblEdadPromedio.Text = "0";
            }

            // Familias sin ayuda
            lblFamiliasNoAyuda.Text = familiasSinAyuda.ToString();

            // Total ayudas
            lblTotalAyudas.Text = sumDonaciones.ToString();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Main.entregarAyudas(Convert.ToInt32(txtIdFamilia.Text), Convert.ToDouble(txtValorAporte.Text));
                lblError.Text = "";
            }
            catch (Exception ex)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + ex.Message + "');", true);
                lblError.Text = "Error al rellenar un campo numerico";
                return;
            }
        }
    }
}