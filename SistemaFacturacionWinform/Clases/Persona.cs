using System.Data;
using System.Data.SqlClient;

namespace SistemaFacturacionWinform.Clases
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        protected AccesoDatos accesoDatos = new AccesoDatos();

        public virtual DataTable Leer()
        {
            throw new NotImplementedException();
        }

        public virtual void Crear()
        {
            throw new NotImplementedException();
        }

        public virtual void Actualizar()
        {
            throw new NotImplementedException();
        }

        public virtual void Eliminar(int idPersona)
        {
            throw new NotImplementedException();
        }

        public virtual DataTable BuscarPorId(int idPersona)
        {
            throw new NotImplementedException();
        }

        public virtual DataTable ValidarUsuario(string usuario, string clave)
        {
            throw new NotImplementedException();
        }
    }

}
