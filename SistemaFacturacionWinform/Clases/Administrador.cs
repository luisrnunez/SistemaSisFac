using System.Data;
using System.Data.SqlClient;

namespace SistemaFacturacionWinform.Clases
{
    public class Administrador : Persona
    {
        public string Usuario { get; set; }
        public string Clave { get; set; }

        public override DataTable Leer()
        {
            return accesoDatos.EjecutarProcedimiento("LeerAdministradores");
        }

        public override void Crear()
        {
            accesoDatos.EjecutarComando("CrearAdministrador",
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
            accesoDatos.EjecutarComando("ActualizarAdministrador",
                new SqlParameter("@idadministrador", IdPersona),
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
            accesoDatos.EjecutarComando("EliminarAdministrador",
                new SqlParameter("@idadministrador", IdPersona));
        }

        public override DataTable BuscarPorId(int idPersona)
        {
            // Crear procedimiento almacenado específico para buscar por ID
            return accesoDatos.EjecutarProcedimiento("BuscarAdministradorPorId",
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

            return accesoDatos.EjecutarProcedimiento("ValidarUsuarioAdmi", parametros);
        }


    }

}
