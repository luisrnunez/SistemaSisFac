using SistemaFacturacionWinform.Clases;
using System.Data;

namespace SistemaFacturacionWinform.Diseño.Clientes
{
    public partial class FormModificarCliente : Form
    {
        public FormModificarCliente(int id, Cliente cliente)
        {
            InitializeComponent();
            this.id = id;
            this.cliente = cliente;
            cargarCliente();
            this.MaximizeBox = false;

        }
        Cliente cl = new Cliente();
        Cliente cliente;
        private int id;


        private void cargarCliente()
        {
            txt_nombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtCedula.Text = cliente.Cedula;
            txt_direccion.Text = cliente.Direccion;
            txt_telefono.Text = cliente.Telefono;
            txt_email.Text = cliente.Email;
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = txtApellido.Text = txtCedula.Text = txt_email.Text = txt_direccion.Text = txt_telefono.Text = "";
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (id != null)
            {

                if (txt_nombre.Text != string.Empty && txt_email.Text != string.Empty && txt_direccion.Text != string.Empty && txt_telefono.Text != string.Empty && txt_telefono.Text != string.Empty && txt_telefono.Text.Length == 10 && txtCedula.Text.Length == 10)
                {

                    cl.IdPersona = id;
                    cl.Nombre = txt_nombre.Text;
                    cl.Apellido = txtApellido.Text;
                    cl.Cedula = txtCedula.Text;
                    cl.Direccion = txt_direccion.Text;
                    cl.Telefono = txt_telefono.Text;
                    cl.Email = txt_email.Text;
                    DataTable dt = new DataTable();
                    dt = cl.VerficarDuplicado("update");
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

                    cl.Actualizar();

                    MessageBox.Show("Cliente actualizado", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
