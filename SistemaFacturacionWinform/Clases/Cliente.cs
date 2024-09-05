using System.Data;
using System.Data.SqlClient;

namespace SistemaFacturacionWinform.Clases
{
    public class Cliente : Persona
    {
        public override DataTable Leer()
        {
            return accesoDatos.EjecutarProcedimiento("LeerClientes");
        }

        public override void Crear()
        {
            accesoDatos.EjecutarComando("CrearCliente",
                new SqlParameter("@nombre", Nombre),
                new SqlParameter("@apellido", Apellido),
                new SqlParameter("@cedula", Cedula),
                new SqlParameter("@direccion", Direccion),
                new SqlParameter("@telefono", Telefono),
                new SqlParameter("@correo", Email));
        }

        public override void Actualizar()
        {
            accesoDatos.EjecutarComando("ActualizarCliente",
                new SqlParameter("@idcliente", IdPersona),
                new SqlParameter("@nombre", Nombre),
                new SqlParameter("@apellido", Apellido),
                new SqlParameter("@cedula", Cedula),
                new SqlParameter("@direccion", Direccion),
                new SqlParameter("@telefono", Telefono),
                new SqlParameter("@correo", Email));
        }

        public override void Eliminar(int IdPersona)
        {
            accesoDatos.EjecutarComando("EliminarCliente",
                new SqlParameter("@idcliente", IdPersona));
        }

        public override DataTable BuscarPorId(int idPersona)
        {
            // Crear procedimiento almacenado específico para buscar por ID
            return accesoDatos.EjecutarProcedimiento("BuscarClientePorId",
                new SqlParameter("@idPersona", idPersona));
        }
        public DataTable BuscarPorCriterio(string criterio, string valor)
        {
            var accesoDatos = new AccesoDatos();
            var parametros = new[]
            {
                new SqlParameter("@Criterio", criterio),
                new SqlParameter("@Valor", valor)
            };

            return accesoDatos.EjecutarProcedimiento("BuscarClientesPorCriterio", parametros);
        }

        public DataTable VerficarDuplicado(string metodo)
        {
            var accesoDatos = new AccesoDatos();
            var parametros = new[]
            {
                new SqlParameter("@id", IdPersona),
                new SqlParameter("@cedula", Cedula),
                new SqlParameter("@telefono", Telefono),
                new SqlParameter("@correo", Email),
                new SqlParameter("@usuario", "cliente"),
                new SqlParameter("@metodo", metodo)
            };

            return accesoDatos.EjecutarProcedimiento("VerificarDuplicados", parametros);
        }

    }


}
