using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaFacturacionWinform.Clases
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public int IdProveedor { get; set; }
        public int NProveedor { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        private AccesoDatos accesoDatos = new AccesoDatos();

        public DataTable LeerProductos()
        {
            return accesoDatos.EjecutarProcedimiento("LeerProductos");
        }

        public void CrearProducto()
        {
            accesoDatos.EjecutarComando("CrearProducto",
                new SqlParameter("@nombre", Nombre),
                new SqlParameter("@descripcion", Descripcion),
                new SqlParameter("@precio", Precio),
                 new SqlParameter("@idproveedor", IdProveedor),
                new SqlParameter("@stock", Stock));
        }

        public void ActualizarProducto()
        {
            accesoDatos.EjecutarComando("ActualizarProducto",
                new SqlParameter("@idproducto", IdProducto),
                    new SqlParameter("@nombre", Nombre),
                new SqlParameter("@descripcion", Descripcion),
                new SqlParameter("@precio", Precio),
                new SqlParameter("@stock", Stock));
        }

        public void EliminarProducto(int idProducto)
        {
            accesoDatos.EjecutarComando("EliminarProducto",
                new SqlParameter("@idproducto", idProducto));
        }

        public DataTable BuscarPorCriterio(string criterio, string valor)
        {
            var accesoDatos = new AccesoDatos();
            var parametros = new[]
            {
                new SqlParameter("@Criterio", criterio),
                new SqlParameter("@Valor", valor)
            };

            return accesoDatos.EjecutarProcedimiento("BuscarProductosPorCriterio", parametros);
        }
        public DataTable VerficarDuplicado(string metodo)
        {
            var accesoDatos = new AccesoDatos();
            var parametros = new[]
            {
                new SqlParameter("@id", IdProducto),
                new SqlParameter("@nombre", Nombre),
                new SqlParameter("@metodo", metodo)
            };

            return accesoDatos.EjecutarProcedimiento("VerificarDuplicadosProducto", parametros);
        }
    }

}
