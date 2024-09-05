using SistemaFacturacionWinform.Diseño.Clientes;

namespace SistemaFacturacionWinform.Diseño.Proveedor
{
    partial class FormModificarProveedor
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

        private void InitializeComponent()
        {
            txtContacto = new TextBox();
            label2 = new Label();
            txtRUC = new TextBox();
            label1 = new Label();
            txt_telefono = new TextBox();
            label4 = new Label();
            txt_email = new TextBox();
            label3 = new Label();
            txt_direccion = new TextBox();
            txt_nombre = new TextBox();
            label8 = new Label();
            label9 = new Label();
            btnLimpiar = new Button();
            btnAgregarCliente = new Button();
            SuspendLayout();
            // 
            // txtContacto
            // 
            txtContacto.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContacto.Location = new Point(104, 96);
            txtContacto.MaxLength = 100;
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(256, 23);
            txtContacto.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 96);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 68;
            label2.Text = "Contacto:";
            // 
            // txtRUC
            // 
            txtRUC.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRUC.Location = new Point(104, 144);
            txtRUC.MaxLength = 13;
            txtRUC.Name = "txtRUC";
            txtRUC.Size = new Size(256, 23);
            txtRUC.TabIndex = 3;
            txtRUC.KeyPress += TextBox_OnlyNumbers_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 144);
            label1.Name = "label1";
            label1.Size = new Size(41, 17);
            label1.TabIndex = 66;
            label1.Text = "RUC:";
            // 
            // txt_telefono
            // 
            txt_telefono.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_telefono.Location = new Point(104, 312);
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
            label4.Location = new Point(24, 312);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 64;
            label4.Text = "Telefono:";
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.Location = new Point(104, 256);
            txt_email.MaxLength = 100;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(256, 23);
            txt_email.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 256);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 62;
            label3.Text = "Email:";
            // 
            // txt_direccion
            // 
            txt_direccion.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_direccion.Location = new Point(104, 200);
            txt_direccion.MaxLength = 200;
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(256, 23);
            txt_direccion.TabIndex = 4;
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_nombre.Location = new Point(104, 40);
            txt_nombre.MaxLength = 100;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(256, 23);
            txt_nombre.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(24, 40);
            label8.Name = "label8";
            label8.Size = new Size(62, 17);
            label8.TabIndex = 59;
            label8.Text = "Nombre:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(24, 200);
            label9.Name = "label9";
            label9.Size = new Size(71, 17);
            label9.TabIndex = 58;
            label9.Text = "Direccion:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(128, 255, 255);
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.Location = new Point(280, 392);
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
            btnAgregarCliente.Location = new Point(120, 368);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(120, 64);
            btnAgregarCliente.TabIndex = 70;
            btnAgregarCliente.Text = "Guardar";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnModificar_Click;
            // 
            // FormModificarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(383, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregarCliente);
            Controls.Add(txtContacto);
            Controls.Add(label2);
            Controls.Add(txtRUC);
            Controls.Add(label1);
            Controls.Add(txt_telefono);
            Controls.Add(label4);
            Controls.Add(txt_email);
            Controls.Add(label3);
            Controls.Add(txt_direccion);
            Controls.Add(txt_nombre);
            Controls.Add(label8);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormModificarProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtContacto;
        private Label label2;
        private TextBox txtRUC;
        private Label label1;
        private TextBox txt_telefono;
        private Label label4;
        private TextBox txt_email;
        private Label label3;
        private TextBox txt_direccion;
        private TextBox txt_nombre;
        private Label label8;
        private Label label9;
        private Button btnLimpiar;
        private Button btnAgregarCliente;
    }
}