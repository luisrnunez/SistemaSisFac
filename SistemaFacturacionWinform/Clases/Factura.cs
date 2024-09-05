using System.Data;
using System.Data.SqlClient;

namespace SistemaFacturacionWinform.Clases
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public decimal Pago { get; set; }
        public decimal Cambio { get; set; }

        private AccesoDatos accesoDatos = new AccesoDatos();

        public DataTable LeerFacturas()
        {
            return accesoDatos.EjecutarProcedimiento("ListarFacturas");
        }

        public DataTable CrearFactura()
        {
            return accesoDatos.EjecutarProcedimiento("CrearFactura",
                new SqlParameter("@IdCliente", IdCliente),
                new SqlParameter("@IdEmpleado", IdEmpleado),
                new SqlParameter("@Fecha", Fecha),
                new SqlParameter("@Total", Total),
                new SqlParameter("@Pago", Pago),
                new SqlParameter("@Cambio", Cambio));
        }

        public DataTable ImprimirFactura()
        {
            return accesoDatos.EjecutarProcedimiento("LeerFacturas");
        }

    }



}
