using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaFacturacionWinform.Clases
{
    public class Proveedor 
    {

        protected AccesoDatos accesoDatos = new AccesoDatos();
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Contacto { get; set; }
        public string RUC { get; set; }

        public  DataTable Leer()
        {
            return accesoDatos.EjecutarProcedimiento("LeerProveedores");
        }

        public  void Crear()
        {
            accesoDatos.EjecutarComando("CrearProveedor",
                new SqlParameter("@nombre", Nombre),
                new SqlParameter("@direccion", Direccion),
                new SqlParameter("@telefono", Telefono),
                new SqlParameter("@email", Email),
                new SqlParameter("@contacto", Contacto),
                new SqlParameter("@ruc", RUC));
        }

        public  void Actualizar()
        {
            accesoDatos.EjecutarComando("ActualizarProveedor",
                new SqlParameter("@idProveedor", IdProveedor),
                new SqlParameter("@nombre", Nombre),
                new SqlParameter("@direccion", Direccion),
                new SqlParameter("@telefono", Telefono),
                new SqlParameter("@email", Email),
                new SqlParameter("@contacto", Contacto),
                new SqlParameter("@ruc", RUC));
        }

        public  void Eliminar(int IdProveedor)
        {
            accesoDatos.EjecutarComando("EliminarProveedor",
                new SqlParameter("@idProveedor", IdProveedor));
        }

        public  DataTable BuscarPorId(int IdProveedor)
        {
            return accesoDatos.EjecutarProcedimiento("BuscarProveedorPorId",
                new SqlParameter("@IdProveedor", IdProveedor));
        }

        public DataTable BuscarPorCriterio(string criterio, string valor)
        {
            var accesoDatos = new AccesoDatos();
            var parametros = new[]
            {
            new SqlParameter("@Criterio", criterio),
            new SqlParameter("@Valor", valor)
        };

            return accesoDatos.EjecutarProcedimiento("BuscarProveedoresPorCriterio", parametros);
        }


        public DataTable VerficarDuplicado(string metodo)
        {
            var accesoDatos = new AccesoDatos();
            var parametros = new[]
            {
                 new SqlParameter("@id", IdProveedor),
                new SqlParameter("@nombre", Nombre),
                new SqlParameter("@telefono", Telefono),
                new SqlParameter("@email", Email),
                new SqlParameter("@ruc",RUC),
                 new SqlParameter("@metodo", metodo)
            };

            return accesoDatos.EjecutarProcedimiento("VerificarDuplicadosProvee", parametros);
        }
    }

}
