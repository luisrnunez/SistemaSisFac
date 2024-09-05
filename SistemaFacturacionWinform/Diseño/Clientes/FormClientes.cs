using SistemaFacturacionWinform.Clases;
using System.Data;

namespace SistemaFacturacionWinform.Diseño.Clientes
{
    public partial class FormClientes : Form
    {
        Cliente cl = new Cliente();


        public FormClientes()
        {
            InitializeComponent();
        }

        private void ListarClientes()
        {
            string criterio = cmbCriterio.SelectedItem.ToString();
            string valor = txtBusqueda.Text; // Asumiendo que hay un TextBox llamado txtBusqueda para el valor de búsqueda

            // Obtener los clientes según el criterio de búsqueda
            DataTable clientes = null;
            if (!string.IsNullOrEmpty(valor))
            {
                clientes = cl.BuscarPorCriterio(criterio, valor);
                if (clientes.Rows.Count > 0)
                {
                    var clientesFiltrados = clientes;
                   
                    // Cambiar el nombre de la columna IdCliente a Id
                    clientesFiltrados.Columns["IdPersona"].ColumnName = "Id";

                    // Asignar el DataSource al DataGridView
                    dgv_Clientes.Columns.Clear();
                    dgv_Clientes.DataSource = clientesFiltrados;

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
                if (txt_nombre.Text != string.Empty && txtApellido.Text != string.Empty && txtCedula.Text != string.Empty && txt_email.Text != string.Empty && txt_direccion.Text != string.Empty && txt_telefono.Text != string.Empty && txt_telefono.Text.Length == 10 && txtCedula.Text.Length ==10)
                {
                    cl.Nombre = txt_nombre.Text;
                    cl.Apellido = txtApellido.Text;
                    cl.Cedula = txtCedula.Text;
                    cl.Direccion = txt_direccion.Text;
                    cl.Telefono = txt_telefono.Text;
                    cl.Email = txt_email.Text;
                    DataTable dt = new DataTable(); 
                    dt = cl.VerficarDuplicado("insert");
                    int resultado = 0;
                    if (dt.Rows.Count >0)
                    {
                        resultado = (int)dt.Rows[0].ItemArray[0];
                    }
                    if (resultado == 1)
                    {
                        MessageBox.Show("Cédula duplicada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
       
                    cl.Crear();
                    limpiarCampos();
                    MessageBox.Show("Cliente agregado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Porfavor complete la informacion del cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    Cliente cl = new Cliente();
                    DataGridViewRow row = dgv_Clientes.Rows[e.RowIndex];

                    // Asignar los valores de las celdas de la fila a las propiedades del objeto Cliente
                    cl.IdPersona = Convert.ToInt32(row.Cells["Id"].Value);
                    cl.Nombre = row.Cells["Nombre"].Value.ToString();
                    cl.Apellido = row.Cells["Apellido"].Value.ToString();
                    cl.Cedula = row.Cells["Cedula"].Value.ToString();
                    cl.Direccion = row.Cells["Direccion"].Value.ToString();
                    cl.Telefono = row.Cells["Telefono"].Value.ToString();
                    cl.Email = row.Cells["Email"].Value.ToString();

                    // Código para modificar el cliente con el idCliente
                    FormModificarCliente obj = new FormModificarCliente(idCliente, cl);
                    obj.ShowDialog();
                }
                else if (e.ColumnIndex == dgv_Clientes.Columns["btnEliminar"].Index)
                {
                    auxIdCliente = idCliente.ToString();
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
                var cliente = (Cliente)dgv_Clientes.SelectedRows[0].DataBoundItem;
                txt_nombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtCedula.Text = cliente.Cedula;
                txt_direccion.Text = cliente.Direccion;
                txt_telefono.Text = cliente.Telefono;
                txt_email.Text = cliente.Email;
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
            txt_nombre.Text = txtApellido.Text = txtCedula.Text = txt_email.Text = txt_direccion.Text = txt_telefono.Text = "";
        }

        private void TextBox_OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un número o tecla de control (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Cancela el evento si la tecla presionada no es válida
                e.Handled = true;
            }
        }


        private void eliminarCliente()
        {
            if (auxIdCliente != null)
            {
                DialogResult ms = MessageBox.Show("Esta seguro que desea eliminar a este cliente", "Estas seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == ms)
                {
                    try
                    {

                        cl.Eliminar(int.Parse(auxIdCliente));

                        ListarClientes();
                        MessageBox.Show("Cliente eliminado exitosamente.", "Estas seguro?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        auxIdCliente = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No es posible eliminar este cliente, hay facturas con este cliente: ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}
