namespace Interfaz
{
    partial class Login
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
            label1 = new Label();
            txtUser = new TextBox();
            txtContraseña = new TextBox();
            label2 = new Label();
            btnIniciarSesion = new Button();
            label3 = new Label();
            btnRegistrarse = new LinkLabel();
            btnAutoCompletar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(328, 112);
            label1.Name = "label1";
            label1.Size = new Size(102, 36);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // txtUser
            // 
            txtUser.Anchor = AnchorStyles.None;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Location = new Point(217, 160);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(315, 50);
            txtUser.TabIndex = 1;
            txtUser.WordWrap = false;
            // 
            // txtContraseña
            // 
            txtContraseña.Anchor = AnchorStyles.None;
            txtContraseña.BackColor = Color.White;
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Location = new Point(217, 344);
            txtContraseña.Multiline = true;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(315, 50);
            txtContraseña.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(310, 296);
            label2.Name = "label2";
            label2.Size = new Size(145, 36);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Anchor = AnchorStyles.None;
            btnIniciarSesion.Cursor = Cursors.Hand;
            btnIniciarSesion.FlatAppearance.BorderColor = Color.White;
            btnIniciarSesion.FlatAppearance.BorderSize = 2;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciarSesion.ForeColor = Color.White;
            btnIniciarSesion.Location = new Point(268, 501);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(218, 58);
            btnIniciarSesion.TabIndex = 4;
            btnIniciarSesion.Text = "Iniciar sesion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(217, 457);
            label3.Name = "label3";
            label3.Size = new Size(209, 25);
            label3.TabIndex = 5;
            label3.Text = "No tienen un usuario?  ";
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Anchor = AnchorStyles.None;
            btnRegistrarse.AutoSize = true;
            btnRegistrarse.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarse.ForeColor = SystemColors.ButtonFace;
            btnRegistrarse.Location = new Point(417, 457);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(137, 25);
            btnRegistrarse.TabIndex = 6;
            btnRegistrarse.TabStop = true;
            btnRegistrarse.Text = "Registrate aqui";
            btnRegistrarse.LinkClicked += btnRegistrarse_LinkClicked;
            // 
            // btnAutoCompletar
            // 
            btnAutoCompletar.Anchor = AnchorStyles.None;
            btnAutoCompletar.BackColor = Color.White;
            btnAutoCompletar.Cursor = Cursors.Hand;
            btnAutoCompletar.FlatAppearance.BorderColor = Color.White;
            btnAutoCompletar.FlatAppearance.BorderSize = 2;
            btnAutoCompletar.FlatStyle = FlatStyle.Flat;
            btnAutoCompletar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAutoCompletar.ForeColor = Color.FromArgb(128, 128, 255);
            btnAutoCompletar.Location = new Point(553, 170);
            btnAutoCompletar.Name = "btnAutoCompletar";
            btnAutoCompletar.Size = new Size(135, 40);
            btnAutoCompletar.TabIndex = 7;
            btnAutoCompletar.Text = "Autocompletar";
            btnAutoCompletar.UseVisualStyleBackColor = false;
            btnAutoCompletar.Click += btnAutoCompletar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(745, 648);
            Controls.Add(btnAutoCompletar);
            Controls.Add(btnRegistrarse);
            Controls.Add(label3);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtContraseña);
            Controls.Add(label2);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Cursor = Cursors.Arrow;
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUser;
        private TextBox txtContraseña;
        private Label label2;
        private Button btnIniciarSesion;
        private Label label3;
        private LinkLabel btnRegistrarse;
        private Button btnAutoCompletar;
    }
}