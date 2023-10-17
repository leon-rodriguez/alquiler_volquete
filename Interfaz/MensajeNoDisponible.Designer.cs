namespace Interfaz
{
    partial class MensajeNoDisponible
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
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblMensaje.Location = new Point(2, -1);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(558, 125);
            lblMensaje.TabIndex = 0;
            // 
            // MensajeNoDisponible
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 131);
            Controls.Add(lblMensaje);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MensajeNoDisponible";
            Text = "MensajeNoDisponible";
            ResumeLayout(false);
        }

        #endregion

        private Label lblMensaje;
    }
}