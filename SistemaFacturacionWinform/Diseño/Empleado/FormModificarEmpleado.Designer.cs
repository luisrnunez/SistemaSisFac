using SistemaFacturacionWinform.Diseño.Clientes;

namespace SistemaFacturacionWinform.Diseño.Empleado
{
    partial class FormModificarEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtApellido = new TextBox();
            label2 = new Label();
            txt_nombre = new TextBox();
            label8 = new Label();
            btnLimpiar = new Button();
            btnAgregarCliente = new Button();
            txtCedula = new TextBox();
            label3 = new Label();
            txt_telefono = new TextBox();
            label4 = new Label();
            txt_email = new TextBox();
            label5 = new Label();
            txt_direccion = new TextBox();
            label6 = new Label();
            txtUsuario = new TextBox();
            label1 = new Label();
            txt_clave = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(104, 41);
            txtApellido.MaxLength = 100;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(256, 23);
            txtApellido.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 41);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 68;
            label2.Text = "Apellido:";
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_nombre.Location = new Point(104, 12);
            txt_nombre.MaxLength = 100;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(256, 23);
            txt_nombre.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(24, 12);
            label8.Name = "label8";
            label8.Size = new Size(62, 17);
            label8.TabIndex = 59;
            label8.Text = "Nombre:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(128, 255, 255);
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.Location = new Point(280, 290);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(80, 23);
            btnLimpiar.TabIndex = 71;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.BackColor = Color.FromArgb(255, 152, 0);
            btnAgregarCliente.FlatStyle = FlatStyle.Popup;
            btnAgregarCliente.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            btnAgregarCliente.ForeColor = Color.White;
            btnAgregarCliente.Location = new Point(121, 268);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(120, 64);
            btnAgregarCliente.TabIndex = 70;
            btnAgregarCliente.Text = "Guardar";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnModificar_Click;
            // 
            // txtCedula
            // 
            txtCedula.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCedula.Location = new Point(104, 70);
            txtCedula.MaxLength = 10;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(256, 23);
            txtCedula.TabIndex = 3;
            txtCedula.KeyPress += TextBox_OnlyNumbers_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 70);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 78;
            label3.Text = "Cedula:";
            // 
            // txt_telefono
            // 
            txt_telefono.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_telefono.Location = new Point(104, 157);
            txt_telefono.MaxLength = 10;
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(256, 23);
            txt_telefono.TabIndex = 6;
            txt_telefono.KeyPress += TextBox_OnlyNumbers_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 157);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 76;
            label4.Text = "Telefono:";
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.Location = new Point(104, 128);
            txt_email.MaxLength = 100;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(256, 23);
            txt_email.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 128);
            label5.Name = "label5";
            label5.Size = new Size(46, 17);
            label5.TabIndex = 74;
            label5.Text = "Email:";
            // 
            // txt_direccion
            // 
            txt_direccion.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_direccion.Location = new Point(104, 99);
            txt_direccion.MaxLength = 200;
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(256, 23);
            txt_direccion.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 99);
            label6.Name = "label6";
            label6.Size = new Size(71, 17);
            label6.TabIndex = 72;
            label6.Text = "Direccion:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(104, 186);
            txtUsuario.MaxLength = 20;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(256, 23);
            txtUsuario.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 186);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 82;
            label1.Text = "Usuario:";
            // 
            // txt_clave
            // 
            txt_clave.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_clave.Location = new Point(104, 215);
            txt_clave.Name = "txt_clave";
            txt_clave.PasswordChar = '*';
            txt_clave.Size = new Size(256, 23);
            txt_clave.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(24, 215);
            label9.Name = "label9";
            label9.Size = new Size(47, 17);
            label9.TabIndex = 80;
            label9.Text = "Clave:";
            // 
            // FormModificarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(383, 344);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(txt_clave);
            Controls.Add(label9);
            Controls.Add(txtCedula);
            Controls.Add(label3);
            Controls.Add(txt_telefono);
            Controls.Add(label4);
            Controls.Add(txt_email);
            Controls.Add(label5);
            Controls.Add(txt_direccion);
            Controls.Add(label6);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregarCliente);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txt_nombre);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormModificarEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtApellido;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox txt_nombre;
        private Label label8;
        private Button btnLimpiar;
        private Button btnAgregarCliente;
        private TextBox txtCedula;
        private TextBox txt_telefono;
        private TextBox txt_email;
        private Label label5;
        private TextBox txt_direccion;
        private Label label6;
        private TextBox txtUsuario;
        private Label label1;
        private TextBox txt_clave;
        private Label label9;
    }
}