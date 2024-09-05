


using SistemaFacturacionWinform.Diseño.Clientes;
using SistemaFacturacionWinform.Diseño.Empleados;
using SistemaFacturacionWinform.Diseño.Proveedor;
using SistemaFacturacionWinform.Reportes;
using System.Data;

namespace SistemaFacturacionWinform
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal(DataTable user, string rol)
        {
            InitializeComponent();
            IdEmp = (int)user.Rows[0].ItemArray[0];
            if (rol == "emp")
            {
                btnEmpleados.Visible = false;
                lbRol.Text = "Empleado";
            }
            else
            {
                btnVenta.Visible = false;
                lbRol.Text = "Administrador";
            }
            lbNombreRol.Text = user.Rows[0].ItemArray[1].ToString() + " " + user.Rows[0].ItemArray[2].ToString();


        }

        int IdEmp = 0;

        private void btnVenta_Click(object sender, EventArgs e)
        {
            FormVentas objVenta = new FormVentas(IdEmp);
            objVenta.TopLevel = false;
            pnlPrincipal.Controls.Add(objVenta);
            objVenta.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes objCliente = new FormClientes();
            objCliente.TopLevel = false;
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(objCliente);
            objCliente.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProductos objProductos = new FormProductos();
            objProductos.TopLevel = false;
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(objProductos);
            objProductos.Show();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            FormFactura objFactura = new FormFactura();
            objFactura.TopLevel = false;
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(objFactura);
            objFactura.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleado objEmpleado = new FormEmpleado();
            objEmpleado.TopLevel = false;
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(objEmpleado);
            objEmpleado.Show();
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm obj = new LoginForm();
            obj.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReporte objReportes = new FormReporte();
            objReportes.TopLevel = false;
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(objReportes);
            objReportes.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            FormProveedor objProveedor = new FormProveedor();
            objProveedor.TopLevel = false;
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(objProveedor);
            objProveedor.Show();
        }
    }
}
