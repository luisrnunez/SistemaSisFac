using SistemaFacturacionWinform.Clases;
using System.Data;

namespace SistemaFacturacionWinform.Diseño.Productos
{
    public partial class FormModificarProducto : Form
    {
        public FormModificarProducto(int id, Producto productop)
        {
            InitializeComponent();
            this.id = id;
            this.producto = productop;
            cargarCliente();
            this.MaximizeBox = false;

        }
        Producto pr = new Producto();
        Producto producto;
        private int id;


        private void cargarCliente()
        {
            txt_nombre.Text = producto.Nombre;
            txtDescripcion.Text = producto.Descripcion;
            txtStock.Text = producto.Stock.ToString();
            txtPrecio.Text = producto.Precio.ToString();
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = txtDescripcion.Text = txtPrecio.Text = txtStock.Text = "";
        }


        private void txt_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Cancela el evento si la tecla presionada no es válida
                e.Handled = true;
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (id != null)
            {

                if (txt_nombre.Text != string.Empty && txtDescripcion.Text != string.Empty && txtPrecio.Text != string.Empty && txtStock.Text != string.Empty)
                {

                    pr.IdProducto = id;
                    pr.Nombre = txt_nombre.Text;
                    pr.Descripcion = txtDescripcion.Text;
                    pr.Stock = Convert.ToInt32(txtStock.Text);
                    pr.Precio = Convert.ToDecimal(txtPrecio.Text);
                    pr.IdProveedor = producto.IdProveedor;
                    DataTable dt = new DataTable();
                    dt = pr.VerficarDuplicado("update");
                    int resultado = 0;
                    if (dt.Rows.Count > 0)
                    {
                        resultado = (int)dt.Rows[0].ItemArray[0];
                    }
                    if (resultado == 1)
                    {
                        MessageBox.Show("Nombre duplicado, por favor ingrese uno diferente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    pr.ActualizarProducto();
                    MessageBox.Show("Producto actualizado", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Porfavor complete la informacion del cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}
