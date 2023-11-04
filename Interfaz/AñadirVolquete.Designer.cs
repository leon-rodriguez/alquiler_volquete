namespace Interfaz
{
    partial class AñadirVolquete
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
            panel3 = new Panel();
            panel8 = new Panel();
            btnAñadirVolquete = new Button();
            txtDescripcionVolquete = new TextBox();
            label5 = new Label();
            panel7 = new Panel();
            txtCapacidadVolquete = new TextBox();
            label4 = new Label();
            panel6 = new Panel();
            txtPrecioVolquete = new TextBox();
            label3 = new Label();
            panel5 = new Panel();
            rdbtnResiduo = new RadioButton();
            rdbtnConstruccion = new RadioButton();
            label2 = new Label();
            panel4 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(200, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(560, 707);
            panel3.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(225, 225, 225);
            panel8.Controls.Add(btnAñadirVolquete);
            panel8.Controls.Add(txtDescripcionVolquete);
            panel8.Controls.Add(label5);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 422);
            panel8.Name = "panel8";
            panel8.Size = new Size(560, 285);
            panel8.TabIndex = 4;
            // 
            // btnAñadirVolquete
            // 
            btnAñadirVolquete.Anchor = AnchorStyles.None;
            btnAñadirVolquete.BackColor = Color.Black;
            btnAñadirVolquete.Cursor = Cursors.Hand;
            btnAñadirVolquete.FlatStyle = FlatStyle.Flat;
            btnAñadirVolquete.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnAñadirVolquete.ForeColor = Color.White;
            btnAñadirVolquete.Location = new Point(211, 199);
            btnAñadirVolquete.Name = "btnAñadirVolquete";
            btnAñadirVolquete.Size = new Size(134, 48);
            btnAñadirVolquete.TabIndex = 4;
            btnAñadirVolquete.Text = "Añadir";
            btnAñadirVolquete.UseVisualStyleBackColor = false;
            // 
            // txtDescripcionVolquete
            // 
            txtDescripcionVolquete.Anchor = AnchorStyles.None;
            txtDescripcionVolquete.Location = new Point(177, 85);
            txtDescripcionVolquete.Multiline = true;
            txtDescripcionVolquete.Name = "txtDescripcionVolquete";
            txtDescripcionVolquete.Size = new Size(196, 87);
            txtDescripcionVolquete.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(152, 31);
            label5.Name = "label5";
            label5.Size = new Size(243, 32);
            label5.TabIndex = 1;
            label5.Text = "Descripcion(opcional)";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(225, 225, 225);
            panel7.Controls.Add(txtCapacidadVolquete);
            panel7.Controls.Add(label4);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 325);
            panel7.Name = "panel7";
            panel7.Size = new Size(560, 97);
            panel7.TabIndex = 3;
            // 
            // txtCapacidadVolquete
            // 
            txtCapacidadVolquete.Anchor = AnchorStyles.None;
            txtCapacidadVolquete.Location = new Point(177, 53);
            txtCapacidadVolquete.Name = "txtCapacidadVolquete";
            txtCapacidadVolquete.Size = new Size(196, 23);
            txtCapacidadVolquete.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(211, 6);
            label4.Name = "label4";
            label4.Size = new Size(124, 32);
            label4.TabIndex = 1;
            label4.Text = "Capacidad";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(225, 225, 225);
            panel6.Controls.Add(txtPrecioVolquete);
            panel6.Controls.Add(label3);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 225);
            panel6.Name = "panel6";
            panel6.Size = new Size(560, 100);
            panel6.TabIndex = 2;
            // 
            // txtPrecioVolquete
            // 
            txtPrecioVolquete.Anchor = AnchorStyles.None;
            txtPrecioVolquete.Location = new Point(177, 55);
            txtPrecioVolquete.Name = "txtPrecioVolquete";
            txtPrecioVolquete.Size = new Size(196, 23);
            txtPrecioVolquete.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(233, 8);
            label3.Name = "label3";
            label3.Size = new Size(86, 32);
            label3.TabIndex = 1;
            label3.Text = "Precio ";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(225, 225, 225);
            panel5.Controls.Add(rdbtnResiduo);
            panel5.Controls.Add(rdbtnConstruccion);
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 100);
            panel5.Name = "panel5";
            panel5.Size = new Size(560, 125);
            panel5.TabIndex = 1;
            // 
            // rdbtnResiduo
            // 
            rdbtnResiduo.Anchor = AnchorStyles.None;
            rdbtnResiduo.AutoSize = true;
            rdbtnResiduo.Location = new Point(301, 86);
            rdbtnResiduo.Name = "rdbtnResiduo";
            rdbtnResiduo.Size = new Size(72, 19);
            rdbtnResiduo.TabIndex = 2;
            rdbtnResiduo.Text = "Residuos";
            rdbtnResiduo.UseVisualStyleBackColor = true;
            // 
            // rdbtnConstruccion
            // 
            rdbtnConstruccion.Anchor = AnchorStyles.None;
            rdbtnConstruccion.AutoSize = true;
            rdbtnConstruccion.Checked = true;
            rdbtnConstruccion.Location = new Point(177, 86);
            rdbtnConstruccion.Name = "rdbtnConstruccion";
            rdbtnConstruccion.Size = new Size(96, 19);
            rdbtnConstruccion.TabIndex = 1;
            rdbtnConstruccion.TabStop = true;
            rdbtnConstruccion.Text = "Construccion";
            rdbtnConstruccion.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(177, 12);
            label2.Name = "label2";
            label2.Size = new Size(196, 32);
            label2.TabIndex = 0;
            label2.Text = "Tipo de volquete";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(560, 100);
            panel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(103, 21);
            label1.Name = "label1";
            label1.Size = new Size(360, 54);
            label1.TabIndex = 0;
            label1.Text = "Añade un volquete";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 707);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Dock = DockStyle.Right;
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel2.Location = new Point(760, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 707);
            panel2.TabIndex = 1;
            // 
            // AñadirVolquete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 707);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AñadirVolquete";
            Text = "AñadirVolquete";
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Label label2;
        private Panel panel4;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private RadioButton rdbtnResiduo;
        private RadioButton rdbtnConstruccion;
        private TextBox txtDescripcionVolquete;
        private TextBox txtCapacidadVolquete;
        private TextBox txtPrecioVolquete;
        private Button btnAñadirVolquete;
        private Panel panel1;
        private Panel panel2;
    }
}