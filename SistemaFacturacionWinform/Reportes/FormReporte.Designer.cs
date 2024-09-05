namespace SistemaFacturacionWinform.Reportes
{
    partial class FormReporte
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
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            cmbTipoReporte = new ComboBox();
            btnGenerarReporte = new Button();
            pnlReporte = new Panel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbTipoReporte);
            groupBox1.Controls.Add(btnGenerarReporte);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(16, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(960, 120);
            groupBox1.TabIndex = 76;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generar Reporte";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.Items.AddRange(new object[] { "Empleado", "Administrador" });
            comboBox2.Location = new Point(648, 80);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 25);
            comboBox2.TabIndex = 76;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 48);
            label4.Name = "label4";
            label4.Size = new Size(208, 17);
            label4.TabIndex = 75;
            label4.Text = "Selecionar el reporte a mostrar:";
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoReporte.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoReporte.Items.AddRange(new object[] { "Empleado", "Administrador" });
            cmbTipoReporte.Location = new Point(16, 80);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(488, 25);
            cmbTipoReporte.TabIndex = 74;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.BackColor = Color.FromArgb(128, 255, 255);
            btnGenerarReporte.FlatStyle = FlatStyle.Popup;
            btnGenerarReporte.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold);
            btnGenerarReporte.ForeColor = Color.Black;
            btnGenerarReporte.Location = new Point(520, 80);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(120, 23);
            btnGenerarReporte.TabIndex = 53;
            btnGenerarReporte.Text = "Limpiar";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            // 
            // pnlReporte
            // 
            pnlReporte.Location = new Point(16, 185);
            pnlReporte.Name = "pnlReporte";
            pnlReporte.Size = new Size(949, 386);
            pnlReporte.TabIndex = 77;
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(988, 605);
            Controls.Add(pnlReporte);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReporte";
            Text = "Factura";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox2;
        private Label label4;
        private ComboBox cmbTipoReporte;
        private Button btnGenerarReporte;
        private Panel pnlReporte;
    }
}