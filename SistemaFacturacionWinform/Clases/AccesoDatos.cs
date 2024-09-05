using System.Data;
using System.Data.SqlClient;

public class AccesoDatos
{
    private string Servidor;
    private string BaseDatos;
    private string Usuario;
    private string Clave;

    private SqlConnection Conexion;

    public AccesoDatos()
    {
        this.Servidor = "DESKTOP-NKJDBV1\\SQLEXPRESS";
        this.BaseDatos = "SisFac";
        this.Usuario = "sa";
        this.Clave = "1234";
    }

    public bool AbrirConexion()
    {
        try
        {
            this.Conexion = new SqlConnection();
            this.Conexion.ConnectionString = $"Server={Servidor};Database={BaseDatos};User id={Usuario};Password={Clave}";
            this.Conexion.Open();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }
    }

    public bool CerrarConexion()
    {
        try
        {
            this.Conexion.Close();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }
    }

    public DataTable EjecutarProcedimiento(string procedimiento, params SqlParameter[] parametros)
    {
        DataTable tabla = new DataTable();
        if (AbrirConexion())
        {
            try
            {
                using (var comando = new SqlCommand(procedimiento, Conexion) { CommandType = CommandType.StoredProcedure })
                {
                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                    }
                    using (var adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }
        return tabla;
    }

    public void EjecutarComando(string procedimiento, params SqlParameter[] parametros)
    {
        if (AbrirConexion())
        {
            try
            {
                using (var comando = new SqlCommand(procedimiento, Conexion) { CommandType = CommandType.StoredProcedure })
                {
                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                    }
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }
    }
}
