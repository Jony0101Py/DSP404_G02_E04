namespace Parte_1_Ejemplos_De_Ciclos_For_While_Do_While
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            btnSalir = new Button();
            btnIngresar = new Button();
            btnnuevo = new Button();
            txtStock = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtCantidadPersonas = new TextBox();
            txtStockFinal = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnIngresar);
            groupBox1.Controls.Add(btnnuevo);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 119);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese Datos";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(336, 81);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(186, 81);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnnuevo
            // 
            btnnuevo.Location = new Point(16, 81);
            btnnuevo.Name = "btnnuevo";
            btnnuevo.Size = new Size(75, 23);
            btnnuevo.TabIndex = 2;
            btnnuevo.Text = "Nuevo";
            btnnuevo.UseVisualStyleBackColor = true;
            btnnuevo.Click += btnnuevo_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(92, 31);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(198, 23);
            txtStock.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 34);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Stock Inicial";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCantidadPersonas);
            groupBox2.Controls.Add(txtStockFinal);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 163);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(439, 120);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Existencia";
            // 
            // txtCantidadPersonas
            // 
            txtCantidadPersonas.Location = new Point(121, 72);
            txtCantidadPersonas.Name = "txtCantidadPersonas";
            txtCantidadPersonas.Size = new Size(226, 23);
            txtCantidadPersonas.TabIndex = 3;
            // 
            // txtStockFinal
            // 
            txtStockFinal.Location = new Point(121, 29);
            txtStockFinal.Name = "txtStockFinal";
            txtStockFinal.Size = new Size(226, 23);
            txtStockFinal.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 75);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 1;
            label3.Text = "Cantidad Persona";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 32);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 0;
            label2.Text = "Stock";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 295);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Estructura Iterativa While";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Button btnSalir;
        private Button btnIngresar;
        private Button btnnuevo;
        private TextBox txtStock;
        private TextBox txtCantidadPersonas;
        private TextBox txtStockFinal;
        private Label label3;
        private Label label2;
    }
}