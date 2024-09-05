using SistemaFacturacionWinform.Clases;
using System.Data;

namespace SistemaFacturacionWinform
{
    public partial class FormAggCliente : Form
    {
        public FormAggCliente()
        {
            InitializeComponent();
        }




        public Cliente cl { get; set; }

        private void ListarClientes()
        {
            string criterio = cmbCriterio.SelectedItem.ToString();
            string valor = txtBusqueda.Text; // Asumiendo que hay un TextBox llamado txtBusqueda para el valor de búsqueda

            // Obtener los clientes según el criterio de búsqueda
            DataTable clientes = null;
            if (!string.IsNullOrEmpty(valor))
            {
                Cliente cli = new Cliente();
                clientes = cli.BuscarPorCriterio(criterio, valor);
                if (clientes.Rows.Count > 0)
                {
                    var clientesFiltrados = clientes;

                    // Cambiar el nombre de la columna IdCliente a Id
                    clientesFiltrados.Columns["IdPersona"].ColumnName = "Id";

                    // Asignar el DataSource al DataGridView
                    dgv_Clientes.Columns.Clear();
                    dgv_Clientes.DataSource = clientesFiltrados;

                }
                else
                {
                    MessageBox.Show("No se encontraron clientes con los criterios especificados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgv_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Clientes.Rows[e.RowIndex];
                cl = new Cliente();
                // Asume que las columnas del DataGridView están en el orden correcto
                cl.IdPersona = (int)row.Cells["Id"].Value;
                cl.Nombre = row.Cells["Nombre"].Value.ToString();
                cl.Apellido = row.Cells["Apellido"].Value.ToString();
                cl.Cedula = row.Cells["Cedula"].Value.ToString();
                cl.Direccion = row.Cells["Direccion"].Value.ToString();
                cl.Telefono = row.Cells["Telefono"].Value.ToString();
                cl.Email = row.Cells["Email"].Value.ToString();
                this.Close();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (cl != null)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor selecciona un cliente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        
        
        private void dgv_Clientes_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la celda está dentro del rango de la tabla
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgv_Clientes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray; // Color al pasar el cursor
            }
        }

        private void dgv_Clientes_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la celda está dentro del rango de la tabla
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgv_Clientes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White; // Color original
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarClientes();
        }
    }
}
