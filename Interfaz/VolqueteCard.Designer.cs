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
            pnlContainer = new Panel();
            btnReservar = new Button();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            lblCapacidad = new Label();
            label3 = new Label();
            label2 = new Label();
            lblTipo = new Label();
            pnlContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.White;
            pnlContainer.Controls.Add(btnReservar);
            pnlContainer.Controls.Add(lblDescripcion);
            pnlContainer.Controls.Add(lblPrecio);
            pnlContainer.Controls.Add(lblCapacidad);
            pnlContainer.Controls.Add(label3);
            pnlContainer.Controls.Add(label2);
            pnlContainer.Controls.Add(lblTipo);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(311, 321);
            pnlContainer.TabIndex = 13;
            // 
            // btnReservar
            // 
            btnReservar.BackColor = Color.White;
            btnReservar.Cursor = Cursors.Hand;
            btnReservar.FlatAppearance.MouseOverBackColor = Color.Black;
            btnReservar.FlatStyle = FlatStyle.Flat;
            btnReservar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnReservar.ForeColor = Color.FromArgb(128, 128, 255);
            btnReservar.Location = new Point(73, 268);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(141, 41);
            btnReservar.TabIndex = 21;
            btnReservar.Text = "Reservar";
            btnReservar.UseVisualStyleBackColor = false;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Location = new Point(62, 143);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(197, 101);
            lblDescripcion.TabIndex = 19;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.ForeColor = Color.FromArgb(64, 64, 64);
            lblPrecio.Location = new Point(180, 69);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(0, 25);
            lblPrecio.TabIndex = 18;
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblCapacidad.ForeColor = Color.FromArgb(64, 64, 64);
            lblCapacidad.Location = new Point(180, 103);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(0, 25);
            lblCapacidad.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(62, 69);
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
            label2.Location = new Point(62, 103);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 15;
            label2.Text = "Capacidad:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.ForeColor = Color.Black;
            lblTipo.Location = new Point(73, 22);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(0, 28);
            lblTipo.TabIndex = 14;
            // 
            // VolqueteCard
            // 
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(311, 321);
            Controls.Add(pnlContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VolqueteCard";
            Text = "VolqueteCard";
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Label lblPrecio;
        private Label lblCapacidad;
        private Label label3;
        private Label label2;
        private Label lblTipo;
        private Label lblDescripcion;
        private Button btnReservar;
    }
}