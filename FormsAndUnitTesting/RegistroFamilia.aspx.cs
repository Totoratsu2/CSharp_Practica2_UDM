using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormsAndUnitTesting
{
    public partial class RegistroFamilia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            txtApellido.Text = "";
            txtBarrio.Text = "";
            txtDireccion.Text = "";
            txtEdad.Text = "";
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            ddlEstratos.Text = "";
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string barrio = txtBarrio.Text;
            int estrato, identificacion, edad;

            try
            {
                estrato = Convert.ToInt32(ddlEstratos.Text);
                identificacion = Convert.ToInt32(txtIdentificacion.Text);
                edad = Convert.ToInt32(txtEdad.Text);
            }
            catch (Exception ex)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ex", "alert('" + ex.Message + "');", true);
                //lblError.Text = "Error al rellenar un campo numerico";
                lblError.Text = ex.Message;
                clear();
                return;
            }

            if (nombre == "" || apellido == "" || direccion == "" || barrio == "")
            {
                lblError.Text = "Todos los campos son obligatorios";
            } else if(identificacion < 0 || edad < 0)
            {
                lblError.Text = "Ningun valor numerico puede ser menor a 0";
            } else
            {
                Familia familia = new Familia(identificacion, nombre, apellido, direccion, estrato, barrio, edad);
                Main.familias.Add(familia);
                lblError.Text = "";
            }

            clear();
        }
    }
}