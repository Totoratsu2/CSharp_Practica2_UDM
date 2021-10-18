using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsAndUnitTesting
{
    public partial class RegistroBenefactor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void clear()
        {
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            txtAyuda.Text = "";
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string identificacion = txtIdentificacion.Text;
            string nombre = txtNombre.Text;
            double ayuda = 0.0;

            try {
                ayuda = Convert.ToDouble(txtAyuda.Text);
            }
            catch (Exception ex)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + ex.Message + "');", true);
                lblError.Text = "Error al rellenar un campo numerico";
                clear();
                return;
            }

            if(identificacion == "" || nombre == "")
            {
                lblError.Text = "Todos los campos son obligatorios";
            } else if (ayuda < 0)
            {
                lblError.Text = "El campo ayuda debe de ser mayor a 0";
            } else
            {
                Benefactor benefactor = new Benefactor(identificacion, nombre, ayuda);
                Main.benefactores.Add(benefactor);
                lblError.Text = "";
            }

            clear();
        }
    }
}