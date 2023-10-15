namespace Interfaz
{
    partial class VolqueteCard
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
            lblPrecio = new Label();
            lblCapacidad = new Label();
            label3 = new Label();
            label2 = new Label();
            lblTipo = new Label();
            btnReservar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(lblCapacidad);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblTipo);
            panel1.Controls.Add(btnReservar);
            panel1.Dock = DockStyle.Fill;
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 206);
            panel1.TabIndex = 13;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.ForeColor = Color.FromArgb(64, 64, 64);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(22, 25);
            lblPrecio.TabIndex = 18;
            lblPrecio.Text = "a";
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblCapacidad.ForeColor = Color.FromArgb(64, 64, 64);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(22, 25);
            lblCapacidad.TabIndex = 17;
            lblCapacidad.Text = "a";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 16;
            label3.Text = "Precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 15;
            label2.Text = "Capacidad:";
            label2.Click += label2_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.ForeColor = Color.Black;
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(70, 28);
            lblTipo.TabIndex = 14;
            lblTipo.Text = "label1";
            // 
            // btnReservar
            // 
            btnReservar.BackColor = Color.White;
            btnReservar.Cursor = Cursors.Hand;
            btnReservar.FlatAppearance.MouseOverBackColor = Color.Black;
            btnReservar.FlatStyle = FlatStyle.Flat;
            btnReservar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnReservar.ForeColor = Color.FromArgb(128, 128, 255);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(141, 41);
            btnReservar.TabIndex = 13;
            btnReservar.Text = "Reservar";
            btnReservar.UseVisualStyleBackColor = false;
            // 
            // VolqueteCard
            // 
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(281, 206);
            Controls.Add(panel1);
            Name = "VolqueteCard";
            Text = "VolqueteCard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblPrecio;
        private Label lblCapacidad;
        private Label label3;
        private Label label2;
        private Label lblTipo;
        private Button btnReservar;
    }
}