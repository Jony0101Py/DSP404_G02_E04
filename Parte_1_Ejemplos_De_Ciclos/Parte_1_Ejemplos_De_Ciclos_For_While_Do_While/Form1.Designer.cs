namespace Parte_1_Ejemplos_De_Ciclos_For_While_Do_While
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
            groupBox1 = new GroupBox();
            btncalcular = new Button();
            btnnuevo = new Button();
            txtnumero = new TextBox();
            lblnumero = new Label();
            groupBox2 = new GroupBox();
            cbodiv = new ComboBox();
            cbomult = new ComboBox();
            cboresta = new ComboBox();
            cbosuma = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btncalcular);
            groupBox1.Controls.Add(btnnuevo);
            groupBox1.Controls.Add(txtnumero);
            groupBox1.Controls.Add(lblnumero);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese datos";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(333, 61);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 3;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // btnnuevo
            // 
            btnnuevo.Location = new Point(333, 22);
            btnnuevo.Name = "btnnuevo";
            btnnuevo.Size = new Size(75, 23);
            btnnuevo.TabIndex = 2;
            btnnuevo.Text = "Nuevo";
            btnnuevo.UseVisualStyleBackColor = true;
            btnnuevo.Click += btnnuevo_Click_1;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(75, 32);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(207, 23);
            txtnumero.TabIndex = 1;
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Location = new Point(6, 35);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(51, 15);
            lblnumero.TabIndex = 0;
            lblnumero.Text = "Numero";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbodiv);
            groupBox2.Controls.Add(cbomult);
            groupBox2.Controls.Add(cboresta);
            groupBox2.Controls.Add(cbosuma);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 142);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(444, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tabla Aritmetica";
            // 
            // cbodiv
            // 
            cbodiv.FormattingEnabled = true;
            cbodiv.Location = new Point(359, 47);
            cbodiv.Name = "cbodiv";
            cbodiv.Size = new Size(63, 23);
            cbodiv.TabIndex = 7;
            // 
            // cbomult
            // 
            cbomult.FormattingEnabled = true;
            cbomult.Location = new Point(235, 47);
            cbomult.Name = "cbomult";
            cbomult.Size = new Size(83, 23);
            cbomult.TabIndex = 6;
            // 
            // cboresta
            // 
            cboresta.FormattingEnabled = true;
            cboresta.Location = new Point(124, 47);
            cboresta.Name = "cboresta";
            cboresta.Size = new Size(71, 23);
            cboresta.TabIndex = 5;
            // 
            // cbosuma
            // 
            cbosuma.FormattingEnabled = true;
            cbosuma.Location = new Point(6, 47);
            cbosuma.Name = "cbosuma";
            cbosuma.Size = new Size(71, 23);
            cbosuma.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(359, 29);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 3;
            label5.Text = "Division";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 29);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 2;
            label4.Text = "Multiplicacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 29);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 1;
            label3.Text = "Restar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 29);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 0;
            label2.Text = "Suma";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 260);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Tabla Aritmetica";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btncalcular;
        private Button btnnuevo;
        private TextBox txtnumero;
        private Label lblnumero;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cbodiv;
        private ComboBox cbomult;
        private ComboBox cboresta;
        private ComboBox cbosuma;
    }
}
