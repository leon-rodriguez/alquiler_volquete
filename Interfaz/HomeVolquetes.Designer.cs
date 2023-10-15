namespace Interfaz
{
    partial class HomeVolquetes
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
            panelMenuLateral = new Panel();
            panelCuentaSubmenu = new Panel();
            btnAdministrarUsuarios = new Button();
            btnContacto = new Button();
            btnAlquileresUsuario = new Button();
            btnCuenta = new Button();
            panelVolquetesSubmenu = new Panel();
            btnAñadirVolquete = new Button();
            btnVerVolquetesResiduos = new Button();
            btnVerConstruccion = new Button();
            btnVolquetes = new Button();
            panelLogo = new Panel();
            panelMenuLateral.SuspendLayout();
            panelCuentaSubmenu.SuspendLayout();
            panelVolquetesSubmenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.AutoScroll = true;
            panelMenuLateral.BackColor = Color.Black;
            panelMenuLateral.Controls.Add(panelCuentaSubmenu);
            panelMenuLateral.Controls.Add(btnCuenta);
            panelMenuLateral.Controls.Add(panelVolquetesSubmenu);
            panelMenuLateral.Controls.Add(btnVolquetes);
            panelMenuLateral.Controls.Add(panelLogo);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(250, 713);
            panelMenuLateral.TabIndex = 0;
            // 
            // panelCuentaSubmenu
            // 
            panelCuentaSubmenu.BackColor = Color.DimGray;
            panelCuentaSubmenu.Controls.Add(btnAdministrarUsuarios);
            panelCuentaSubmenu.Controls.Add(btnContacto);
            panelCuentaSubmenu.Controls.Add(btnAlquileresUsuario);
            panelCuentaSubmenu.Dock = DockStyle.Top;
            panelCuentaSubmenu.Location = new Point(0, 334);
            panelCuentaSubmenu.Name = "panelCuentaSubmenu";
            panelCuentaSubmenu.Size = new Size(250, 134);
            panelCuentaSubmenu.TabIndex = 5;
            // 
            // btnAdministrarUsuarios
            // 
            btnAdministrarUsuarios.BackColor = Color.FromArgb(64, 64, 64);
            btnAdministrarUsuarios.Dock = DockStyle.Top;
            btnAdministrarUsuarios.FlatAppearance.BorderColor = Color.White;
            btnAdministrarUsuarios.FlatAppearance.BorderSize = 0;
            btnAdministrarUsuarios.FlatStyle = FlatStyle.Flat;
            btnAdministrarUsuarios.ForeColor = Color.White;
            btnAdministrarUsuarios.Location = new Point(0, 90);
            btnAdministrarUsuarios.Name = "btnAdministrarUsuarios";
            btnAdministrarUsuarios.Size = new Size(250, 45);
            btnAdministrarUsuarios.TabIndex = 5;
            btnAdministrarUsuarios.Text = "Administrar usuarios";
            btnAdministrarUsuarios.UseVisualStyleBackColor = false;
            btnAdministrarUsuarios.Click += btnAdministrarUsuarios_Click;
            // 
            // btnContacto
            // 
            btnContacto.BackColor = Color.FromArgb(64, 64, 64);
            btnContacto.Dock = DockStyle.Top;
            btnContacto.FlatAppearance.BorderColor = Color.White;
            btnContacto.FlatAppearance.BorderSize = 0;
            btnContacto.FlatStyle = FlatStyle.Flat;
            btnContacto.ForeColor = Color.White;
            btnContacto.Location = new Point(0, 45);
            btnContacto.Name = "btnContacto";
            btnContacto.Size = new Size(250, 45);
            btnContacto.TabIndex = 4;
            btnContacto.Text = "Contactanos";
            btnContacto.UseVisualStyleBackColor = false;
            // 
            // btnAlquileresUsuario
            // 
            btnAlquileresUsuario.BackColor = Color.FromArgb(64, 64, 64);
            btnAlquileresUsuario.Dock = DockStyle.Top;
            btnAlquileresUsuario.FlatAppearance.BorderColor = Color.White;
            btnAlquileresUsuario.FlatAppearance.BorderSize = 0;
            btnAlquileresUsuario.FlatStyle = FlatStyle.Flat;
            btnAlquileresUsuario.ForeColor = Color.White;
            btnAlquileresUsuario.Location = new Point(0, 0);
            btnAlquileresUsuario.Name = "btnAlquileresUsuario";
            btnAlquileresUsuario.Size = new Size(250, 45);
            btnAlquileresUsuario.TabIndex = 3;
            btnAlquileresUsuario.Text = "Tus alquileres";
            btnAlquileresUsuario.UseVisualStyleBackColor = false;
            btnAlquileresUsuario.Click += btnAlquileresUsuario_Click;
            // 
            // btnCuenta
            // 
            btnCuenta.Dock = DockStyle.Top;
            btnCuenta.FlatAppearance.BorderSize = 0;
            btnCuenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnCuenta.FlatStyle = FlatStyle.Flat;
            btnCuenta.ForeColor = Color.White;
            btnCuenta.Location = new Point(0, 284);
            btnCuenta.Name = "btnCuenta";
            btnCuenta.Size = new Size(250, 50);
            btnCuenta.TabIndex = 4;
            btnCuenta.Text = "Cuenta";
            btnCuenta.UseVisualStyleBackColor = true;
            btnCuenta.Click += btnCuenta_Click;
            // 
            // panelVolquetesSubmenu
            // 
            panelVolquetesSubmenu.BackColor = Color.DimGray;
            panelVolquetesSubmenu.Controls.Add(btnAñadirVolquete);
            panelVolquetesSubmenu.Controls.Add(btnVerVolquetesResiduos);
            panelVolquetesSubmenu.Controls.Add(btnVerConstruccion);
            panelVolquetesSubmenu.Dock = DockStyle.Top;
            panelVolquetesSubmenu.Location = new Point(0, 150);
            panelVolquetesSubmenu.Name = "panelVolquetesSubmenu";
            panelVolquetesSubmenu.Size = new Size(250, 134);
            panelVolquetesSubmenu.TabIndex = 3;
            // 
            // btnAñadirVolquete
            // 
            btnAñadirVolquete.BackColor = Color.FromArgb(64, 64, 64);
            btnAñadirVolquete.Dock = DockStyle.Top;
            btnAñadirVolquete.FlatAppearance.BorderColor = Color.White;
            btnAñadirVolquete.FlatAppearance.BorderSize = 0;
            btnAñadirVolquete.FlatStyle = FlatStyle.Flat;
            btnAñadirVolquete.ForeColor = Color.White;
            btnAñadirVolquete.Location = new Point(0, 90);
            btnAñadirVolquete.Name = "btnAñadirVolquete";
            btnAñadirVolquete.Size = new Size(250, 44);
            btnAñadirVolquete.TabIndex = 5;
            btnAñadirVolquete.Text = "Añadir stock";
            btnAñadirVolquete.UseVisualStyleBackColor = false;
            btnAñadirVolquete.Click += btnAñadirVolquete_Click;
            // 
            // btnVerVolquetesResiduos
            // 
            btnVerVolquetesResiduos.BackColor = Color.FromArgb(64, 64, 64);
            btnVerVolquetesResiduos.Dock = DockStyle.Top;
            btnVerVolquetesResiduos.FlatAppearance.BorderColor = Color.White;
            btnVerVolquetesResiduos.FlatAppearance.BorderSize = 0;
            btnVerVolquetesResiduos.FlatStyle = FlatStyle.Flat;
            btnVerVolquetesResiduos.ForeColor = Color.White;
            btnVerVolquetesResiduos.Location = new Point(0, 45);
            btnVerVolquetesResiduos.Name = "btnVerVolquetesResiduos";
            btnVerVolquetesResiduos.Size = new Size(250, 45);
            btnVerVolquetesResiduos.TabIndex = 4;
            btnVerVolquetesResiduos.Text = "Volquetes residuos";
            btnVerVolquetesResiduos.UseVisualStyleBackColor = false;
            btnVerVolquetesResiduos.Click += btnVerVolquetesResiduos_Click;
            // 
            // btnVerConstruccion
            // 
            btnVerConstruccion.BackColor = Color.FromArgb(64, 64, 64);
            btnVerConstruccion.Dock = DockStyle.Top;
            btnVerConstruccion.FlatAppearance.BorderColor = Color.White;
            btnVerConstruccion.FlatAppearance.BorderSize = 0;
            btnVerConstruccion.FlatStyle = FlatStyle.Flat;
            btnVerConstruccion.ForeColor = Color.White;
            btnVerConstruccion.Location = new Point(0, 0);
            btnVerConstruccion.Name = "btnVerConstruccion";
            btnVerConstruccion.Size = new Size(250, 45);
            btnVerConstruccion.TabIndex = 3;
            btnVerConstruccion.Text = "Volquetes contruccion";
            btnVerConstruccion.UseVisualStyleBackColor = false;
            btnVerConstruccion.Click += btnVerConstruccion_Click;
            // 
            // btnVolquetes
            // 
            btnVolquetes.Dock = DockStyle.Top;
            btnVolquetes.FlatAppearance.BorderSize = 0;
            btnVolquetes.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnVolquetes.FlatStyle = FlatStyle.Flat;
            btnVolquetes.ForeColor = Color.White;
            btnVolquetes.Location = new Point(0, 100);
            btnVolquetes.Name = "btnVolquetes";
            btnVolquetes.Size = new Size(250, 50);
            btnVolquetes.TabIndex = 2;
            btnVolquetes.Text = "Volquetes";
            btnVolquetes.UseVisualStyleBackColor = true;
            btnVolquetes.Click += btnVolquetes_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.IndianRed;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 100);
            panelLogo.TabIndex = 1;
            // 
            // HomeVolquetes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1218, 713);
            Controls.Add(panelMenuLateral);
            IsMdiContainer = true;
            Name = "HomeVolquetes";
            Text = "HomeVolquetes";
            panelMenuLateral.ResumeLayout(false);
            panelCuentaSubmenu.ResumeLayout(false);
            panelVolquetesSubmenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenuLateral;
        private Button btnVolquetes;
        private Panel panelLogo;
        private Panel panelVolquetesSubmenu;
        private Button btnVerConstruccion;
        private Button btnAñadirVolquete;
        private Button btnVerVolquetesResiduos;
        private Panel panelCuentaSubmenu;
        private Button btnAdministrarUsuarios;
        private Button btnContacto;
        private Button btnAlquileresUsuario;
        private Button btnCuenta;
    }
}