namespace Parte_2_Utilizando_For
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
            lblNumero = new Label();
            lblFactorial = new Label();
            txtNumero = new TextBox();
            txtFactorial = new TextBox();
            btnCalcular = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(41, 30);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero";
            // 
            // lblFactorial
            // 
            lblFactorial.AutoSize = true;
            lblFactorial.Location = new Point(221, 30);
            lblFactorial.Name = "lblFactorial";
            lblFactorial.Size = new Size(52, 15);
            lblFactorial.TabIndex = 1;
            lblFactorial.Text = "Factorial";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(12, 60);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 2;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // txtFactorial
            // 
            txtFactorial.Location = new Point(192, 60);
            txtFactorial.Name = "txtFactorial";
            txtFactorial.Size = new Size(100, 23);
            txtFactorial.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(27, 110);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(71, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "&Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(210, 110);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(71, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 257);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Controls.Add(txtFactorial);
            Controls.Add(txtNumero);
            Controls.Add(lblFactorial);
            Controls.Add(lblNumero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblFactorial;
        private TextBox txtNumero;
        private TextBox txtFactorial;
        private Button btnCalcular;
        private Button btnSalir;
    }
}
