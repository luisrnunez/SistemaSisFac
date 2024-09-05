using SistemaFacturacionWinform.Clases;
using System.Data;

namespace SistemaFacturacionWinform
{
    public partial class LoginForm : Form
    {
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Button btnLogin;

        public LoginForm()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            var usuario = txtUsuario.Text;
            var clave = txtClave.Text;
            Empleado empleado = new Empleado();
            Administrador administrador = new Administrador();

            DataTable tablaEmpleado = empleado.ValidarUsuario(usuario, clave);
            DataTable tablaAdministrador = administrador.ValidarUsuario(usuario, clave);

            if (tablaEmpleado.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + tablaEmpleado.Rows[0]["Nombre"].ToString(), "Ingreso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FormPrincipal obj = new FormPrincipal(tablaEmpleado, "emp");
                obj.Show();
            }
            else if (tablaAdministrador.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + tablaAdministrador.Rows[0]["Nombre"].ToString(), "Ingreso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FormPrincipal obj = new FormPrincipal(tablaAdministrador, "admi");
                obj.Show();
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrectos.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
