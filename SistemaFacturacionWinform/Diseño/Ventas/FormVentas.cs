using SistemaFacturacionWinform.Clases;
using System.Data;

namespace SistemaFacturacionWinform
{
    public partial class FormVentas : Form
    {
        Producto pr = new Producto();
        Cliente cl = new Cliente();
        List<DetFactura> detallesFactura = new List<DetFactura>();
        int IdEmp;
        public FormVentas(int idEmp)
        {
            InitializeComponent();
            IdEmp = idEmp;
        }

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
                    productosFiltrados.Columns.RemoveAt(2);
                    dgv_Productos.Columns.Clear();
                    dgv_Productos.DataSource = productosFiltrados;
                    dgv_Productos.Columns["Id"].Visible = false;
                    dgv_Productos.Columns["IdProveedor"].Visible = false;
                }
            }



        }



        private void dgv_Productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtén la fila seleccionada como DataRowView
                DataGridViewRow row = dgv_Productos.Rows[e.RowIndex];
                DataRowView rowView = row.DataBoundItem as DataRowView;

                if (rowView != null)
                {
                    // Crea un objeto Producto basado en los datos de la fila seleccionada
                    var producto = new Producto
                    {
                        IdProducto = (int)rowView["id"],
                        Nombre = (string)rowView["Nombre"],
                        Precio = (decimal)rowView["Precio"],
                        Stock = (int)rowView["Stock"]
                    };

                    // Verificar si el producto ya está en la lista de detalles de la factura
                    var detalleExistente = detallesFactura.FirstOrDefault(d => d.IdProducto == producto.IdProducto);

                    int cantidadExistente = detalleExistente != null ? detalleExistente.Cantidad : 0;
                    int nuevaCantidad = cantidadExistente + 1; // Incrementar en 1 la cantidad deseada

                    if (nuevaCantidad > producto.Stock)
                    {
                        // Mostrar mensaje de error si la cantidad deseada excede el stock disponible
                        MessageBox.Show("No es posible agregar más de este producto. Stock insuficiente.", "Error de Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (detalleExistente != null)
                        {
                            // Incrementar la cantidad y recalcular el subtotal
                            detalleExistente.Cantidad++;
                            detalleExistente.Subtotal = detalleExistente.Cantidad * detalleExistente.PrecioUnitario;
                        }
                        else
                        {
                            // Agregar nuevo producto a la lista de detalles
                            detallesFactura.Add(new DetFactura
                            {
                                IdProducto = producto.IdProducto,
                                NProducto = producto.Nombre,
                                Cantidad = 1,
                                PrecioUnitario = producto.Precio,
                                Subtotal = producto.Precio
                            });
                        }
                    }

                    ActualizarDetalleVentaGrid();
                }
            }
        }


        private void dgv_Detalles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var detalle = detallesFactura[e.RowIndex];
                if (detalle.Cantidad > 1)
                {
                    // Decrementar la cantidad y recalcular el subtotal
                    detalle.Cantidad--;
                    detalle.Subtotal = detalle.Cantidad * detalle.PrecioUnitario;
                }
                else
                {
                    // Eliminar el producto de la lista de detalles
                    detallesFactura.RemoveAt(e.RowIndex);
                }

                ActualizarDetalleVentaGrid();
                actualizarCambio();
            }
        }


        private void ActualizarDetalleVentaGrid()
        {
            dgv_Detalles.DataSource = null;
            dgv_Detalles.DataSource = detallesFactura.Select(d => new
            {
         
                d.NProducto,
                d.Cantidad,
                d.PrecioUnitario,
                d.Subtotal
            }).ToList();
            double sum = 0;
            for (int i = 0; i < dgv_Detalles.Rows.Count; i++)
            {
                sum += double.Parse(dgv_Detalles.Rows[i].Cells[3].Value.ToString());

            }

            lb_totalapagar.Text = Math.Round(sum, 2).ToString();
        }


        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            if (detallesFactura.Count == 0 || Txt_agregarpago.Text == "" )
            {
                MessageBox.Show("Agregue productos o pago a la venta.", "Añade el cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (decimal.Parse(Txt_agregarpago.Text) < decimal.Parse(lb_totalapagar.Text))
            {
                return;
            }

            if (AuxIdCliente != 0)
            {
                DialogResult ms = MessageBox.Show("Desea finalizar la venta a consumidor final?", "Consumidor final", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (ms == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                return;
            }

            FormPrincipal obj;

            Factura factura = new Factura();
            factura.IdCliente = AuxIdCliente;
            factura.IdEmpleado = IdEmp;
            factura.Fecha = DateTime.Now;
            factura.Total = detallesFactura.Sum(d => d.Subtotal);
            factura.Pago = decimal.Parse(Txt_agregarpago.Text);
            factura.Cambio = decimal.Parse(lb_cambioadevolver.Text);

            DataTable fc = new DataTable();
            fc = factura.CrearFactura();


            DetFactura DetFac = new DetFactura();
            for (int i = 0; detallesFactura.Count > i; i++)
            {
                DetFac.IdFactura = (int)fc.Rows[0].ItemArray[0];
                DetFac.IdProducto = detallesFactura[i].IdProducto;
                DetFac.Cantidad = detallesFactura[i].Cantidad;
                DetFac.PrecioUnitario = detallesFactura[i].PrecioUnitario;
                DetFac.Subtotal = detallesFactura[i].Subtotal;
                DetFac.CrearDetFactura();
            }


            ImpFactura impFactura = new ImpFactura();
            var result = MessageBox.Show("¿Desea imprimir la factura?", "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                string impresora = "Microsoft XPS Document Writer";
                string rutaSeleccionada = "";
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.Description = "Seleccione la carpeta donde desea guardar el archivo.";
                    folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
                    folderBrowserDialog.ShowNewFolderButton = true;

                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Obtiene la ruta completa de la carpeta seleccionada
                        rutaSeleccionada = folderBrowserDialog.SelectedPath;
                    }
                }
                ImpFactura Ticket1 = new ImpFactura();

                Ticket1.GenerarFactura(factura, detallesFactura);
                if (rutaSeleccionada == null) { return; };
                Ticket1.ImprimirTiket(impresora, rutaSeleccionada + "\\Factura" + factura.IdFactura + factura.IdCliente + factura.Fecha.Day + ".txt");

            }

            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            detallesFactura.Clear();
            ActualizarDetalleVentaGrid();
            lb_cambioadevolver.Text = lb_totalapagar.Text = "--";
            Txt_agregarpago.Text = "";
            AuxIdCliente = 0;
            txtCliente.Text = string.Empty;
        }



        private void Txt_agregarpago_TextChanged(object sender, EventArgs e)
        {
            actualizarCambio();
        }

        public void actualizarCambio()
        {
            try
            {

                if (Txt_agregarpago.Text != string.Empty)
                {
                    decimal valorpago = decimal.Parse(Txt_agregarpago.Text);
                    decimal totalpago = decimal.Parse(lb_totalapagar.Text);
                    if (valorpago >= totalpago)
                    {
                        lb_cambioadevolver.Text = Math.Round((valorpago - totalpago), 2).ToString();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }


        }



        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult ms = MessageBox.Show("Estas seguro de cancelar la venta", "SEGURO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == ms)
            {
                LimpiarFormulario();
            }
        }
        int AuxIdCliente;
        private void BtnAggCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FormAggCliente obj = new FormAggCliente();
                obj.ShowDialog();

                // Verifica si el usuario seleccionó un cliente o cerró el formulario sin elegir
                if (obj.cl != null && obj.cl.IdPersona != null)
                {
                    txtCliente.Text = obj.cl.Nombre + " " + obj.cl.Apellido;
                    AuxIdCliente = obj.cl.IdPersona;
                }
                else
                {
                    // Maneja el caso donde no se seleccionó ningún cliente
                    txtCliente.Text = "No se seleccionó ningún cliente.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarProductos();
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
    }
}
