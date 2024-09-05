
using System.Windows.Forms;

namespace SistemaFacturacionWinform
{
    partial class FormVentas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentas));
            label1 = new Label();
            dgv_Productos = new DataGridView();
            groupBox1 = new GroupBox();
            label4 = new Label();
            lb_cambioadevolver = new TextBox();
            lb_totalapagar = new TextBox();
            txtCliente = new TextBox();
            dgv_Detalles = new DataGridView();
            BtnCancelar = new Button();
            Txt_agregarpago = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label8 = new Label();
            Btn_Factura = new Button();
            label9 = new Label();
            label10 = new Label();
            label3 = new Label();
            btnBuscar = new Button();
            cmbCriterio = new ComboBox();
            txtBusqueda = new TextBox();
            label5 = new Label();
            BtnAggProveedor = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Productos).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Detalles).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 8);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 8;
            label1.Text = "Lista de Productos";
            // 
            // dgv_Productos
            // 
            dgv_Productos.AllowUserToAddRows = false;
            dgv_Productos.AllowUserToDeleteRows = false;
            dgv_Productos.AllowUserToResizeColumns = false;
            dgv_Productos.AllowUserToResizeRows = false;
            dgv_Productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_Productos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Productos.BackgroundColor = Color.White;
            dgv_Productos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Productos.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Productos.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgv_Productos.Location = new Point(5, 111);
            dgv_Productos.MultiSelect = false;
            dgv_Productos.Name = "dgv_Productos";
            dgv_Productos.ReadOnly = true;
            dgv_Productos.RowHeadersVisible = false;
            dgv_Productos.RowHeadersWidth = 51;
            dgv_Productos.RowTemplate.Height = 24;
            dgv_Productos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv_Productos.Size = new Size(523, 513);
            dgv_Productos.TabIndex = 56;
            dgv_Productos.CellClick += dgv_Productos_CellDoubleClick;
            dgv_Productos.CellMouseEnter += dgv_Productos_CellMouseEnter;
            dgv_Productos.CellMouseLeave += dgv_Productos_CellMouseLeave;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(BtnAggProveedor);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lb_cambioadevolver);
            groupBox1.Controls.Add(lb_totalapagar);
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Controls.Add(dgv_Detalles);
            groupBox1.Controls.Add(BtnCancelar);
            groupBox1.Controls.Add(Txt_agregarpago);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(Btn_Factura);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(536, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 624);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "VENTA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(120, 440);
            label4.Name = "label4";
            label4.Size = new Size(21, 24);
            label4.TabIndex = 32;
            label4.Text = "$";
            // 
            // lb_cambioadevolver
            // 
            lb_cambioadevolver.BackColor = Color.White;
            lb_cambioadevolver.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_cambioadevolver.ForeColor = Color.Lime;
            lb_cambioadevolver.Location = new Point(144, 520);
            lb_cambioadevolver.Name = "lb_cambioadevolver";
            lb_cambioadevolver.ReadOnly = true;
            lb_cambioadevolver.Size = new Size(208, 29);
            lb_cambioadevolver.TabIndex = 31;
            // 
            // lb_totalapagar
            // 
            lb_totalapagar.BackColor = Color.White;
            lb_totalapagar.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_totalapagar.ForeColor = Color.Red;
            lb_totalapagar.Location = new Point(144, 480);
            lb_totalapagar.Name = "lb_totalapagar";
            lb_totalapagar.ReadOnly = true;
            lb_totalapagar.Size = new Size(208, 29);
            lb_totalapagar.TabIndex = 30;
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Arial", 10F);
            txtCliente.Location = new Point(88, 400);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(264, 23);
            txtCliente.TabIndex = 28;
            // 
            // dgv_Detalles
            // 
            dgv_Detalles.AllowUserToAddRows = false;
            dgv_Detalles.AllowUserToDeleteRows = false;
            dgv_Detalles.AllowUserToResizeColumns = false;
            dgv_Detalles.AllowUserToResizeRows = false;
            dgv_Detalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Detalles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Detalles.BackgroundColor = Color.White;
            dgv_Detalles.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgv_Detalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Detalles.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgv_Detalles.Location = new Point(6, 22);
            dgv_Detalles.Name = "dgv_Detalles";
            dgv_Detalles.ReadOnly = true;
            dgv_Detalles.RowHeadersVisible = false;
            dgv_Detalles.RowHeadersWidth = 51;
            dgv_Detalles.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            dgv_Detalles.RowTemplate.Height = 24;
            dgv_Detalles.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv_Detalles.Size = new Size(434, 370);
            dgv_Detalles.TabIndex = 13;
            dgv_Detalles.CellDoubleClick += dgv_Detalles_CellDoubleClick;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.FromArgb(3, 169, 244);
            BtnCancelar.FlatStyle = FlatStyle.Popup;
            BtnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            BtnCancelar.Location = new Point(336, 568);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(71, 48);
            BtnCancelar.TabIndex = 26;
            BtnCancelar.Text = "Cancelar Compra";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // Txt_agregarpago
            // 
            Txt_agregarpago.Location = new Point(144, 440);
            Txt_agregarpago.Multiline = true;
            Txt_agregarpago.Name = "Txt_agregarpago";
            Txt_agregarpago.Size = new Size(208, 32);
            Txt_agregarpago.TabIndex = 24;
            Txt_agregarpago.TextChanged += Txt_agregarpago_TextChanged;
            Txt_agregarpago.KeyPress += txt_precio_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(120, 520);
            label11.Name = "label11";
            label11.Size = new Size(21, 24);
            label11.TabIndex = 22;
            label11.Text = "$";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(120, 480);
            label12.Name = "label12";
            label12.Size = new Size(21, 24);
            label12.TabIndex = 21;
            label12.Text = "$";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 12F);
            label8.Location = new Point(16, 440);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 16;
            label8.Text = "PAGO:";
            // 
            // Btn_Factura
            // 
            Btn_Factura.BackColor = Color.FromArgb(255, 152, 0);
            Btn_Factura.FlatStyle = FlatStyle.Popup;
            Btn_Factura.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Factura.ForeColor = Color.White;
            Btn_Factura.Location = new Point(152, 568);
            Btn_Factura.Name = "Btn_Factura";
            Btn_Factura.Size = new Size(135, 47);
            Btn_Factura.TabIndex = 15;
            Btn_Factura.Text = "Finalizar";
            Btn_Factura.UseVisualStyleBackColor = false;
            Btn_Factura.Click += btnFinalizarVenta_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 12F);
            label9.Location = new Point(16, 520);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 11;
            label9.Text = "Su cambio:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 12F);
            label10.Location = new Point(16, 480);
            label10.Name = "label10";
            label10.Size = new Size(99, 20);
            label10.TabIndex = 10;
            label10.Text = "Monto a pagar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F);
            label3.Location = new Point(16, 400);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 1;
            label3.Text = "Cliente: ";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(128, 255, 255);
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(427, 76);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(101, 29);
            btnBuscar.TabIndex = 81;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbCriterio
            // 
            cmbCriterio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCriterio.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCriterio.Items.AddRange(new object[] { "Nombre" });
            cmbCriterio.Location = new Point(99, 45);
            cmbCriterio.Name = "cmbCriterio";
            cmbCriterio.Size = new Size(128, 25);
            cmbCriterio.TabIndex = 83;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Font = new Font("Arial", 14F);
            txtBusqueda.Location = new Point(5, 76);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(405, 29);
            txtBusqueda.TabIndex = 80;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold);
            label5.Location = new Point(5, 49);
            label5.Name = "label5";
            label5.Size = new Size(88, 16);
            label5.TabIndex = 82;
            label5.Text = "Buscar por:";
            // 
            // BtnAggProveedor
            // 
            BtnAggProveedor.BackColor = Color.Transparent;
            BtnAggProveedor.BackgroundImage = (Image)resources.GetObject("BtnAggProveedor.BackgroundImage");
            BtnAggProveedor.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAggProveedor.FlatStyle = FlatStyle.Flat;
            BtnAggProveedor.Font = new Font("Arial Narrow", 20F);
            BtnAggProveedor.ForeColor = Color.White;
            BtnAggProveedor.Location = new Point(358, 398);
            BtnAggProveedor.Name = "BtnAggProveedor";
            BtnAggProveedor.Size = new Size(41, 29);
            BtnAggProveedor.TabIndex = 58;
            BtnAggProveedor.UseVisualStyleBackColor = false;
            BtnAggProveedor.Click += BtnAggCliente_Click;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(980, 634);
            ControlBox = false;
            Controls.Add(btnBuscar);
            Controls.Add(cmbCriterio);
            Controls.Add(txtBusqueda);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(dgv_Productos);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVentas";
            ShowIcon = false;
            Text = "FormVentas";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgv_Productos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Detalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ComboBox cmbClientes;
        private Label label1;
        private DataGridView dgv_Productos;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox txtCliente;
        private DataGridView dgv_Detalles;
        private Button BtnCancelar;
        private TextBox Txt_agregarpago;
        protected Label label11;
        private Label label12;
        private Label label8;
        private Button Btn_Factura;
        private Label label9;
        private Label label10;
        private Label label3;
        private Label label4;
        private TextBox lb_cambioadevolver;
        private TextBox lb_totalapagar;
        private Button btnBuscar;
        private ComboBox cmbCriterio;
        private TextBox txtBusqueda;
        private Label label5;
        private Button BtnAggProveedor;
    }
}