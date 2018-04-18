using Pesebrera.NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pesebrera.SERVICIOS
{
    public partial class ServicioGeneracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // método accedido desde el javascript del Front end que invoca el Negocio
        [WebMethod]
        public static void Generar()
        {
            Generacion gen = new Generacion();
            gen.GenerarArchivos();
        }
    }
}