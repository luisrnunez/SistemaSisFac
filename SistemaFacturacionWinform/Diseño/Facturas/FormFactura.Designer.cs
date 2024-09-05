using System.Windows.Forms;

namespace SistemaFacturacionWinform
{
    partial class FormFactura
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
            txtMostrarFactura = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dtpFecha = new DateTimePicker();
            btnBuscar = new Button();
            cmbCriterio = new ComboBox();
            txtBusqueda = new TextBox();
            label5 = new Label();
            label3 = new Label();
            btnVenta = new Button();
            dgv_Facturas = new DataGridView();
            idClienteColumn = new DataGridViewTextBoxColumn();
            dt = new DateTimePicker();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Facturas).BeginInit();
            SuspendLayout();
            // 
            // txtMostrarFactura
            // 
            txtMostrarFactura.BackColor = Color.White;
            txtMostrarFactura.BorderStyle = BorderStyle.FixedSingle;
            txtMostrarFactura.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMostrarFactura.Location = new Point(571, 49);
            txtMostrarFactura.Multiline = true;
            txtMostrarFactura.Name = "txtMostrarFactura";
            txtMostrarFactura.ReadOnly = true;
            txtMostrarFactura.Size = new Size(405, 573);
            txtMostrarFactura.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(678, 9);
            label1.Name = "label1";
            label1.Size = new Size(201, 37);
            label1.TabIndex = 13;
            label1.Text = "VISTA PREVIA";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Azure;
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(cmbCriterio);
            groupBox1.Controls.Add(txtBusqueda);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnVenta);
            groupBox1.Controls.Add(dgv_Facturas);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(565, 634);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "mm/dd/yyyy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(271, 48);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(283, 26);
            dtpFecha.TabIndex = 88;
            dtpFecha.Value = new DateTime(2024, 9, 2, 0, 0, 0, 0);
            dtpFecha.Visible = false;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(128, 255, 255);
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(453, 80);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(101, 29);
            btnBuscar.TabIndex = 85;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbCriterio
            // 
            cmbCriterio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCriterio.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCriterio.Items.AddRange(new object[] { "Nombre Cliente", "Nombre Empleado" });
            cmbCriterio.Location = new Point(111, 49);
            cmbCriterio.Name = "cmbCriterio";
            cmbCriterio.Size = new Size(143, 25);
            cmbCriterio.TabIndex = 87;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Font = new Font("Arial", 14F);
            txtBusqueda.Location = new Point(12, 80);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(435, 29);
            txtBusqueda.TabIndex = 84;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold);
            label5.Location = new Point(12, 53);
            label5.Name = "label5";
            label5.Size = new Size(88, 16);
            label5.TabIndex = 86;
            label5.Text = "Buscar por:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(172, 9);
            label3.Name = "label3";
            label3.Size = new Size(204, 31);
            label3.TabIndex = 15;
            label3.Text = "Listar de Facturas";
            // 
            // btnVenta
            // 
            btnVenta.BackColor = Color.FromArgb(255, 152, 0);
            btnVenta.FlatStyle = FlatStyle.Flat;
            btnVenta.Font = new Font("Arial Narrow", 18F, FontStyle.Bold);
            btnVenta.ForeColor = Color.White;
            btnVenta.Location = new Point(196, 559);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(158, 69);
            btnVenta.TabIndex = 42;
            btnVenta.Text = "Imprimir factura";
            btnVenta.UseVisualStyleBackColor = false;
            btnVenta.Click += btnImprimir_Click;
            // 
            // dgv_Facturas
            // 
            dgv_Facturas.AllowUserToAddRows = false;
            dgv_Facturas.AllowUserToDeleteRows = false;
            dgv_Facturas.AllowUserToResizeColumns = false;
            dgv_Facturas.AllowUserToResizeRows = false;
            dgv_Facturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_Facturas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Facturas.BackgroundColor = Color.White;
            dgv_Facturas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Facturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Facturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Facturas.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Facturas.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgv_Facturas.Location = new Point(11, 115);
            dgv_Facturas.MultiSelect = false;
            dgv_Facturas.Name = "dgv_Facturas";
            dgv_Facturas.ReadOnly = true;
            dgv_Facturas.RowHeadersVisible = false;
            dgv_Facturas.RowHeadersWidth = 51;
            dgv_Facturas.RowTemplate.Height = 24;
            dgv_Facturas.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv_Facturas.Size = new Size(543, 438);
            dgv_Facturas.TabIndex = 56;
            dgv_Facturas.CellClick += dgv_Facturas_CellClick;
            dgv_Facturas.CellMouseEnter += dgv_Facturas_CellMouseEnter;
            dgv_Facturas.CellMouseLeave += dgv_Facturas_CellMouseLeave;
            // 
            // idClienteColumn
            // 
            idClienteColumn.DataPropertyName = "IdCliente";
            idClienteColumn.HeaderText = "ID Cliente";
            idClienteColumn.Name = "idClienteColumn";
            idClienteColumn.ReadOnly = true;
            idClienteColumn.Visible = false;
            // 
            // dt
            // 
            dt.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dt.Location = new Point(708, 9);
            dt.Name = "dt";
            dt.Size = new Size(201, 44);
            dt.TabIndex = 99;
            // 
            // FormFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(980, 634);
            Controls.Add(txtMostrarFactura);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFactura";
            Text = "Factura";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Facturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMostrarFactura;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgv_Facturas;
        private DataGridViewTextBoxColumn idClienteColumn;
        private Button btnVenta;
        private Label label3;
        private Button btnBuscar;
        private ComboBox cmbCriterio;
        private TextBox txtBusqueda;
        private Label label5;
        private DateTimePicker dt;
        private DateTimePicker dtpFecha;
    }
}