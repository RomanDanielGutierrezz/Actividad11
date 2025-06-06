namespace EJ2
{
    partial class Promedios
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
            txtRegistro = new TextBox();
            btoRegistrar = new Button();
            lbRegistro = new Label();
            lbPromedio = new Label();
            btoResult = new Button();
            txtValores = new TextBox();
            SuspendLayout();
            // 
            // txtRegistro
            // 
            txtRegistro.Location = new Point(101, 53);
            txtRegistro.Name = "txtRegistro";
            txtRegistro.Size = new Size(122, 23);
            txtRegistro.TabIndex = 0;
            // 
            // btoRegistrar
            // 
            btoRegistrar.Location = new Point(252, 29);
            btoRegistrar.Name = "btoRegistrar";
            btoRegistrar.Size = new Size(122, 68);
            btoRegistrar.TabIndex = 1;
            btoRegistrar.Text = "Registrar";
            btoRegistrar.UseVisualStyleBackColor = true;
            btoRegistrar.Click += btoRegistrar_Click;
            // 
            // lbRegistro
            // 
            lbRegistro.AutoSize = true;
            lbRegistro.Location = new Point(12, 56);
            lbRegistro.Name = "lbRegistro";
            lbRegistro.Size = new Size(83, 15);
            lbRegistro.TabIndex = 2;
            lbRegistro.Text = "Indicar Valores";
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.Location = new Point(67, 170);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(69, 15);
            lbPromedio.TabIndex = 3;
            lbPromedio.Text = "lbPromedio";
            // 
            // btoResult
            // 
            btoResult.Location = new Point(252, 143);
            btoResult.Name = "btoResult";
            btoResult.Size = new Size(122, 68);
            btoResult.TabIndex = 4;
            btoResult.Text = "Calcular Promedio";
            btoResult.UseVisualStyleBackColor = true;
            btoResult.Click += btoResult_Click;
            // 
            // txtValores
            // 
            txtValores.Location = new Point(43, 228);
            txtValores.Multiline = true;
            txtValores.Name = "txtValores";
            txtValores.Size = new Size(316, 128);
            txtValores.TabIndex = 5;
            // 
            // Promedios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(418, 368);
            Controls.Add(txtValores);
            Controls.Add(btoResult);
            Controls.Add(lbPromedio);
            Controls.Add(lbRegistro);
            Controls.Add(btoRegistrar);
            Controls.Add(txtRegistro);
            Name = "Promedios";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRegistro;
        private Button btoRegistrar;
        private Label lbRegistro;
        private Label lbPromedio;
        private Button btoResult;
        private TextBox txtValores;
    }
}
