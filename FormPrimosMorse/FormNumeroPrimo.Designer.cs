namespace FormPrimosMorse
{
    partial class FormNumeroPrimo
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
            label1 = new Label();
            txtIngreso = new TextBox();
            btnComprobar = new Button();
            panel1 = new Panel();
            labelResultado = new Label();
            panel2 = new Panel();
            labelLista = new Label();
            btnVolver = new Button();
            labelTexto = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 65);
            label1.Name = "label1";
            label1.Size = new Size(250, 15);
            label1.TabIndex = 0;
            label1.Text = "INGRESAR UN NUMERO ENTERO DEL 1 AL 100";
            // 
            // txtIngreso
            // 
            txtIngreso.Location = new Point(325, 83);
            txtIngreso.Name = "txtIngreso";
            txtIngreso.Size = new Size(100, 23);
            txtIngreso.TabIndex = 1;
            txtIngreso.TextChanged += textIngreso_TextChanged;
            // 
            // btnComprobar
            // 
            btnComprobar.Location = new Point(325, 112);
            btnComprobar.Name = "btnComprobar";
            btnComprobar.Size = new Size(99, 23);
            btnComprobar.TabIndex = 2;
            btnComprobar.Text = "Comprobar";
            btnComprobar.UseVisualStyleBackColor = true;
            btnComprobar.Click += btnComprobar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(labelResultado);
            panel1.Location = new Point(272, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 52);
            panel1.TabIndex = 3;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(33, 15);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(labelLista);
            panel2.Location = new Point(59, 235);
            panel2.Name = "panel2";
            panel2.Size = new Size(625, 110);
            panel2.TabIndex = 4;
            // 
            // labelLista
            // 
            labelLista.AutoSize = true;
            labelLista.Location = new Point(29, 16);
            labelLista.Name = "labelLista";
            labelLista.Size = new Size(0, 15);
            labelLista.TabIndex = 1;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(672, 394);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(93, 27);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // labelTexto
            // 
            labelTexto.AutoSize = true;
            labelTexto.Location = new Point(83, 208);
            labelTexto.Name = "labelTexto";
            labelTexto.Size = new Size(0, 15);
            labelTexto.TabIndex = 6;
            // 
            // FormNumeroPrimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTexto);
            Controls.Add(btnVolver);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnComprobar);
            Controls.Add(txtIngreso);
            Controls.Add(label1);
            Name = "FormNumeroPrimo";
            Text = "FormNumeroPrimo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIngreso;
        private Button btnComprobar;
        private Panel panel1;
        private Label labelResultado;
        private Panel panel2;
        private Label labelLista;
        private Button btnVolver;
        private Label labelTexto;
    }
}