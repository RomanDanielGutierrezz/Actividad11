namespace EJ3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtValores = new TextBox();
            btoResult = new Button();
            lbPromedio = new Label();
            lbRegistro = new Label();
            btoRegistrar = new Button();
            txtRegistro = new TextBox();
            SuspendLayout();
            // 
            // txtValores
            // 
            txtValores.Location = new Point(56, 216);
            txtValores.Multiline = true;
            txtValores.Name = "txtValores";
            txtValores.Size = new Size(316, 128);
            txtValores.TabIndex = 11;
            // 
            // btoResult
            // 
            btoResult.Location = new Point(265, 131);
            btoResult.Name = "btoResult";
            btoResult.Size = new Size(122, 68);
            btoResult.TabIndex = 10;
            btoResult.Text = "Calcular Promedio";
            btoResult.UseVisualStyleBackColor = true;
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.Location = new Point(80, 158);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(69, 15);
            lbPromedio.TabIndex = 9;
            lbPromedio.Text = "lbPromedio";
            // 
            // lbRegistro
            // 
            lbRegistro.AutoSize = true;
            lbRegistro.Location = new Point(25, 44);
            lbRegistro.Name = "lbRegistro";
            lbRegistro.Size = new Size(83, 15);
            lbRegistro.TabIndex = 8;
            lbRegistro.Text = "Indicar Valores";
            // 
            // btoRegistrar
            // 
            btoRegistrar.Location = new Point(265, 17);
            btoRegistrar.Name = "btoRegistrar";
            btoRegistrar.Size = new Size(122, 68);
            btoRegistrar.TabIndex = 7;
            btoRegistrar.Text = "Registrar";
            btoRegistrar.UseVisualStyleBackColor = true;
            btoRegistrar.Click += btoRegistrar_Click;
            // 
            // txtRegistro
            // 
            txtRegistro.Location = new Point(114, 41);
            txtRegistro.Name = "txtRegistro";
            txtRegistro.Size = new Size(122, 23);
            txtRegistro.TabIndex = 6;
            txtRegistro.TextChanged += txtRegistro_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 366);
            Controls.Add(txtValores);
            Controls.Add(btoResult);
            Controls.Add(lbPromedio);
            Controls.Add(lbRegistro);
            Controls.Add(btoRegistrar);
            Controls.Add(txtRegistro);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValores;
        private Button btoResult;
        private Label lbPromedio;
        private Label lbRegistro;
        private Button btoRegistrar;
        private TextBox txtRegistro;
    }
}
