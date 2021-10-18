using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsAndUnitTesting
{
    public partial class RegistroFundacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            txtNIT.Text = "";
            txtSaldo.Text = "";
            txtNombre.Text = "";
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            double saldo = 0.0;
            int nit = 0;
            string nombre = txtNombre.Text;
            
            try{
                saldo = Convert.ToDouble(txtSaldo.Text);
                nit = Convert.ToInt32(txtNIT.Text);
            } catch (Exception ex)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + ex.Message + "');", true);
                lblError.Text = "Error al rellenar un campo numerico";
                clear();
                return;
            }

            if (nombre == "")
            {
                lblError.Text = "Todos los campos son obligatorios";
            } else if (saldo < 0 || nit < 0)
            {
                lblError.Text = "Todos los campos numericos tienen que ser mayores que 0";
            } else
            {
                Fundacion fundacion = new Fundacion(nit, nombre, saldo);
                Main.fundaciones.Add(fundacion);
                lblError.Text = "";
            }

            clear();
        }
    }
}