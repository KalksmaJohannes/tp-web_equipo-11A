using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.ComponentModel;
using System.Xml.Linq;

namespace TPWeb_equipo_11A
{
    public partial class Clientes : System.Web.UI.Page
    {
        public Cliente Cliente { get; set; }
        public ClienteNegocio Negocio { get; set; }
        public string Documento { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnParticipar_Click(object sender, EventArgs e)
        {
            ClienteNegocio negocio = new ClienteNegocio();
            Documento = txtDNI.Text;

            try
            {
                Cliente nuevo = negocio.existeCliente(Documento);
                if (nuevo == null)
                {
                    nuevo = new Cliente();

                    nuevo.Documento = Documento;
                    nuevo.Nombre = txtNombre.Text;
                    nuevo.Apellido = txtApellido.Text;
                    nuevo.Email = txtEmail.Text;
                    nuevo.Direccion = txtDireccion.Text;
                    nuevo.Ciudad = txtCiudad.Text;
                    nuevo.CodigoPostal = int.Parse(txtCP.Text);

                    negocio.agregarCliente(nuevo);
                }
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alerta", "alert('¡Registro exitoso!');", true);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void btnValidarDni_Click(object sender, EventArgs e)
        {
            try
            {
                Documento = txtDNI.Text;
                if (Documento == "")
                {
                    lblDni.ForeColor = System.Drawing.Color.Red;
                    lblDni.Text = "Debe ingresar un DNI para validar!";
                    txtDNI.CssClass = "form-control form-control-lg mx-auto form-control is-invalid";
                    return;
                }
                else
                if (Documento.Length < 6)
                {
                    lblDni.ForeColor = System.Drawing.Color.Red;
                    lblDni.Text = "El DNI ingresado es inválido!";
                    txtDNI.CssClass = "form-control form-control-lg mx-auto form-control is-invalid";

                    return;
                }

                Negocio = new ClienteNegocio();
                Cliente = new Cliente();
                Cliente = Negocio.existeCliente(Documento);

                if (Cliente != null)
                {
                    txtNombre.Text = Cliente.Nombre;
                    txtApellido.Text = Cliente.Apellido;
                    txtEmail.Text = Cliente.Email;
                    txtDireccion.Text = Cliente.Direccion;
                    txtCiudad.Text = Cliente.Ciudad;
                    txtCP.Text = Cliente.CodigoPostal.ToString();
                    lblDni.ForeColor = System.Drawing.Color.Green;
                    lblDni.Text = "Bienvenido de nuevo " + Cliente.Nombre + "!";
                    txtDNI.CssClass = "form-control form-control-lg mx-auto form-control is-valid";
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    txtEmail.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtCiudad.Enabled = false;
                    txtCP.Enabled = false;
                }
                else
                {
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtEmail.Text = "";
                    txtDireccion.Text = "";
                    txtCiudad.Text = "";
                    txtCP.Text = "";
                    lblDni.ForeColor = System.Drawing.Color.Green;
                    lblDni.Text = "El DNI ingreasdo es válido! Debes ingresar todos los datos para registrarte.";
                    txtDNI.CssClass = "form-control form-control-lg mx-auto form-control is-valid";
                    txtNombre.Enabled = true;
                    txtApellido.Enabled = true;
                    txtEmail.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtCiudad.Enabled = true;
                    txtCP.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}