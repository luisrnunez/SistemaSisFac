using SistemaFacturacionWinform.Clases;
using SistemaFacturacionWinform.Diseño.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacionWinform.Diseño.Proveedor
{
    public partial class FormProveedor : Form
    {
        public FormProveedor()
        {
            InitializeComponent();
        }

        SistemaFacturacionWinform.Clases.Proveedor prv = new SistemaFacturacionWinform.Clases.Proveedor();



        private void ListarClientes()
        {
            string criterio = cmbCriterio.SelectedItem.ToString();
            string valor = txtBusqueda.Text; // Asumiendo que hay un TextBox llamado txtBusqueda para el valor de búsqueda

            // Obtener los clientes según el criterio de búsqueda
            DataTable clientes = null;
            if (!string.IsNullOrEmpty(valor))
            {
                clientes = prv.BuscarPorCriterio(criterio, valor);
                if (clientes.Rows.Count > 0)
                {
                    var proveedoresFiltrados = clientes;

                    // Cambiar el nombre de la columna IdCliente a Id
                    proveedoresFiltrados.Columns["IdProveedor"].ColumnName = "Id";

                    // Asignar el DataSource al DataGridView
                    dgv_Clientes.Columns.Clear();
                    dgv_Clientes.DataSource = proveedoresFiltrados;

                    // Crear la columna de Modificar
                    DataGridViewButtonColumn btnModificarColumn = new DataGridViewButtonColumn();
                    btnModificarColumn.Name = "btnModificar";
                    btnModificarColumn.HeaderText = "Modificar";
                    btnModificarColumn.Text = "Modificar";
                    btnModificarColumn.UseColumnTextForButtonValue = true;
                    dgv_Clientes.Columns.Add(btnModificarColumn);

                    // Crear la columna de Eliminar
                    DataGridViewButtonColumn btnEliminarColumn = new DataGridViewButtonColumn();
                    btnEliminarColumn.Name = "btnEliminar";
                    btnEliminarColumn.HeaderText = "Eliminar";
                    btnEliminarColumn.Text = "Eliminar";
                    btnEliminarColumn.UseColumnTextForButtonValue = true;
                    dgv_Clientes.Columns.Add(btnEliminarColumn);
                    dgv_Clientes.Columns["Id"].Visible = false;
                }
                else
                {
                    MessageBox.Show("No se encontraron clientes con los criterios especificados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombre.Text != string.Empty && txtContacto.Text != string.Empty && txtRUC.Text != string.Empty && txt_email.Text != string.Empty && txt_direccion.Text != string.Empty && txt_telefono.Text != string.Empty && txt_telefono.Text.Length == 10 && txtRUC.Text.Length == 13)
                {
                    prv.Nombre = txt_nombre.Text;
                    prv.Contacto = txtContacto.Text;
                    prv.RUC = txtRUC.Text;
                    prv.Direccion = txt_direccion.Text;
                    prv.Telefono = txt_telefono.Text;
                    prv.Email = txt_email.Text;
                    DataTable dt = new DataTable();
                    dt = prv.VerficarDuplicado("insert");
                    int resultado = 0;
                    if (dt.Rows.Count > 0)
                    {
                        resultado = (int)dt.Rows[0].ItemArray[0];
                    }
                    if (resultado == 1)
                    {
                        MessageBox.Show("Nombre duplicada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (resultado == 2)
                    {
                        MessageBox.Show("Teléfono duplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (resultado == 3)
                    {
                        MessageBox.Show("Correo duplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (resultado == 4)
                    {
                        MessageBox.Show("RUC duplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    prv.Crear();
                    limpiarCampos();
                    //ListarClientes();
                }
                else
                {
                    MessageBox.Show("Porfavor complete la informacion del Proveedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }


        }



        string auxIdCliente = null;
        private void dgv_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la celda clicada es un botón
            if (e.RowIndex >= 0 && (e.ColumnIndex == dgv_Clientes.Columns["btnModificar"].Index || e.ColumnIndex == dgv_Clientes.Columns["btnEliminar"].Index))
            {
                // Obtener el IdCliente de la fila seleccionada
                int idCliente = Convert.ToInt32(dgv_Clientes.Rows[e.RowIndex].Cells["ID"].Value);

                if (e.ColumnIndex == dgv_Clientes.Columns["btnModificar"].Index)
                {

                    SistemaFacturacionWinform.Clases.Proveedor prv = new SistemaFacturacionWinform.Clases.Proveedor();
                    DataGridViewRow row = dgv_Clientes.Rows[e.RowIndex];

                    // Asignar los valores de las celdas de la fila a las propiedades del objeto Cliente
                    prv.IdProveedor = Convert.ToInt32(row.Cells["Id"].Value);
                    prv.Nombre = row.Cells["Nombre"].Value.ToString();
                    prv.Contacto = row.Cells["Contacto"].Value.ToString();
                    prv.RUC = row.Cells["RUC"].Value.ToString();
                    prv.Direccion = row.Cells["Direccion"].Value.ToString();
                    prv.Telefono = row.Cells["Telefono"].Value.ToString();
                    prv.Email = row.Cells["Email"].Value.ToString();

                    // Código para modificar el cliente con el idCliente
                    FormModificarProveedor obj = new FormModificarProveedor(idCliente, prv);
                    obj.ShowDialog();
                }
                else if (e.ColumnIndex == dgv_Clientes.Columns["btnEliminar"].Index)
                {
                    auxIdCliente = idCliente.ToString();
                    // Código para eliminar el cliente con el idCliente
                    eliminarCliente();
                    limpiarCampos();
                }
                ListarClientes();
            }
        }


        private void dataGridViewClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Clientes.SelectedRows.Count > 0)
            {
                var proveedor = (SistemaFacturacionWinform.Clases.Proveedor)dgv_Clientes.SelectedRows[0].DataBoundItem;
                txt_nombre.Text = proveedor.Nombre;
                txtContacto.Text = proveedor.Contacto;
                txtRUC.Text = proveedor.RUC;
                txt_direccion.Text = proveedor.Direccion;
                txt_telefono.Text = proveedor.Telefono;
                txt_email.Text = proveedor.Email;
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Cancela el evento si la tecla presionada no es válida
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_Clientes_MouseHover(object sender, EventArgs e)
        {

        }

        private void dgv_Clientes_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txt_nombre.Text = txtContacto.Text = txtRUC.Text = txt_email.Text = txt_direccion.Text = txt_telefono.Text = "";
        }



        private void eliminarCliente()
        {
            if (auxIdCliente != null)
            {
                DialogResult ms = MessageBox.Show("Esta seguro que desea eliminar a este Proveedor", "Estas seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == ms)
                {
                    try
                    {

                        prv.Eliminar(int.Parse(auxIdCliente));

                        ListarClientes();
                        MessageBox.Show("Proveedor eliminado exitosamente.", "Estas seguro?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        auxIdCliente = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No es posible eliminar este Proveedor, hay facturas con este Proveedor: ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarClientes();
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

        private void TextBox_OnlyNumbers_KeyPress(object sender, EventArgs e)
        {
     
        }
    }
}
