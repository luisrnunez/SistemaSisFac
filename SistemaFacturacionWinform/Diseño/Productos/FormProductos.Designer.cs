
namespace SistemaFacturacionWinform
{
    partial class FormProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            BtnAggProveedor = new Button();
            btnLimpiar = new Button();
            txt_stock = new TextBox();
            txtProveedor = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txt_precio = new TextBox();
            label3 = new Label();
            txt_descripcion = new TextBox();
            txt_nombre = new TextBox();
            BtnAgregar = new Button();
            label8 = new Label();
            label9 = new Label();
            groupBox2 = new GroupBox();
            btnBuscar = new Button();
            dgv_Productos = new DataGridView();
            cmbCriterio = new ComboBox();
            txtBusqueda = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Productos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(BtnAggProveedor);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(txt_stock);
            groupBox1.Controls.Add(txtProveedor);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_precio);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_descripcion);
            groupBox1.Controls.Add(txt_nombre);
            groupBox1.Controls.Add(BtnAgregar);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(24, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(936, 168);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar nuevo producto";
            // 
            // BtnAggProveedor
            // 
            BtnAggProveedor.BackColor = Color.Transparent;
            BtnAggProveedor.BackgroundImage = (Image)resources.GetObject("BtnAggProveedor.BackgroundImage");
            BtnAggProveedor.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAggProveedor.FlatStyle = FlatStyle.Flat;
            BtnAggProveedor.Font = new Font("Arial Narrow", 20F);
            BtnAggProveedor.ForeColor = Color.White;
            BtnAggProveedor.Location = new Point(710, 123);
            BtnAggProveedor.Name = "BtnAggProveedor";
            BtnAggProveedor.Size = new Size(41, 29);
            BtnAggProveedor.TabIndex = 6;
            BtnAggProveedor.UseVisualStyleBackColor = false;
            BtnAggProveedor.Click += BtnAggProveedor_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(128, 255, 255);
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Arial", 8F, FontStyle.Bold);
            btnLimpiar.Location = new Point(808, 106);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 31);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txt_stock
            // 
            txt_stock.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_stock.Location = new Point(459, 81);
            txt_stock.MaxLength = 10;
            txt_stock.Name = "txt_stock";
            txt_stock.Size = new Size(245, 23);
            txt_stock.TabIndex = 4;
            txt_stock.KeyPress += txt_stock_KeyPress;
            // 
            // txtProveedor
            // 
            txtProveedor.Font = new Font("Arial", 10F);
            txtProveedor.Location = new Point(459, 123);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.ReadOnly = true;
            txtProveedor.Size = new Size(245, 23);
            txtProveedor.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F);
            label1.Location = new Point(376, 128);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 55;
            label1.Text = "Proveedor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(376, 84);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 49;
            label4.Text = "Stock:";
            // 
            // txt_precio
            // 
            txt_precio.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_precio.Location = new Point(459, 38);
            txt_precio.MaxLength = 18;
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(245, 23);
            txt_precio.TabIndex = 3;
            txt_precio.KeyPress += txt_precio_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(376, 44);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 45;
            label3.Text = "Precio:";
            // 
            // txt_descripcion
            // 
            txt_descripcion.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_descripcion.Location = new Point(120, 84);
            txt_descripcion.MaxLength = 200;
            txt_descripcion.Multiline = true;
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(224, 64);
            txt_descripcion.TabIndex = 2;
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_nombre.Location = new Point(120, 41);
            txt_nombre.MaxLength = 100;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(224, 23);
            txt_nombre.TabIndex = 1;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.FromArgb(255, 152, 0);
            BtnAgregar.FlatStyle = FlatStyle.Popup;
            BtnAgregar.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
            BtnAgregar.ForeColor = Color.White;
            BtnAgregar.Location = new Point(761, 38);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(159, 55);
            BtnAgregar.TabIndex = 7;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += btnCrear_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(24, 47);
            label8.Name = "label8";
            label8.Size = new Size(62, 17);
            label8.TabIndex = 37;
            label8.Text = "Nombre:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(24, 106);
            label9.Name = "label9";
            label9.Size = new Size(86, 17);
            label9.TabIndex = 24;
            label9.Text = "Descripcion:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(dgv_Productos);
            groupBox2.Controls.Add(cmbCriterio);
            groupBox2.Controls.Add(txtBusqueda);
            groupBox2.Controls.Add(label5);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(24, 192);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(936, 400);
            groupBox2.TabIndex = 58;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de Productos";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(128, 255, 255);
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(819, 28);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(101, 29);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgv_Productos
            // 
            dgv_Productos.AllowUserToAddRows = false;
            dgv_Productos.AllowUserToDeleteRows = false;
            dgv_Productos.AllowUserToResizeColumns = false;
            dgv_Productos.AllowUserToResizeRows = false;
            dgv_Productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Productos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Productos.BackgroundColor = Color.White;
            dgv_Productos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Productos.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Productos.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgv_Productos.Location = new Point(16, 72);
            dgv_Productos.MultiSelect = false;
            dgv_Productos.Name = "dgv_Productos";
            dgv_Productos.ReadOnly = true;
            dgv_Productos.RowHeadersVisible = false;
            dgv_Productos.RowHeadersWidth = 51;
            dgv_Productos.RowTemplate.Height = 24;
            dgv_Productos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv_Productos.Size = new Size(912, 312);
            dgv_Productos.TabIndex = 56;
            dgv_Productos.CellClick += dgv_Productos_CellClick;
            dgv_Productos.CellMouseEnter += dgv_Productos_CellMouseEnter;
            dgv_Productos.CellMouseLeave += dgv_Productos_CellMouseLeave;
            // 
            // cmbCriterio
            // 
            cmbCriterio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCriterio.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCriterio.Items.AddRange(new object[] { "Nombre" });
            cmbCriterio.Location = new Point(112, 32);
            cmbCriterio.Name = "cmbCriterio";
            cmbCriterio.Size = new Size(128, 25);
            cmbCriterio.TabIndex = 9;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Font = new Font("Arial", 14F);
            txtBusqueda.Location = new Point(246, 28);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(567, 29);
            txtBusqueda.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold);
            label5.Location = new Point(18, 36);
            label5.Name = "label5";
            label5.Size = new Size(88, 16);
            label5.TabIndex = 78;
            label5.Text = "Buscar por:";
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(988, 605);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProductos";
            Text = "FormProductos";
            Load += FormProductos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Productos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnLimpiar;
        private TextBox txt_stock;
        private Label label4;
        private TextBox txt_precio;
        private Label label3;
        private TextBox txt_descripcion;
        private TextBox txt_nombre;
        private Button BtnAgregar;
        private Label label8;
        private Label label9;
        private GroupBox groupBox2;
        private DataGridView dgv_Productos;
        private Button btnBuscar;
        private ComboBox cmbCriterio;
        private TextBox txtBusqueda;
        private Label label5;
        private Button BtnAggProveedor;
        private TextBox txtProveedor;
        private Label label1;
    }
}