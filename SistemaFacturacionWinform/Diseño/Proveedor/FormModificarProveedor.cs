using SistemaFacturacionWinform.Clases;
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
    public partial class FormModificarProveedor : Form
    {
        public FormModificarProveedor(int id, SistemaFacturacionWinform.Clases.Proveedor proveedor)
        {
            InitializeComponent();
            this.id = id;
            this.proveedor = proveedor;
            cargarCliente();
            this.MaximizeBox = false;

        }
        SistemaFacturacionWinform.Clases.Proveedor prv = new SistemaFacturacionWinform.Clases.Proveedor();
        SistemaFacturacionWinform.Clases.Proveedor proveedor;
        private int id;


        private void cargarCliente()
        {
            txt_nombre.Text = proveedor.Nombre;
            txtContacto.Text = proveedor.Contacto;
            txtRUC.Text = proveedor.RUC;
            txt_direccion.Text = proveedor.Direccion;
            txt_telefono.Text = proveedor.Telefono;
            txt_email.Text = proveedor.Email;
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = txtContacto.Text = txtRUC.Text = txt_email.Text = txt_direccion.Text = txt_telefono.Text = "";
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (id != null)
            {

                if (txt_nombre.Text != string.Empty && txt_email.Text != string.Empty && txt_direccion.Text != string.Empty && txt_telefono.Text != string.Empty && txt_telefono.Text.Length == 10 && txtRUC.Text.Length == 13)
                {

                    prv.IdProveedor = id;
                    prv.Nombre = txt_nombre.Text;
                    prv.Contacto = txtContacto.Text;
                    prv.RUC = txtRUC.Text;
                    prv.Direccion = txt_direccion.Text;
                    prv.Telefono = txt_telefono.Text;
                    prv.Email = txt_email.Text;
                    DataTable dt = new DataTable();
                    dt = prv.VerficarDuplicado("update");
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
                    prv.Actualizar();

                    MessageBox.Show("Proveedor actualizado", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Porfavor complete la informacion del Proveedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
