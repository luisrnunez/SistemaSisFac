using SistemaFacturacionWinform.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacionWinform.Diseño.Productos
{
    public partial class FormAggProveedor : Form
    {
        public FormAggProveedor()
        {
            InitializeComponent();
        }


        public SistemaFacturacionWinform.Clases.Proveedor prv { get; set; }

        private void ListarClientes()
        {
            string criterio = cmbCriterio.SelectedItem.ToString();
            string valor = txtBusqueda.Text; // Asumiendo que hay un TextBox llamado txtBusqueda para el valor de búsqueda

            // Obtener los clientes según el criterio de búsqueda
            DataTable proveedor = null;
            if (!string.IsNullOrEmpty(valor))
            {
                SistemaFacturacionWinform.Clases.Proveedor prve = new SistemaFacturacionWinform.Clases.Proveedor();
                proveedor = prve.BuscarPorCriterio(criterio, valor);
                if (proveedor.Rows.Count > 0)
                {
                    var clientesFiltrados = proveedor;

                    // Cambiar el nombre de la columna IdCliente a Id
                    clientesFiltrados.Columns["IdProveedor"].ColumnName = "Id";

                    // Asignar el DataSource al DataGridView
                    dgv_Clientes.Columns.Clear();
                    dgv_Clientes.DataSource = clientesFiltrados;
                    dgv_Clientes.Columns["Id"].Visible  = false;

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
                prv = new SistemaFacturacionWinform.Clases.Proveedor();
                // Asume que las columnas del DataGridView están en el orden correcto
                prv.IdProveedor = (int)row.Cells["Id"].Value;
                prv.Nombre = row.Cells["Nombre"].Value.ToString();
                prv.Contacto = row.Cells["Contacto"].Value.ToString();
                prv.RUC = row.Cells["RUC"].Value.ToString();
                prv.Direccion = row.Cells["Direccion"].Value.ToString();
                prv.Telefono = row.Cells["Telefono"].Value.ToString();
                prv.Email = row.Cells["Email"].Value.ToString();
                this.Close();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (prv != null)
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
