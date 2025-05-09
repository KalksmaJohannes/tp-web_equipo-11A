using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPWeb_equipo_11A
{
    public partial class Voucher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string codigo = voucherInput.Text.Trim();
            VoucherNegocio negocio = new VoucherNegocio();

            if (!negocio.existeVoucher(codigo))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alerta", "window.onload = function() { alert('¡Ups! Código inexistente'); document.getElementById('" + voucherInput.ClientID + "').focus(); };", true);
            }
            else
            {
                // Código válido
                //SI EXISTE EL VOUCHER SE DEBE REDIRIGIR A LA PÁGINA QUE CONTENGA LOS PRODUCTOS QUE SE PUEDEN CANJEAR 
            }
        }
    }
}