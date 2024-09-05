using System.Windows.Forms;

namespace SistemaFacturacionWinform
{
    partial class FormAggCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAggCliente));
            dgv_Clientes = new DataGridView();
            btnBuscar = new Button();
            cmbCriterio = new ComboBox();
            label5 = new Label();
            txtBusqueda = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Clientes).BeginInit();
            SuspendLayout();
            // 
            // dgv_Clientes
            // 
            dgv_Clientes.AllowUserToAddRows = false;
            dgv_Clientes.AllowUserToDeleteRows = false;
            dgv_Clientes.AllowUserToResizeColumns = false;
            dgv_Clientes.AllowUserToResizeRows = false;
            dgv_Clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Clientes.BackgroundColor = Color.White;
            dgv_Clientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Clientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Clientes.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgv_Clientes.Location = new Point(12, 43);
            dgv_Clientes.MultiSelect = false;
            dgv_Clientes.Name = "dgv_Clientes";
            dgv_Clientes.ReadOnly = true;
            dgv_Clientes.RowHeadersVisible = false;
            dgv_Clientes.RowHeadersWidth = 51;
            dgv_Clientes.RowTemplate.Height = 24;
            dgv_Clientes.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv_Clientes.Size = new Size(789, 280);
            dgv_Clientes.TabIndex = 56;
            dgv_Clientes.CellClick += dgv_Clientes_CellClick;
            dgv_Clientes.CellMouseEnter += dgv_Clientes_CellMouseEnter;
            dgv_Clientes.CellMouseLeave += dgv_Clientes_CellMouseLeave;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(128, 255, 255);
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(681, 7);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 29);
            btnBuscar.TabIndex = 77;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbCriterio
            // 
            cmbCriterio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCriterio.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCriterio.Items.AddRange(new object[] { "Cedula", "Nombre", "Apellido" });
            cmbCriterio.Location = new Point(106, 9);
            cmbCriterio.Name = "cmbCriterio";
            cmbCriterio.Size = new Size(119, 25);
            cmbCriterio.TabIndex = 79;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold);
            label5.Location = new Point(12, 15);
            label5.Name = "label5";
            label5.Size = new Size(88, 16);
            label5.TabIndex = 78;
            label5.Text = "Buscar por:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Font = new Font("Arial", 14F);
            txtBusqueda.Location = new Point(231, 7);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(444, 29);
            txtBusqueda.TabIndex = 76;
            // 
            // FormAggCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 335);
            Controls.Add(btnBuscar);
            Controls.Add(cmbCriterio);
            Controls.Add(label5);
            Controls.Add(txtBusqueda);
            Controls.Add(dgv_Clientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAggCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar cliente";
            ((System.ComponentModel.ISupportInitialize)dgv_Clientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv_Clientes;
        private Button btnBuscar;
        private ComboBox cmbCriterio;
        private Label label5;
        private TextBox txtBusqueda;
    }
}