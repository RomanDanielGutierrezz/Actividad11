namespace EJ4
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
            btoOrdenar = new Button();
            SuspendLayout();
            // 
            // txtValores
            // 
            txtValores.Location = new Point(12, 195);
            txtValores.Multiline = true;
            txtValores.Name = "txtValores";
            txtValores.Size = new Size(316, 128);
            txtValores.TabIndex = 17;
            // 
            // btoResult
            // 
            btoResult.Location = new Point(314, 100);
            btoResult.Name = "btoResult";
            btoResult.Size = new Size(122, 68);
            btoResult.TabIndex = 16;
            btoResult.Text = "Calcular Promedio";
            btoResult.UseVisualStyleBackColor = true;
            btoResult.Click += btoResult_Click;
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.Location = new Point(125, 127);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(69, 15);
            lbPromedio.TabIndex = 15;
            lbPromedio.Text = "lbPromedio";
            // 
            // lbRegistro
            // 
            lbRegistro.AutoSize = true;
            lbRegistro.Location = new Point(60, 39);
            lbRegistro.Name = "lbRegistro";
            lbRegistro.Size = new Size(83, 15);
            lbRegistro.TabIndex = 14;
            lbRegistro.Text = "Indicar Valores";
            // 
            // btoRegistrar
            // 
            btoRegistrar.Location = new Point(314, 12);
            btoRegistrar.Name = "btoRegistrar";
            btoRegistrar.Size = new Size(122, 68);
            btoRegistrar.TabIndex = 13;
            btoRegistrar.Text = "Registrar";
            btoRegistrar.UseVisualStyleBackColor = true;
            btoRegistrar.Click += btoRegistrar_Click;
            // 
            // txtRegistro
            // 
            txtRegistro.Location = new Point(149, 36);
            txtRegistro.Name = "txtRegistro";
            txtRegistro.Size = new Size(122, 23);
            txtRegistro.TabIndex = 12;
            // 
            // btoOrdenar
            // 
            btoOrdenar.Location = new Point(361, 195);
            btoOrdenar.Name = "btoOrdenar";
            btoOrdenar.Size = new Size(75, 79);
            btoOrdenar.TabIndex = 18;
            btoOrdenar.Text = "Ordenar";
            btoOrdenar.UseVisualStyleBackColor = true;
            btoOrdenar.Click += btoOrdenar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 331);
            Controls.Add(btoOrdenar);
            Controls.Add(txtValores);
            Controls.Add(btoResult);
            Controls.Add(lbPromedio);
            Controls.Add(lbRegistro);
            Controls.Add(btoRegistrar);
            Controls.Add(txtRegistro);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
        private Button btoOrdenar;
    }
}
