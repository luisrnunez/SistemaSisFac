using SistemaFacturacionWinform.Clases;
using SistemaFacturacionWinform.Diseño.Productos;
using System.Data;

namespace SistemaFacturacionWinform
{
    public partial class FormProductos : Form
    {


        Producto pr = new Producto();

        public FormProductos()
        {
            InitializeComponent();
        }
        string auxIdProducto;
        private void ListarProductos()
        {

            string criterio = cmbCriterio.SelectedItem.ToString();
            string valor = txtBusqueda.Text; // Asumiendo que hay un TextBox llamado txtBusqueda para el valor de búsqueda

            // Obtener los clientes según el criterio de búsqueda
            DataTable productos = null;
            if (!string.IsNullOrEmpty(valor))
            {
                productos = pr.BuscarPorCriterio(criterio, valor);
                if (productos.Rows.Count > 0)
                {

                    var productosFiltrados = productos;

                    // Cambiar el nombre de la columna idProducto a id
                    productosFiltrados.Columns["IdProducto"].ColumnName = "Id";

                    dgv_Productos.Columns.Clear();
                    dgv_Productos.DataSource = productosFiltrados;

                    // Crear la columna de Modificar
                    DataGridViewButtonColumn btnModificarColumn = new DataGridViewButtonColumn();

                    btnModificarColumn.Name = "btnModificar";
                    btnModificarColumn.HeaderText = "Modificar";
                    btnModificarColumn.Text = "Modificar";
                    btnModificarColumn.UseColumnTextForButtonValue = true; // Para que el texto aparezca en el botón
                    dgv_Productos.Columns.Add(btnModificarColumn);

                    // Crear la columna de Eliminar
                    DataGridViewButtonColumn btnEliminarColumn = new DataGridViewButtonColumn();

                    btnEliminarColumn.Name = "btnEliminar";
                    btnEliminarColumn.HeaderText = "Eliminar";
                    btnEliminarColumn.Text = "Eliminar";
                    btnEliminarColumn.UseColumnTextForButtonValue = true; // Para que el texto aparezca en el botón
                    dgv_Productos.Columns.Add(btnEliminarColumn);
                    dgv_Productos.Columns["Id"].Visible = false;
                    dgv_Productos.Columns["IdProveedor"].Visible = false;
                }
            }



        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text != string.Empty && txt_descripcion.Text != string.Empty && txt_precio.Text != string.Empty && txt_stock.Text != string.Empty && AuxIdProveedor != null)
            {

                pr.Nombre = txt_nombre.Text;
                pr.Descripcion = txt_descripcion.Text;
                pr.Precio = decimal.Parse(txt_precio.Text);
                pr.Stock = int.Parse(txt_stock.Text);
                pr.IdProveedor = int.Parse(AuxIdProveedor);
                DataTable dt = new DataTable();
                dt = pr.VerficarDuplicado("insert");
                int resultado = 0;
                if (dt.Rows.Count > 0)
                {
                    resultado = (int)dt.Rows[0].ItemArray[0];
                }
                if (resultado == 1)
                {
                    MessageBox.Show("Nombre duplicado, porfavor ingrese uno diferente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                pr.CrearProducto();

                MessageBox.Show("Producto fue creado correctamente", "Bien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCampos();

            }
            else
            {
                MessageBox.Show("Porfavor complete la informacion del producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void limpiarCampos()
        {
            txtProveedor.Text = txt_nombre.Text = txt_descripcion.Text = txt_precio.Text = txt_stock.Text = "";
             
        }

        private void dgv_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la celda clicada es un botón
            if (e.RowIndex >= 0 && (e.ColumnIndex == dgv_Productos.Columns["btnModificar"].Index || e.ColumnIndex == dgv_Productos.Columns["btnEliminar"].Index))
            {
                // Obtener el IdCliente de la fila seleccionada
                int idProducto = Convert.ToInt32(dgv_Productos.Rows[e.RowIndex].Cells["ID"].Value);
                auxIdProducto = idProducto.ToString();
                if (e.ColumnIndex == dgv_Productos.Columns["btnModificar"].Index)
                {

                    Producto pr = new Producto();
                    DataGridViewRow row = dgv_Productos.Rows[e.RowIndex];

                    pr.IdProducto = Convert.ToInt32(row.Cells["Id"].Value);
                    pr.Nombre = row.Cells["Nombre"].Value.ToString();
                    pr.Descripcion = row.Cells["Descripcion"].Value.ToString();
                    pr.Precio = Convert.ToDecimal(row.Cells["Precio"].Value.ToString());
                    pr.Stock = Convert.ToInt32(row.Cells["Stock"].Value.ToString());
                    pr.IdProveedor = Convert.ToInt32(row.Cells["IdProveedor"].Value);

                    // Código para modificar el cliente con el idCliente
                    FormModificarProducto obj = new FormModificarProducto(idProducto, pr);
                    obj.ShowDialog();
                }
                else if (e.ColumnIndex == dgv_Productos.Columns["btnEliminar"].Index)
                {
                    // Código para eliminar el cliente con el idCliente
                    if (auxIdProducto != null)
                    {
                        DialogResult ms = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                        if (DialogResult.Yes == ms)
                        {


                            try
                            {

                                pr.EliminarProducto(int.Parse(auxIdProducto));

                                auxIdProducto = null;
                                ListarProductos();
                                MessageBox.Show("Producto eliminado exitosamente.");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("No es posible eliminar este producto, hay facturas con este producto: ");
                            }
                        }

                    }
                    limpiarCampos();
                }
                ListarProductos();
            }
        }
        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, punto decimal, coma y tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Solo permitir un punto decimal o coma
            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                ((sender as TextBox).Text.IndexOf('.') > -1 || (sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }


        private void txt_stock_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = txt_descripcion.Text = txt_precio.Text = txt_stock.Text = "";
        }

        private void dgv_Productos_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la celda está dentro del rango de la tabla
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgv_Productos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray; // Color al pasar el cursor
            }
        }

        private void dgv_Productos_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la celda está dentro del rango de la tabla
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgv_Productos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White; // Color original
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarProductos();
        }

        string AuxIdProveedor;
        private void BtnAggProveedor_Click(object sender, EventArgs e)
        {
        
            try
            {
                FormAggProveedor obj = new FormAggProveedor();
                obj.ShowDialog();

                // Verifica si el usuario seleccionó un cliente o cerró el formulario sin elegir
                if (obj.prv != null && obj.prv.IdProveedor != null)
                {
                    txtProveedor.Text = obj.prv.Nombre;
                    AuxIdProveedor = obj.prv.IdProveedor.ToString();
                }
        
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }



    }
}
