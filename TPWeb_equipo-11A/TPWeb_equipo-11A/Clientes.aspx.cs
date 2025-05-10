using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace TPWeb_equipo_11A
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnParticipar_Click(object sender, EventArgs e)
        {
            ClienteNegocio negocio = new ClienteNegocio();
            string documento = txtDNI.Text;

            try
            {
                Cliente cliente = negocio.existeCliente(documento);
                if (cliente != null)
                {
                    txtNombre.Text = cliente.Nombre;
                    txtApellido.Text = cliente.Apellido;
                    txtEmail.Text = cliente.Email;
                    txtDireccion.Text = cliente.Direccion;
                    txtCiudad.Text = cliente.Ciudad;
                    txtCP.Text = cliente.CodigoPostal.ToString();
                }
                else
                {
                    Cliente nuevo = new Cliente();
                    nuevo.Documento = documento;
                    nuevo.Nombre = txtNombre.Text;
                    nuevo.Apellido = txtApellido.Text;
                    nuevo.Email = txtEmail.Text;
                    nuevo.Direccion = txtDireccion.Text;
                    nuevo.Ciudad = txtCiudad.Text;
                    nuevo.CodigoPostal = int.Parse(txtCP.Text);

                    negocio.agregarCliente(nuevo);

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alerta", "alert('¡Registro exitoso!');", true);

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}