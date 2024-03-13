namespace FormPrimosMorse
{
    partial class Principal
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
            btnMorse = new Button();
            btnPrimo = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnMorse
            // 
            btnMorse.Location = new Point(73, 257);
            btnMorse.Name = "btnMorse";
            btnMorse.Size = new Size(224, 88);
            btnMorse.TabIndex = 0;
            btnMorse.Text = "CODIGO MORSE";
            btnMorse.UseVisualStyleBackColor = true;
            btnMorse.Click += btnMorse_Click;
            // 
            // btnPrimo
            // 
            btnPrimo.Location = new Point(73, 122);
            btnPrimo.Name = "btnPrimo";
            btnPrimo.Size = new Size(224, 88);
            btnPrimo.TabIndex = 1;
            btnPrimo.Text = "¿ES UN NUMERO PRIMO?";
            btnPrimo.UseVisualStyleBackColor = true;
            btnPrimo.Click += btnPrimo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(283, 402);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(76, 25);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnPrimo);
            Controls.Add(btnMorse);
            Name = "Principal";
            Text = "Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMorse;
        private Button btnPrimo;
        private Button btnSalir;
    }
}