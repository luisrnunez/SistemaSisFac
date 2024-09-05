namespace SistemaFacturacionWinform
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(94, 92);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(200, 26);
            txtUsuario.TabIndex = 0;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Arial Narrow", 12F);
            txtClave.Location = new Point(94, 142);
            txtClave.Name = "txtClave";
            txtClave.PlaceholderText = "Clave";
            txtClave.Size = new Size(200, 26);
            txtClave.TabIndex = 1;
            txtClave.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 152, 0);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(128, 192);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(128, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(144, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(389, 250);
            Controls.Add(pictureBox1);
            Controls.Add(txtUsuario);
            Controls.Add(txtClave);
            Controls.Add(btnLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Venta";
            FormClosing += LoginForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private PictureBox pictureBox1;
    }
}