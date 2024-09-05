using SistemaFacturacionWinform.Clases;
using System.Data;

namespace SistemaFacturacionWinform.Diseño.Empleados
{
    public partial class FormEmpleado : Form
    {
        SistemaFacturacionWinform.Clases.Empleado emp = new SistemaFacturacionWinform.Clases.Empleado();


        public FormEmpleado()
        {
            InitializeComponent();
        }


        private void ListarEmpleados()
        {

            string criterio = cmbCriterio.SelectedItem.ToString();
            string valor = txtBusqueda.Text; // Asumiendo que hay un TextBox llamado txtBusqueda para el valor de búsqueda

            // Obtener los clientes según el criterio de búsqueda
            DataTable empleados = null;
            if (!string.IsNullOrEmpty(valor))
            {
                empleados = emp.BuscarPorCriterio(criterio, valor);
               

                if (empleados.Rows.Count > 0)
                {
                    var empleadosFiltrados = empleados;
                    empleadosFiltrados.Columns["IdPersona"].ColumnName = "Id";
                    dgv_Empleados.Columns.Clear();
                    dgv_Empleados.DataSource = empleadosFiltrados;

                    // Crear la columna de Modificar
                    DataGridViewButtonColumn btnModificarColumn = new DataGridViewButtonColumn();

                    btnModificarColumn.Name = "btnModificar";
                    btnModificarColumn.HeaderText = "Modificar";
                    btnModificarColumn.Text = "Modificar";
                    btnModificarColumn.UseColumnTextForButtonValue = true; // Para que el texto aparezca en el botón
                    dgv_Empleados.Columns.Add(btnModificarColumn);

                    // Crear la columna de Eliminar
                    DataGridViewButtonColumn btnEliminarColumn = new DataGridViewButtonColumn();

                    btnEliminarColumn.Name = "btnEliminar";
                    btnEliminarColumn.HeaderText = "Eliminar";
                    btnEliminarColumn.Text = "Eliminar";
                    btnEliminarColumn.UseColumnTextForButtonValue = true; // Para que el texto aparezca en el botón
                    dgv_Empleados.Columns.Add(btnEliminarColumn);
                    dgv_Empleados.Columns["Id"].Visible = false;
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
                if (txt_nombre.Text != string.Empty && txtApellido.Text != string.Empty && txtCedula.Text != string.Empty && txt_email.Text != string.Empty && txt_direccion.Text != string.Empty && txt_telefono.Text != string.Empty && txtClave.Text != string.Empty && txtUsuario.Text != string.Empty && txt_telefono.Text.Length == 10 && txtCedula.Text.Length == 10)
                {
                    emp.Nombre = txt_nombre.Text;
                    emp.Apellido = txtApellido.Text;
                    emp.Usuario = txtUsuario.Text;
                    emp.Clave = txtClave.Text;
                    emp.Cedula = txtCedula.Text;
                    emp.Direccion = txt_direccion.Text;
                    emp.Telefono = txt_telefono.Text;
                    emp.Email = txt_email.Text;
                    DataTable dt = new DataTable();
                    dt = emp.VerficarDuplicado("insert");
                    int resultado = 0;
                    if (dt.Rows.Count > 0)
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
                    else if (resultado == 4)
                    {
                        MessageBox.Show("Usuario duplicado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    emp.Crear();
                    limpiarCampos();
                    //ListarEmpleados();
                }
                else
                {
                    MessageBox.Show("Porfavor complete la informacion del empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }
       

        }



        int auxId = 0;
        private void dgv_Empleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la celda clicada es un botón
            if (e.RowIndex >= 0 && (e.ColumnIndex == dgv_Empleados.Columns["btnModificar"].Index || e.ColumnIndex == dgv_Empleados.Columns["btnEliminar"].Index))
            {
                // Obtener el IdCliente de la fila seleccionada
                auxId = Convert.ToInt32(dgv_Empleados.Rows[e.RowIndex].Cells["Id"].Value);

                if (e.ColumnIndex == dgv_Empleados.Columns["btnModificar"].Index)
                {

                    emp = new SistemaFacturacionWinform.Clases.Empleado();
                    DataGridViewRow row = dgv_Empleados.Rows[e.RowIndex];

                    emp.IdPersona = Convert.ToInt32(row.Cells["Id"].Value);
                    emp.Nombre = row.Cells["Nombre"].Value.ToString();
                    emp.Apellido = row.Cells["Apellido"].Value.ToString();
                    emp.Usuario = row.Cells["Usuario"].Value.ToString();
                    emp.Cedula = row.Cells["Cedula"].Value.ToString();
                    emp.Direccion = row.Cells["Direccion"].Value.ToString();
                    emp.Telefono = row.Cells["Telefono"].Value.ToString();
                    emp.Email = row.Cells["Email"].Value.ToString();

                    SistemaFacturacionWinform.Diseño.Empleado.FormModificarEmpleado obj = new SistemaFacturacionWinform.Diseño.Empleado.FormModificarEmpleado(auxId, emp);
                    obj.ShowDialog();
                }
                else if (e.ColumnIndex == dgv_Empleados.Columns["btnEliminar"].Index)
                {
                    // Código para eliminar el cliente con el idCliente
                    eliminarEmpleado();
                    limpiarCampos();
                }
                ListarEmpleados();
            }
        }


        private void dataGridViewEmpleado_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Empleados.SelectedRows.Count > 0)
            {
                var cliente = (Cliente)dgv_Empleados.SelectedRows[0].DataBoundItem;

                txt_nombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;

                txtClave.Text = cliente.Direccion;
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

        private void dgv_Empleados_MouseHover(object sender, EventArgs e)
        {

        }

        private void dgv_Empleados_MouseLeave(object sender, EventArgs e)
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
            txtCedula.Text = txt_email.Text = txt_direccion.Text = txt_telefono.Text = txt_nombre.Text = txtApellido.Text = txtUsuario.Text = txtClave.Text = txtUsuario.Text = "";

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


        private void eliminarEmpleado()
        {
            if (auxId != null)
            {
                DialogResult ms = MessageBox.Show("Esta seguro que desea eliminar a este cliente", "Estas seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == ms)
                {
                    try
                    {

                        emp.Eliminar(auxId);

                        ListarEmpleados();
                        MessageBox.Show("Cliente eliminado exitosamente.", "Estas seguro?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No es posible eliminar este cliente, hay facturas con este cliente: ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarEmpleados();
        }

        private void dgv_Empleados_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la celda está dentro del rango de la tabla
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgv_Empleados.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray; // Color al pasar el cursor
            }
        }

        private void dgv_Empleados_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la celda está dentro del rango de la tabla
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgv_Empleados.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White; // Color original
            }
        }
    }
}
