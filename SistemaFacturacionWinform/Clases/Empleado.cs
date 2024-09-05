using System.Data;
using System.Data.SqlClient;

namespace SistemaFacturacionWinform.Clases
{
    public class Empleado : Persona
    {
        public string Usuario { get; set; }
        public string Clave { get; set; }

        public override DataTable Leer()
        {
            return accesoDatos.EjecutarProcedimiento("LeerEmpleados");
        }

        public override void Crear()
        {
            accesoDatos.EjecutarComando("CrearEmpleado",
                new SqlParameter("@nombre", Nombre),
                new SqlParameter("@apellido", Apellido),
                new SqlParameter("@cedula", Cedula),
                new SqlParameter("@direccion", Direccion),
                new SqlParameter("@telefono", Telefono),
                new SqlParameter("@correo", Email),
                new SqlParameter("@usuario", Usuario),
                new SqlParameter("@clave", Clave));
        }

        public override void Actualizar()
        {
            accesoDatos.EjecutarComando("ActualizarEmpleado",
                new SqlParameter("@idempleado", IdPersona),
                new SqlParameter("@nombre", Nombre),
                new SqlParameter("@apellido", Apellido),
                new SqlParameter("@cedula", Cedula),
                new SqlParameter("@direccion", Direccion),
                new SqlParameter("@telefono", Telefono),
                new SqlParameter("@correo", Email),
                new SqlParameter("@usuario", Usuario),
                new SqlParameter("@clave", Clave));
        }

        public override void Eliminar(int idPersona)
        {
            accesoDatos.EjecutarComando("EliminarEmpleado",
                new SqlParameter("@idempleado", IdPersona));
        }

        public override DataTable BuscarPorId(int idPersona)
        {
            // Crear procedimiento almacenado específico para buscar por ID
            return accesoDatos.EjecutarProcedimiento("BuscarEmpleadoPorId",
                new SqlParameter("@idPersona", idPersona));
        }

        public override DataTable ValidarUsuario(string usuario, string clave)
        {
            var accesoDatos = new AccesoDatos();
            var parametros = new[]
            {
            new SqlParameter("@Usuario", usuario),
            new SqlParameter("@Clave", clave)
        };

            return accesoDatos.EjecutarProcedimiento("ValidarUsuarioEmp", parametros);
        }


        public DataTable BuscarPorCriterio(string criterio, string valor)
        {
            var accesoDatos = new AccesoDatos();
            var parametros = new[]
            {
                new SqlParameter("@Criterio", criterio),
                new SqlParameter("@Valor", valor)
            };

            return accesoDatos.EjecutarProcedimiento("BuscarEmpleadosPorCriterio", parametros);
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
                new SqlParameter("@usuario", Usuario),
                new SqlParameter("@metodo", metodo)
            };

            return accesoDatos.EjecutarProcedimiento("VerificarDuplicados", parametros);
        }
    }


}
