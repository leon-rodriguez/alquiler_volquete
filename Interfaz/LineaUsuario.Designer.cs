namespace Interfaz
{
    partial class LineaUsuario
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
            panel1 = new Panel();
            lblUsuario = new Label();
            label1 = new Label();
            panel2 = new Panel();
            lblContraseña = new Label();
            label4 = new Label();
            panel3 = new Panel();
            lblMail = new Label();
            label6 = new Label();
            panel4 = new Panel();
            btnCambiarRol = new Button();
            lblRol = new Label();
            label8 = new Label();
            btnEliminarUsuario = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 105);
            panel1.TabIndex = 0;
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(0, 49);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(197, 56);
            lblUsuario.TabIndex = 1;
            lblUsuario.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 34);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(lblContraseña);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 105);
            panel2.TabIndex = 1;
            // 
            // lblContraseña
            // 
            lblContraseña.BackColor = Color.Transparent;
            lblContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseña.Location = new Point(0, 49);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(197, 56);
            lblContraseña.TabIndex = 1;
            lblContraseña.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(200, 34);
            label4.TabIndex = 0;
            label4.Text = "Contraseña";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(lblMail);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(400, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 105);
            panel3.TabIndex = 2;
            // 
            // lblMail
            // 
            lblMail.BackColor = Color.Transparent;
            lblMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMail.Location = new Point(0, 49);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(197, 56);
            lblMail.TabIndex = 1;
            lblMail.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(200, 34);
            label6.TabIndex = 0;
            label6.Text = "Mail";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(btnCambiarRol);
            panel4.Controls.Add(lblRol);
            panel4.Controls.Add(label8);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(600, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 105);
            panel4.TabIndex = 3;
            // 
            // btnCambiarRol
            // 
            btnCambiarRol.BackColor = Color.White;
            btnCambiarRol.Cursor = Cursors.Hand;
            btnCambiarRol.FlatAppearance.MouseOverBackColor = Color.Black;
            btnCambiarRol.FlatStyle = FlatStyle.Flat;
            btnCambiarRol.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCambiarRol.ForeColor = Color.FromArgb(128, 128, 255);
            btnCambiarRol.Location = new Point(34, 65);
            btnCambiarRol.Name = "btnCambiarRol";
            btnCambiarRol.Size = new Size(125, 28);
            btnCambiarRol.TabIndex = 2;
            btnCambiarRol.Text = "Cambiar";
            btnCambiarRol.TextAlign = ContentAlignment.TopCenter;
            btnCambiarRol.UseVisualStyleBackColor = false;
            btnCambiarRol.Click += btnCambiarRol_Click;
            // 
            // lblRol
            // 
            lblRol.BackColor = Color.Transparent;
            lblRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRol.Location = new Point(0, 40);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(197, 22);
            lblRol.TabIndex = 1;
            lblRol.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(200, 34);
            label8.TabIndex = 0;
            label8.Text = "Rol";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.BackColor = Color.White;
            btnEliminarUsuario.Cursor = Cursors.Hand;
            btnEliminarUsuario.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            btnEliminarUsuario.FlatStyle = FlatStyle.Flat;
            btnEliminarUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarUsuario.ForeColor = Color.Red;
            btnEliminarUsuario.Location = new Point(816, 25);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(128, 48);
            btnEliminarUsuario.TabIndex = 4;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // LineaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(956, 105);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LineaUsuario";
            Text = "LineaUsuario";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblUsuario;
        private Panel panel2;
        private Label lblContraseña;
        private Label label4;
        private Panel panel3;
        private Label lblMail;
        private Label label6;
        private Panel panel4;
        private Label lblRol;
        private Label label8;
        private Button btnEliminarUsuario;
        private Button btnCambiarRol;
    }
}