namespace Interfaz
{
    partial class PrimeraPantallaVolquetes
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
            panelFoto = new Panel();
            panel3 = new Panel();
            btnVerConstruccion = new Button();
            panel2 = new Panel();
            labelTitulo1 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            btnVerResiduos = new Button();
            panel7 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panelFoto);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(107, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 415);
            panel1.TabIndex = 0;
            // 
            // panelFoto
            // 
            panelFoto.BackgroundImage = Properties.Resources.volquete_construccion;
            panelFoto.BackgroundImageLayout = ImageLayout.Stretch;
            panelFoto.Dock = DockStyle.Fill;
            panelFoto.Location = new Point(0, 75);
            panelFoto.Name = "panelFoto";
            panelFoto.Size = new Size(334, 263);
            panelFoto.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnVerConstruccion);
            panel3.Dock = DockStyle.Bottom;
            panel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel3.Location = new Point(0, 338);
            panel3.Name = "panel3";
            panel3.Size = new Size(334, 77);
            panel3.TabIndex = 1;
            // 
            // btnVerConstruccion
            // 
            btnVerConstruccion.BackColor = Color.White;
            btnVerConstruccion.Cursor = Cursors.Hand;
            btnVerConstruccion.FlatAppearance.MouseOverBackColor = Color.Black;
            btnVerConstruccion.FlatStyle = FlatStyle.Flat;
            btnVerConstruccion.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerConstruccion.ForeColor = Color.FromArgb(128, 128, 255);
            btnVerConstruccion.Location = new Point(79, 17);
            btnVerConstruccion.Name = "btnVerConstruccion";
            btnVerConstruccion.Size = new Size(171, 45);
            btnVerConstruccion.TabIndex = 0;
            btnVerConstruccion.Text = "Alquilar";
            btnVerConstruccion.UseVisualStyleBackColor = false;
            btnVerConstruccion.Click += btnVerConstruccion_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(labelTitulo1);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.FromArgb(128, 128, 255);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 75);
            panel2.TabIndex = 0;
            // 
            // labelTitulo1
            // 
            labelTitulo1.Anchor = AnchorStyles.None;
            labelTitulo1.AutoSize = true;
            labelTitulo1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo1.Location = new Point(79, 19);
            labelTitulo1.Name = "labelTitulo1";
            labelTitulo1.Size = new Size(184, 37);
            labelTitulo1.TabIndex = 0;
            labelTitulo1.Text = "Construccion";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel7);
            panel4.Location = new Point(518, 130);
            panel4.Name = "panel4";
            panel4.Size = new Size(334, 415);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.volquete_residuos;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 75);
            panel5.Name = "panel5";
            panel5.Size = new Size(334, 263);
            panel5.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnVerResiduos);
            panel6.Dock = DockStyle.Bottom;
            panel6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel6.Location = new Point(0, 338);
            panel6.Name = "panel6";
            panel6.Size = new Size(334, 77);
            panel6.TabIndex = 1;
            // 
            // btnVerResiduos
            // 
            btnVerResiduos.BackColor = Color.White;
            btnVerResiduos.Cursor = Cursors.Hand;
            btnVerResiduos.FlatAppearance.MouseOverBackColor = Color.Black;
            btnVerResiduos.FlatStyle = FlatStyle.Flat;
            btnVerResiduos.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerResiduos.ForeColor = Color.FromArgb(128, 128, 255);
            btnVerResiduos.Location = new Point(79, 17);
            btnVerResiduos.Name = "btnVerResiduos";
            btnVerResiduos.Size = new Size(171, 45);
            btnVerResiduos.TabIndex = 0;
            btnVerResiduos.Text = "Alquilar";
            btnVerResiduos.UseVisualStyleBackColor = false;
            btnVerResiduos.Click += btnVerResiduos_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label1);
            panel7.Dock = DockStyle.Top;
            panel7.ForeColor = Color.FromArgb(128, 128, 255);
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(334, 75);
            panel7.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(108, 19);
            label1.Name = "label1";
            label1.Size = new Size(131, 37);
            label1.TabIndex = 0;
            label1.Text = "Residuos";
            // 
            // PrimeraPantallaVolquetes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(960, 707);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PrimeraPantallaVolquetes";
            Text = "PrimeraPantallaVolquetes";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label labelTitulo1;
        private Panel panel3;
        private Button btnVerConstruccion;
        private Panel panelFoto;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button btnVerResiduos;
        private Panel panel7;
        private Label label1;
    }
}