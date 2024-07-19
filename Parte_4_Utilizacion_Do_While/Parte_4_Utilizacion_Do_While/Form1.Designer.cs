namespace Parte_4_Utilizacion_Do_While
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
            txtNumero = new TextBox();
            lblReves = new Label();
            txtReves = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(33, 50);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(33, 68);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(282, 23);
            txtNumero.TabIndex = 1;
            // 
            // lblReves
            // 
            lblReves.AutoSize = true;
            lblReves.Location = new Point(33, 147);
            lblReves.Name = "lblReves";
            lblReves.Size = new Size(48, 15);
            lblReves.TabIndex = 2;
            lblReves.Text = "Al reves";
            // 
            // txtReves
            // 
            txtReves.Location = new Point(33, 165);
            txtReves.Name = "txtReves";
            txtReves.Size = new Size(282, 23);
            txtReves.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(33, 225);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(119, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "&Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(196, 225);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(119, 23);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 300);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtReves);
            Controls.Add(lblReves);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Name = "Form1";
            Text = "Mostrar un numero al reves";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblReves;
        private TextBox txtReves;
        private Button btnCalcular;
        private Button btnLimpiar;
    }
}
