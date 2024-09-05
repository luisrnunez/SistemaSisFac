using SistemaFacturacionWinform.Clases;
using System.Data;

namespace SistemaFacturacionWinform.Diseño.Empleado
{
    public partial class FormModificarEmpleado : Form
    {
        public FormModificarEmpleado(int id, SistemaFacturacionWinform.Clases.Empleado empleado)
        {
            InitializeComponent();
            this.id = id;
            this.empleado = empleado;
            cargarEmpleado();
            this.MaximizeBox = false;

        }
        SistemaFacturacionWinform.Clases.Empleado emp = new SistemaFacturacionWinform.Clases.Empleado();
        SistemaFacturacionWinform.Clases.Empleado empleado;
        private int id;


        private void cargarEmpleado()
        {
            txt_nombre.Text = empleado.Nombre;
            txtApellido.Text = empleado.Apellido;
            txtUsuario.Text = empleado.Usuario;
            txt_clave.Text = empleado.Clave;
            txtCedula.Text = empleado.Cedula;
            txt_direccion.Text = empleado.Direccion;
            txt_telefono.Text = empleado.Telefono;
            txt_email.Text = empleado.Email;

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCedula.Text = txt_email.Text = txt_direccion.Text = txt_telefono.Text = txt_nombre.Text = txtApellido.Text = txtUsuario.Text = txt_clave.Text = "";

        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (id != null)
            {

                if (txt_nombre.Text != string.Empty && txtApellido.Text != string.Empty && txt_clave.Text != string.Empty && txtUsuario.Text != string.Empty && txt_telefono.Text.Length == 10 && txtCedula.Text.Length == 10)
                {

                    emp.IdPersona = id;
                    emp.Nombre = txt_nombre.Text;
                    emp.Apellido = txtApellido.Text;
                    emp.Usuario = txtUsuario.Text;
                    emp.Clave = txt_clave.Text;
                    emp.Cedula = txtCedula.Text;
                    emp.Direccion = txt_direccion.Text;
                    emp.Telefono = txt_telefono.Text;
                    emp.Email = txt_email.Text;
                    DataTable dt = new DataTable();
                    dt = emp.VerficarDuplicado("update");
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
                    emp.Actualizar();

                    MessageBox.Show("Cliente actualizado", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Porfavor complete la informacion del cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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

    }
}
