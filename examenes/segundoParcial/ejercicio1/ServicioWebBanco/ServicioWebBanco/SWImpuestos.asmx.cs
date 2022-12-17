using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServicioWebBanco
{
    /// <summary>
    /// Descripción breve de SWImpuestos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SWImpuestos : System.Web.Services.WebService
    {

        [WebMethod]
        public string sincronizarFechaHora()
        {
            DateTime date = DateTime.Now;
            return date.ToString();
        }
        [WebMethod]
        public string obtenerCrufd(int idambiente, int modalidad, int nit)
        {
            return "AB00000345C34521";
        }
        [WebMethod]
        public string emitirFactura(int idAmbiente, int nit, string cufD, int modalidad, factura factura)
        {
            int cuf = idAmbiente + nit;
            factura = new factura();
            factura error = new factura();

            factura.nit = nit;
            factura.razonSocial = "Correcto";
            factura.fecha = sincronizarFechaHora();
            factura.numeroFactura = "123";
            factura.cuf = cuf;
            factura.cliente.nit = nit;
            factura.cliente.ci = nit;
            factura.cliente.nombre = "Pedro";
            factura.detalle.cantidad = 3;
            factura.detalle.producto = "Detergente";
            factura.detalle.preciounitario = "10.5";
            factura.detalle.precioTotal = "31.5";
            error.razonSocial = "error";

            string respuesta = "valido";

            return respuesta;
        }

    }
}
