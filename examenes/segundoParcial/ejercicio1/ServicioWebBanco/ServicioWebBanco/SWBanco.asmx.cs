using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServicioWebBanco
{
    /// <summary>
    /// Descripción breve de SWBanco
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWBanco : System.Web.Services.WebService
    {

        [WebMethod]
        public string obtenerCotizacion(string moneda)
        {
            if (moneda == "US")
            {
                return "6,96";
            }
            else
                return "8,5";
        }
    }
}
