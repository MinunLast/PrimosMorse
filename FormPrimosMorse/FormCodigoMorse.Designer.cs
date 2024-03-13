namespace FormPrimosMorse
{
    partial class FormCodigoMorse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCodigoMorse));
            txtBoxTransformado = new RichTextBox();
            richTextBox1 = new RichTextBox();
            btnCerrar = new Button();
            btnTraducir = new Button();
            panel1 = new Panel();
            labelTransformado = new Label();
            label1 = new Label();
            labelEnQue = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBoxTransformado
            // 
            txtBoxTransformado.Location = new Point(12, 58);
            txtBoxTransformado.Name = "txtBoxTransformado";
            txtBoxTransformado.Size = new Size(532, 132);
            txtBoxTransformado.TabIndex = 0;
            txtBoxTransformado.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(550, 58);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(238, 320);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(688, 400);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(92, 26);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnTraducir
            // 
            btnTraducir.Location = new Point(452, 196);
            btnTraducir.Name = "btnTraducir";
            btnTraducir.Size = new Size(92, 26);
            btnTraducir.TabIndex = 4;
            btnTraducir.Text = "Traducir";
            btnTraducir.UseVisualStyleBackColor = true;
            btnTraducir.Click += btnTraducir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(labelTransformado);
            panel1.Location = new Point(12, 235);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 143);
            panel1.TabIndex = 5;
            // 
            // labelTransformado
            // 
            labelTransformado.AutoSize = true;
            labelTransformado.Location = new Point(3, 11);
            labelTransformado.Name = "labelTransformado";
            labelTransformado.Size = new Size(0, 15);
            labelTransformado.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 24);
            label1.Name = "label1";
            label1.Size = new Size(272, 15);
            label1.TabIndex = 6;
            label1.Text = "ESCRIBIR EL TEXTO QUE DE DESEA TRANSFORMAR";
            // 
            // labelEnQue
            // 
            labelEnQue.AutoSize = true;
            labelEnQue.Location = new Point(15, 217);
            labelEnQue.Name = "labelEnQue";
            labelEnQue.Size = new Size(0, 15);
            labelEnQue.TabIndex = 7;
            // 
            // FormCodigoMorse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelEnQue);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnTraducir);
            Controls.Add(btnCerrar);
            Controls.Add(richTextBox1);
            Controls.Add(txtBoxTransformado);
            Name = "FormCodigoMorse";
            Text = "FormCodigoMorse";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtBoxTransformado;
        private RichTextBox richTextBox1;
        private Button btnCerrar;
        private Button btnTraducir;
        private Panel panel1;
        private Label labelTransformado;
        private Label label1;
        private Label labelEnQue;
    }
}