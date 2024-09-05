using SistemaFacturacionWinform.Clases;
using System.Data;

namespace SistemaFacturacionWinform.Reportes
{
    public partial class FormReporte : Form
    {
        public FormReporte()
        {
            InitializeComponent();
            cargarReporte();
        }

        private void cargarReporte()
        {
            //SistemaReportesFacturacion.Form1 obj = new SistemaReportesFacturacion.Form1();
            //obj.TopLevel = false;

            //pnlReporte.Controls.Add(obj);   
            //obj.Show();
        }
        Cliente cl = new Cliente();
        Factura frt = new Factura();
        private void ListarFacturas()
        {
            // Obtener listas de facturas y clientes
            var facturas = frt.LeerFacturas().AsEnumerable().Select(row =>
                new Factura
                {
                    IdFactura = row.Field<int>("IdFactura"),
                    IdCliente = row.Field<int>("IdCliente"),
                    Fecha = row.Field<DateTime>("Fecha"),
                    Total = row.Field<decimal>("Total"),
                    Pago = row.Field<decimal>("Pago"),
                    Cambio = row.Field<decimal>("Cambio")
                }).ToList();

            var clientes = cl.Leer().AsEnumerable().Select(row =>
                new Cliente
                {
                    IdPersona = row.Field<int>("IdCliente"),
                    Nombre = row.Field<string>("Nombre"),
                    Direccion = row.Field<string>("Direccion"),
                    Telefono = row.Field<string>("Telefono"),
                    Email = row.Field<string>("Email")
                }).ToList();

            // Realizar unión (join) de facturas con clientes
            var facturasConNombreCliente = facturas
                .Join(clientes,
                      factura => factura.IdCliente,
                      cliente => cliente.IdPersona,
                      (factura, cliente) => new
                      {
                          IdFactura = factura.IdFactura,
                          NombreCliente = cliente.Nombre,
                          Fecha = factura.Fecha,
                          Total = factura.Total,
                          Pago = factura.Pago,
                          Cambio = factura.Cambio,
                          IdCliente = factura.IdCliente // Incluir IdCliente para la columna no visible
                      })
                .ToList();

            // Ordenar las facturas por IdFactura de forma descendente
            var facturasOrdenadas = facturasConNombreCliente.OrderByDescending(f => f.IdFactura).ToList();

            // Asignar los datos al DataGridView
            //dgv_Facturas.DataSource = facturasOrdenadas;
        }


        private Factura facturaSeleccionada;

        private void dgv_Facturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                //DataGridViewRow row = dgv_Facturas.Rows[e.RowIndex];
                //int idFactura = (int)row.Cells["IdFactura"].Value;

                //// Extraer la información de la factura seleccionada
                //facturaSeleccionada = null;
                //facturaSeleccionada = new Factura
                //{
                //    IdFactura = idFactura,
                //    IdCliente = (int)row.Cells["IdCliente"].Value,
                //    Fecha = (DateTime)row.Cells["Fecha"].Value,
                //    Total = (decimal)row.Cells["Total"].Value,
                //    Pago = (decimal)row.Cells["pago"].Value,
                //    Cambio = (decimal)row.Cells["cambio"].Value
                //};

                //// Mostrar los detalles de la factura
                //MostrarDetallesFactura(idFactura, facturaSeleccionada);
            }
        }

        DetFactura fr = new DetFactura();
        private void MostrarDetallesFactura(int idFactura, Factura facturaSeleccionada)
        {
            // Leer los detalles de la factura desde la base de datos
            //List<DetFactura> detallesFactura = fr.LeerDetallesFactura(idFactura);

            // Generar la factura en el objeto Ticket1
            Ticket1 = new ImpFactura();
            // Ticket1.GenerarFactura(facturaSeleccionada, detallesFactura);

            //// Limpiar el RichTextBox antes de asignar el nuevo contenido
            //txtMostrarFactura.Clear();
            //txtMostrarFactura.Text = string.Empty;

            //// Verificar que el RichTextBox está vacío
            //if (txtMostrarFactura.Text.Length == 0)
            //{
            //    // Obtener el contenido de Ticket1 y asignarlo al RichTextBox
            //    txtMostrarFactura.Text = Ticket1.mostrarVista().ToString();
            //}
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
            Ticket1.ImprimirTiket(impresora, rutaSeleccionada + "\\Factura" + facturaSeleccionada.IdFactura + facturaSeleccionada.IdCliente + facturaSeleccionada.Fecha.Day + ".txt");
        }

    }
}
