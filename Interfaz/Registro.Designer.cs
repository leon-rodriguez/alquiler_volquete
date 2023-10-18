namespace Interfaz
{
    partial class Registro
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
            txtUserRegistro = new TextBox();
            label1 = new Label();
            txtContraseñaRegistro = new TextBox();
            txtMailRegistro = new TextBox();
            btnRegistrarseRegistro = new Button();
            txtConfirmarContraseña = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label7 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtUserRegistro
            // 
            txtUserRegistro.Anchor = AnchorStyles.None;
            txtUserRegistro.BorderStyle = BorderStyle.FixedSingle;
            txtUserRegistro.Location = new Point(199, 119);
            txtUserRegistro.Multiline = true;
            txtUserRegistro.Name = "txtUserRegistro";
            txtUserRegistro.Size = new Size(315, 50);
            txtUserRegistro.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(315, 84);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // txtContraseñaRegistro
            // 
            txtContraseñaRegistro.Anchor = AnchorStyles.None;
            txtContraseñaRegistro.BorderStyle = BorderStyle.None;
            txtContraseñaRegistro.Location = new Point(197, 230);
            txtContraseñaRegistro.Multiline = true;
            txtContraseñaRegistro.Name = "txtContraseñaRegistro";
            txtContraseñaRegistro.PasswordChar = '*';
            txtContraseñaRegistro.Size = new Size(315, 50);
            txtContraseñaRegistro.TabIndex = 6;
            // 
            // txtMailRegistro
            // 
            txtMailRegistro.Anchor = AnchorStyles.None;
            txtMailRegistro.BorderStyle = BorderStyle.None;
            txtMailRegistro.Location = new Point(197, 425);
            txtMailRegistro.Multiline = true;
            txtMailRegistro.Name = "txtMailRegistro";
            txtMailRegistro.Size = new Size(315, 50);
            txtMailRegistro.TabIndex = 8;
            // 
            // btnRegistrarseRegistro
            // 
            btnRegistrarseRegistro.Anchor = AnchorStyles.None;
            btnRegistrarseRegistro.Cursor = Cursors.Hand;
            btnRegistrarseRegistro.FlatAppearance.BorderColor = Color.White;
            btnRegistrarseRegistro.FlatAppearance.BorderSize = 2;
            btnRegistrarseRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistrarseRegistro.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarseRegistro.ForeColor = Color.White;
            btnRegistrarseRegistro.Location = new Point(248, 513);
            btnRegistrarseRegistro.Name = "btnRegistrarseRegistro";
            btnRegistrarseRegistro.Size = new Size(218, 58);
            btnRegistrarseRegistro.TabIndex = 9;
            btnRegistrarseRegistro.Text = "Registrarse";
            btnRegistrarseRegistro.UseVisualStyleBackColor = true;
            btnRegistrarseRegistro.Click += btnRegistrarseRegistro_Click;
            // 
            // txtConfirmarContraseña
            // 
            txtConfirmarContraseña.Anchor = AnchorStyles.None;
            txtConfirmarContraseña.BorderStyle = BorderStyle.None;
            txtConfirmarContraseña.Location = new Point(197, 327);
            txtConfirmarContraseña.Multiline = true;
            txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            txtConfirmarContraseña.PasswordChar = '*';
            txtConfirmarContraseña.Size = new Size(315, 50);
            txtConfirmarContraseña.TabIndex = 11;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(315, 196);
            label5.Name = "label5";
            label5.Size = new Size(96, 21);
            label5.TabIndex = 12;
            label5.Text = "Contraseña";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(336, 401);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 13;
            label2.Text = "Mail";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(315, 301);
            label7.Name = "label7";
            label7.Size = new Size(96, 21);
            label7.TabIndex = 15;
            label7.Text = "Contraseña";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(70, 71);
            button1.TabIndex = 16;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(713, 648);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(txtConfirmarContraseña);
            Controls.Add(btnRegistrarseRegistro);
            Controls.Add(txtMailRegistro);
            Controls.Add(txtContraseñaRegistro);
            Controls.Add(txtUserRegistro);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "Registro";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUserRegistro;
        private Label label1;
        private TextBox txtContraseñaRegistro;
        private TextBox txtMailRegistro;
        private Button btnRegistrarseRegistro;
        private TextBox txtConfirmarContraseña;
        private Label label5;
        private Label label2;
        private Label label7;
        private Button button1;
    }
}