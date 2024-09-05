using System.Windows.Forms;

namespace SistemaFacturacionWinform
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panel1 = new Panel();
            panel2 = new Panel();
            pnlBotones = new FlowLayoutPanel();
            btnVenta = new Button();
            btnClientes = new Button();
            btnProductos = new Button();
            btnEmpleados = new Button();
            btnFactura = new Button();
            btnReportes = new Button();
            btnCerrar = new Button();
            lbNombreRol = new Label();
            lbRol = new Label();
            pictureBox1 = new PictureBox();
            pnlPrincipal = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btnProveedor = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 634);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 121, 107);
            panel2.Controls.Add(pnlBotones);
            panel2.Controls.Add(btnCerrar);
            panel2.Controls.Add(lbNombreRol);
            panel2.Controls.Add(lbRol);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(176, 634);
            panel2.TabIndex = 2;
            // 
            // pnlBotones
            // 
            pnlBotones.BackColor = Color.Transparent;
            pnlBotones.Controls.Add(btnVenta);
            pnlBotones.Controls.Add(btnClientes);
            pnlBotones.Controls.Add(btnProductos);
            pnlBotones.Controls.Add(btnEmpleados);
            pnlBotones.Controls.Add(btnProveedor);
            pnlBotones.Controls.Add(btnFactura);
            pnlBotones.Controls.Add(btnReportes);
            pnlBotones.ForeColor = Color.White;
            pnlBotones.Location = new Point(6, 200);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(168, 376);
            pnlBotones.TabIndex = 55;
            // 
            // btnVenta
            // 
            btnVenta.BackColor = Color.FromArgb(255, 152, 0);
            btnVenta.FlatStyle = FlatStyle.Flat;
            btnVenta.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            btnVenta.ForeColor = Color.White;
            btnVenta.Location = new Point(3, 3);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(159, 37);
            btnVenta.TabIndex = 41;
            btnVenta.Text = "Ventas";
            btnVenta.UseVisualStyleBackColor = false;
            btnVenta.Click += btnVenta_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(255, 152, 0);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(3, 46);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(159, 34);
            btnClientes.TabIndex = 42;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(255, 152, 0);
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(3, 86);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(159, 34);
            btnProductos.TabIndex = 43;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.FromArgb(255, 152, 0);
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            btnEmpleados.ForeColor = Color.White;
            btnEmpleados.Location = new Point(3, 126);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(159, 34);
            btnEmpleados.TabIndex = 47;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnFactura
            // 
            btnFactura.BackColor = Color.FromArgb(255, 152, 0);
            btnFactura.FlatStyle = FlatStyle.Flat;
            btnFactura.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            btnFactura.ForeColor = Color.White;
            btnFactura.Location = new Point(3, 206);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(159, 34);
            btnFactura.TabIndex = 44;
            btnFactura.Text = "Factura";
            btnFactura.UseVisualStyleBackColor = false;
            btnFactura.Click += btnFactura_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(255, 152, 0);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            btnReportes.ForeColor = Color.White;
            btnReportes.Location = new Point(3, 246);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(159, 34);
            btnReportes.TabIndex = 48;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(128, 255, 255);
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.Black;
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(40, 600);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(96, 23);
            btnCerrar.TabIndex = 54;
            btnCerrar.Text = "Salir";
            btnCerrar.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lbNombreRol
            // 
            lbNombreRol.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbNombreRol.AutoSize = true;
            lbNombreRol.Font = new Font("Arial Narrow", 9F);
            lbNombreRol.ForeColor = Color.White;
            lbNombreRol.Location = new Point(40, 168);
            lbNombreRol.Name = "lbNombreRol";
            lbNombreRol.Size = new Size(13, 16);
            lbNombreRol.TabIndex = 13;
            lbNombreRol.Text = "--";
            lbNombreRol.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbRol
            // 
            lbRol.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbRol.AutoSize = true;
            lbRol.Font = new Font("Arial Narrow", 12F);
            lbRol.Location = new Point(40, 144);
            lbRol.Name = "lbRol";
            lbRol.Size = new Size(91, 20);
            lbRol.TabIndex = 12;
            lbRol.Text = "Administrador";
            lbRol.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BackColor = Color.FromArgb(255, 255, 255);
            pnlPrincipal.Controls.Add(pictureBox2);
            pnlPrincipal.Controls.Add(label1);
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Location = new Point(184, 0);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(980, 634);
            pnlPrincipal.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(392, 96);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 168);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 40F, FontStyle.Bold);
            label1.Location = new Point(152, 288);
            label1.Name = "label1";
            label1.Size = new Size(630, 64);
            label1.TabIndex = 13;
            label1.Text = "Sistema de Facturacion V1.1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnProveedor
            // 
            btnProveedor.BackColor = Color.FromArgb(255, 152, 0);
            btnProveedor.FlatStyle = FlatStyle.Flat;
            btnProveedor.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            btnProveedor.ForeColor = Color.White;
            btnProveedor.Location = new Point(3, 166);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(159, 34);
            btnProveedor.TabIndex = 49;
            btnProveedor.Text = "Proveedores";
            btnProveedor.UseVisualStyleBackColor = false;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1164, 634);
            Controls.Add(pnlPrincipal);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Facturacion";
            FormClosed += FormPrincipal_FormClosed;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlPrincipal.ResumeLayout(false);
            pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button BtnCancelar;
        private Panel panel1;
        private Panel panel2;
        private Panel pnlPrincipal;
        private PictureBox pictureBox1;
        private Label lbRol;
        private Label lbNombreRol;
        private Button btnVenta;
        private Button btnFactura;
        private Button btnProductos;
        private Button btnClientes;
        private Label label1;
        private PictureBox pictureBox2;
        private Button btnCerrar;
        private FlowLayoutPanel pnlBotones;
        private Button btnReportes;
        private Button btnEmpleados;
        private Button btnProveedor;
    }
}
