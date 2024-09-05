using System.Data;
using System.Data.SqlClient;

namespace SistemaFacturacionWinform.Clases
{
    public class DetFactura
    {
        public int IdDetalle { get; set; }
        public int IdFactura { get; set; }
        public int IdProducto { get; set; }
        public string NProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }

        private AccesoDatos accesoDatos = new AccesoDatos();

        public void CrearDetFactura()
        {
            accesoDatos.EjecutarComando("CrearDetFactura",
                new SqlParameter("@IdFactura", IdFactura),
                new SqlParameter("@IdProducto", IdProducto),
                new SqlParameter("@Cantidad", Cantidad),
                new SqlParameter("@PrecioUnitario", PrecioUnitario),
                new SqlParameter("@Subtotal", Subtotal));
        }

        public DataTable LeerDetallesFactura(int idFactura)
        {
            DataTable detalles = new DataTable();

            detalles = accesoDatos.EjecutarProcedimiento("ConsultarDetalleFactura",
                       new SqlParameter("@IdFactura", idFactura));

            return detalles;
        }

    }

}
