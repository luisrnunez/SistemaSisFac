using System.Windows.Forms;

namespace SistemaFacturacionWinform.Diseño.Clientes
{
    partial class FormClientes
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            txtApellido = new TextBox();
            label2 = new Label();
            txtCedula = new TextBox();
            label1 = new Label();
            btnLimpiar = new Button();
            txt_telefono = new TextBox();
            label4 = new Label();
            txt_email = new TextBox();
            label3 = new Label();
            txt_direccion = new TextBox();
            txt_nombre = new TextBox();
            btnAgregarCliente = new Button();
            label8 = new Label();
            label9 = new Label();
            groupBox2 = new GroupBox();
            btnBuscar = new Button();
            cmbCriterio = new ComboBox();
            label5 = new Label();
            txtBusqueda = new TextBox();
            dgv_Clientes = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Clientes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCedula);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(txt_telefono);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_direccion);
            groupBox1.Controls.Add(txt_nombre);
            groupBox1.Controls.Add(btnAgregarCliente);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(24, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(944, 200);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar nuevo cliente";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(96, 96);
            txtApellido.MaxLength = 100;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(256, 23);
            txtApellido.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 100);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 56;
            label2.Text = "Apellido:";
            // 
            // txtCedula
            // 
            txtCedula.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCedula.Location = new Point(96, 152);
            txtCedula.MaxLength = 10;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(256, 23);
            txtCedula.TabIndex = 3;
            txtCedula.KeyPress += TextBox_OnlyNumbers_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 156);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 54;
            label1.Text = "Cedula:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(128, 255, 255);
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.Location = new Point(768, 144);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 23);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txt_telefono
            // 
            txt_telefono.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_telefono.Location = new Point(440, 152);
            txt_telefono.MaxLength = 10;
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(248, 23);
            txt_telefono.TabIndex = 6;
            txt_telefono.KeyPress += TextBox_OnlyNumbers_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(368, 160);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 49;
            label4.Text = "Telefono:";
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.Location = new Point(440, 96);
            txt_email.MaxLength = 100;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(248, 23);
            txt_email.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(368, 96);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 45;
            label3.Text = "Email:";
            // 
            // txt_direccion
            // 
            txt_direccion.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_direccion.Location = new Point(440, 40);
            txt_direccion.MaxLength = 200;
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(248, 23);
            txt_direccion.TabIndex = 4;
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_nombre.Location = new Point(96, 40);
            txt_nombre.MaxLength = 100;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(256, 23);
            txt_nombre.TabIndex = 1;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.BackColor = Color.FromArgb(255, 152, 0);
            btnAgregarCliente.FlatStyle = FlatStyle.Popup;
            btnAgregarCliente.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            btnAgregarCliente.ForeColor = Color.White;
            btnAgregarCliente.Location = new Point(752, 40);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(152, 64);
            btnAgregarCliente.TabIndex = 7;
            btnAgregarCliente.Text = "Agregar ";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnCrear_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(24, 44);
            label8.Name = "label8";
            label8.Size = new Size(62, 17);
            label8.TabIndex = 37;
            label8.Text = "Nombre:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(364, 44);
            label9.Name = "label9";
            label9.Size = new Size(71, 17);
            label9.TabIndex = 24;
            label9.Text = "Direccion:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(cmbCriterio);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtBusqueda);
            groupBox2.Controls.Add(dgv_Clientes);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Arial", 14F);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(24, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(944, 368);
            groupBox2.TabIndex = 58;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de clientes";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(128, 255, 255);
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(808, 32);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 29);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbCriterio
            // 
            cmbCriterio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCriterio.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCriterio.Items.AddRange(new object[] { "Cedula", "Nombre", "Apellido" });
            cmbCriterio.Location = new Point(111, 36);
            cmbCriterio.Name = "cmbCriterio";
            cmbCriterio.Size = new Size(119, 25);
            cmbCriterio.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold);
            label5.Location = new Point(8, 40);
            label5.Name = "label5";
            label5.Size = new Size(88, 16);
            label5.TabIndex = 58;
            label5.Text = "Buscar por:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Font = new Font("Arial", 14F);
            txtBusqueda.Location = new Point(236, 32);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(566, 29);
            txtBusqueda.TabIndex = 10;
            // 
            // dgv_Clientes
            // 
            dgv_Clientes.AllowUserToAddRows = false;
            dgv_Clientes.AllowUserToDeleteRows = false;
            dgv_Clientes.AllowUserToResizeColumns = false;
            dgv_Clientes.AllowUserToResizeRows = false;
            dgv_Clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Clientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Clientes.BackgroundColor = Color.White;
            dgv_Clientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgv_Clientes.DefaultCellStyle = dataGridViewCellStyle4;
            dgv_Clientes.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgv_Clientes.Location = new Point(16, 72);
            dgv_Clientes.MultiSelect = false;
            dgv_Clientes.Name = "dgv_Clientes";
            dgv_Clientes.ReadOnly = true;
            dgv_Clientes.RowHeadersVisible = false;
            dgv_Clientes.RowHeadersWidth = 51;
            dgv_Clientes.RowTemplate.Height = 24;
            dgv_Clientes.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv_Clientes.Size = new Size(912, 280);
            dgv_Clientes.TabIndex = 56;
            dgv_Clientes.CellClick += dgv_Clientes_CellClick;
            dgv_Clientes.CellMouseEnter += dgv_Clientes_CellMouseEnter;
            dgv_Clientes.CellMouseLeave += dgv_Clientes_CellMouseLeave;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(988, 605);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormClientes";
            Text = "FormCliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Clientes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnLimpiar;
        private TextBox txt_telefono;
        private Label label4;
        private TextBox txt_email;
        private Label label3;
        private TextBox txt_direccion;
        private TextBox txt_nombre;
        private Button btnAgregarCliente;
        private Label label8;
        private Label label9;
        private TextBox txtCedula;
        private Label label1;
        private TextBox txtApellido;
        private Label label2;
        private Button btnEliminar;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox txtBusqueda;
        private DataGridView dgv_Clientes;
        private ComboBox cmbCriterio;
        private Button btnBuscar;
    }
}