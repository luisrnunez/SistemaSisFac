namespace SistemaFacturacionWinform.Diseño.Productos
{
    partial class FormModificarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarProducto));
            txtDescripcion = new TextBox();
            label2 = new Label();
            txtStock = new TextBox();
            label1 = new Label();
            txtPrecio = new TextBox();
            txt_nombre = new TextBox();
            label8 = new Label();
            label9 = new Label();
            btnLimpiar = new Button();
            btnAgregarCliente = new Button();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(120, 96);
            txtDescripcion.MaxLength = 200;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(256, 48);
            txtDescripcion.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 109);
            label2.Name = "label2";
            label2.Size = new Size(86, 17);
            label2.TabIndex = 68;
            label2.Text = "Descripcion:";
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.Location = new Point(120, 168);
            txtStock.MaxLength = 10;
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(256, 23);
            txtStock.TabIndex = 3;
            txtStock.KeyPress += txt_stock_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 168);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 66;
            label1.Text = "Stock:";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(120, 208);
            txtPrecio.MaxLength = 10;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(256, 23);
            txtPrecio.TabIndex = 61;
            txtPrecio.KeyPress += txt_precio_KeyPress;
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_nombre.Location = new Point(120, 40);
            txt_nombre.MaxLength = 100;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(256, 23);
            txt_nombre.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(32, 40);
            label8.Name = "label8";
            label8.Size = new Size(62, 17);
            label8.TabIndex = 59;
            label8.Text = "Nombre:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(32, 216);
            label9.Name = "label9";
            label9.Size = new Size(52, 17);
            label9.TabIndex = 58;
            label9.Text = "Precio:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(128, 255, 255);
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.Location = new Point(280, 288);
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
            btnAgregarCliente.Location = new Point(120, 264);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(120, 64);
            btnAgregarCliente.TabIndex = 70;
            btnAgregarCliente.Text = "Guardar";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnModificar_Click;
            // 
            // FormModificarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(391, 347);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregarCliente);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(txtStock);
            Controls.Add(label1);
            Controls.Add(txtPrecio);
            Controls.Add(txt_nombre);
            Controls.Add(label8);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormModificarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcion;
        private Label label2;
        private TextBox txtStock;
        private Label label1;
        private TextBox txtPrecio;
        private TextBox txt_nombre;
        private Label label8;
        private Label label9;
        private Button btnLimpiar;
        private Button btnAgregarCliente;
    }
}