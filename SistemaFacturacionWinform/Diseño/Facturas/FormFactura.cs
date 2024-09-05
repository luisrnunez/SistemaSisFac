using SistemaFacturacionWinform.Clases;
using System.Data;

namespace SistemaFacturacionWinform
{
    public partial class FormFactura : Form
    {
        public FormFactura()
        {
            InitializeComponent();
            //dtpFecha.Format = DateTimePickerFormat.Short; // Solo fecha
            //dtpFecha.Value = DateTime.Now; // Fecha actual por defecto, o usa DateTime.MinValue si prefieres que esté vacío
            //dtpFecha.Checked = false; // Inicialmente no seleccionado

        }

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            ListarFacturas();
        }

        Cliente cl = new Cliente();
        Factura frt = new Factura();
        Empleado em = new Empleado();
        private void ListarFacturas()
        {
            string criterio = cmbCriterio.SelectedItem?.ToString(); // Asegúrate de que el criterio no sea nulo
            string valor = txtBusqueda.Text; // Asumiendo que hay un TextBox llamado txtBusqueda para el valor de búsqueda
          //  DateTime? fechaSeleccionada = dtpFecha.Checked ? dtpFecha.Value.Date : (DateTime?)null;
           // DateTime fechaCorta = DateTime.Parse(fechaSeleccionada?.ToString("MM/dd/yyyy"));
            // Asegurarse de que se haya seleccionado un criterio y que haya un valor de búsqueda
            if (string.IsNullOrEmpty(criterio) /*&& !fechaSeleccionada.HasValue*/)
            {
                MessageBox.Show("Por favor, seleccione un criterio de búsqueda o una fecha.");
                return;
            }

            // Convertir el valor de búsqueda a minúsculas para hacer la comparación insensible a mayúsculas
            valor = valor?.ToLower();

            // Obtener listas de facturas, clientes y empleados
            var facturas = frt.LeerFacturas().AsEnumerable().Select(row =>
                new Factura
                {
                    IdFactura = row.Field<int>("IdFactura"),
                    IdCliente = row.Field<int>("IdCliente"),
                    IdEmpleado = row.Field<int>("IdEmpleado"),
                    Fecha = row.Field<DateTime>("Fecha"),
                    Total = row.Field<decimal>("Total"),
                    Pago = row.Field<decimal>("Pago"),
                    Cambio = row.Field<decimal>("Cambio")
                }).ToList();

            var clientes = cl.Leer().AsEnumerable().Select(row =>
                new Persona
                {
                    IdPersona = row.Field<int>("IdCliente"),
                    Nombre = (row.Field<string>("Nombre") + " " + row.Field<string>("Apellido")).ToLower()
                }).ToList();

            var empleados = em.Leer().AsEnumerable().Select(row =>
                new Persona
                {
                    IdPersona = row.Field<int>("IdEmpleado"),
                    Nombre = (row.Field<string>("Nombre") + " " + row.Field<string>("Apellido")).ToLower()
                }).ToList();

            // Realizar unión (join) de facturas con clientes y empleados
            var facturasConDetalles = from factura in facturas
                                      join cliente in clientes on factura.IdCliente equals cliente.IdPersona
                                      join empleado in empleados on factura.IdEmpleado equals empleado.IdPersona
                                      select new
                                      {
                                          IdFactura = factura.IdFactura,
                                          NombreCliente = cliente.Nombre,
                                          NombreEmpleado = empleado.Nombre,
                                          Fecha = factura.Fecha,
                                          Total = factura.Total,
                                          Pago = factura.Pago,
                                          Cambio = factura.Cambio
                                      };

            // Filtrar y ordenar las facturas según el criterio seleccionado
            IEnumerable<dynamic> facturasFiltradas = null; // Usa IEnumerable<dynamic> para tipos anónimos
            try
            {
                if (criterio == "Nombre Cliente")
                {
                    facturasFiltradas = facturasConDetalles
                        .Where(f => f.NombreCliente.Contains(valor))
                        .OrderByDescending(f => f.IdFactura);
                }
                else if (criterio == "Nombre Empleado")
                {
                    facturasFiltradas = facturasConDetalles
                        .Where(f => f.NombreEmpleado.Contains(valor))
                        .OrderByDescending(f => f.IdFactura);
                }
                //else if (criterio == "Fecha")
                //{
                //    if (fechaSeleccionada.HasValue)
                //    {
                //        facturasFiltradas = facturasConDetalles
                //            .Where(f => f.Fecha.Date == fechaCorta.Date);
                //    }
                //    else
                //    {
                //        MessageBox.Show("Por favor, seleccione una fecha.");
                //        return;
                //    }
                //}
            }
            catch (Exception e)
            {
                MessageBox.Show("Por favor, seleccione una fecha.");
                MessageBox.Show(e.Message);
                throw;
            }
        

            // Convertir a lista y asignar los datos al DataGridView
            dgv_Facturas.DataSource = facturasFiltradas?.ToList();

            // Configurar encabezados de columnas, si es necesario
            if (dgv_Facturas.Columns.Contains("IdFactura"))
            {
                dgv_Facturas.Columns["IdFactura"].HeaderText = "Id";
            }
        }


        private Factura facturaSeleccionada;

        private void dgv_Facturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Facturas.Rows[e.RowIndex];
                int idFactura = (int)row.Cells["IdFactura"].Value;

                MostrarDetallesFactura(idFactura);
            }
        }



        DetFactura fr = new DetFactura();
        Factura frc;
        private void MostrarDetallesFactura(int idFactura)
        {
            Factura fac = new Factura();
            var LisFac = fac.LeerFacturas();

            for (int i = 0; i < LisFac.Rows.Count; i++)
            {
                if ((int)LisFac.Rows[i]["IdFactura"] == idFactura)
                {


                    Factura facturaSeleccionada = ConvertirDataRowAFactura(LisFac.Rows[i]);
                    frc = facturaSeleccionada;
                    List<DetFactura> detallesFactura = ConvertirDataTableALista(fr.LeerDetallesFactura(idFactura));

                    // Leer los detalles de la factura desde la base de datos

                    // Generar la factura en el objeto Ticket1
                    Ticket1 = new ImpFactura();

                    Ticket1.GenerarFactura(facturaSeleccionada, detallesFactura);

                    txtMostrarFactura.Text = Ticket1.mostrarVista().ToString();

                }
            }
        }

        public List<DetFactura> ConvertirDataTableALista(DataTable dataTable)
        {
            var detallesFactura = new List<DetFactura>();

            foreach (DataRow row in dataTable.Rows)
            {
                var detalleFactura = new DetFactura
                {
                    IdDetalle = Convert.ToInt32(row["IdDetalle"]),
                    IdFactura = Convert.ToInt32(row["IdFactura"]),
                    IdProducto = Convert.ToInt32(row["IdProducto"]),
                    Cantidad = Convert.ToInt32(row["Cantidad"]),
                    PrecioUnitario = Convert.ToDecimal(row["PrecioUnitario"]),
                    Subtotal = Convert.ToDecimal(row["Subtotal"])
                };

                detallesFactura.Add(detalleFactura);
            }

            return detallesFactura;
        }

        private Factura ConvertirDataRowAFactura(DataRow row)
        {
            return new Factura
            {
                IdFactura = row.Field<int>("IdFactura"),
                IdCliente = row.Field<int>("IdCliente"),
                IdEmpleado = row.Field<int>("IdEmpleado"),
                Fecha = row.Field<DateTime>("Fecha"),
                Total = row.Field<decimal>("Total"),
                Pago = row.Field<decimal>("Pago"),
                Cambio = row.Field<decimal>("Cambio")
            };
        }

        ImpFactura Ticket1;
        private void btnImprimir_Click(object sender, EventArgs e)
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

            if (rutaSeleccionada == null) { return; };
            Ticket1.ImprimirTiket(impresora, rutaSeleccionada + "\\Factura" + frc.IdFactura + frc.IdCliente + frc.Fecha.Day + ".txt");
        }




        private void dgv_Facturas_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la celda está dentro del rango de la tabla
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgv_Facturas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray; // Color al pasar el cursor
            }
        }

        private void dgv_Facturas_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la celda está dentro del rango de la tabla
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgv_Facturas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White; // Color original
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarFacturas();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            ListarFacturas();
        }
    }
}
