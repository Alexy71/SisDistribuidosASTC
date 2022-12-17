using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioWebBanco
{
    public class factura
    {
        public int nit;
        public string razonSocial;
        public string fecha;
        public string numeroFactura;
        public int cuf;
        public string mensaje;
        public string estado;
        //public string tipoDocumento;
        //public string nombreCliente;
        public detalleFact detalle = new detalleFact();
        public tipoDocumento cliente = new tipoDocumento();
    }
}