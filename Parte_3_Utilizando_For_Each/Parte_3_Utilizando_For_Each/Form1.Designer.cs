namespace Parte_3_Utilizando_For_Each
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            lbltexto = new Label();
            lblllave = new Label();
            txtLlave = new TextBox();
            txtTexto = new TextBox();
            grOpcion = new GroupBox();
            rdbDesencriptar = new RadioButton();
            rdbEncriptar = new RadioButton();
            btnEncriptar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            lblresultado = new Label();
            txtResultado = new TextBox();
            lbltitulo = new Label();
            grOpcion.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 17);
            label1.Name = "label1";
            label1.Size = new Size(2140, 15);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // lbltexto
            // 
            lbltexto.AutoSize = true;
            lbltexto.Location = new Point(25, 65);
            lbltexto.Name = "lbltexto";
            lbltexto.Size = new Size(217, 15);
            lbltexto.TabIndex = 1;
            lbltexto.Text = "Ingrese el texto a Encriptar/Desencriptar";
            // 
            // lblllave
            // 
            lblllave.AutoSize = true;
            lblllave.Location = new Point(280, 65);
            lblllave.Name = "lblllave";
            lblllave.Size = new Size(175, 15);
            lblllave.TabIndex = 2;
            lblllave.Text = "Llave (Digite un numero entero)";
            // 
            // txtLlave
            // 
            txtLlave.Location = new Point(461, 62);
            txtLlave.Name = "txtLlave";
            txtLlave.Size = new Size(165, 23);
            txtLlave.TabIndex = 3;
            txtLlave.KeyPress += txtLlave_KeyPress;
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(25, 95);
            txtTexto.Multiline = true;
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(601, 91);
            txtTexto.TabIndex = 4;
            // 
            // grOpcion
            // 
            grOpcion.Controls.Add(rdbDesencriptar);
            grOpcion.Controls.Add(rdbEncriptar);
            grOpcion.Location = new Point(25, 201);
            grOpcion.Name = "grOpcion";
            grOpcion.Size = new Size(244, 65);
            grOpcion.TabIndex = 5;
            grOpcion.TabStop = false;
            grOpcion.Text = "Seleccione una opcion";
            // 
            // rdbDesencriptar
            // 
            rdbDesencriptar.AutoSize = true;
            rdbDesencriptar.Location = new Point(129, 27);
            rdbDesencriptar.Name = "rdbDesencriptar";
            rdbDesencriptar.Size = new Size(91, 19);
            rdbDesencriptar.TabIndex = 7;
            rdbDesencriptar.TabStop = true;
            rdbDesencriptar.Text = "Desencriptar";
            rdbDesencriptar.UseVisualStyleBackColor = true;
            rdbDesencriptar.CheckedChanged += rdbDesencriptar_CheckedChanged;
            // 
            // rdbEncriptar
            // 
            rdbEncriptar.AutoSize = true;
            rdbEncriptar.Location = new Point(6, 27);
            rdbEncriptar.Name = "rdbEncriptar";
            rdbEncriptar.Size = new Size(72, 19);
            rdbEncriptar.TabIndex = 6;
            rdbEncriptar.TabStop = true;
            rdbEncriptar.Text = "Encriptar";
            rdbEncriptar.UseVisualStyleBackColor = true;
            rdbEncriptar.CheckedChanged += rdbEncriptar_CheckedChanged;
            // 
            // btnEncriptar
            // 
            btnEncriptar.Location = new Point(478, 201);
            btnEncriptar.Name = "btnEncriptar";
            btnEncriptar.Size = new Size(91, 23);
            btnEncriptar.TabIndex = 6;
            btnEncriptar.Text = "&Encriptar";
            btnEncriptar.UseVisualStyleBackColor = true;
            btnEncriptar.Click += btnEncriptar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(478, 230);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(91, 23);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "&Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(478, 259);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(91, 23);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(25, 280);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(0, 15);
            lblresultado.TabIndex = 9;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(25, 307);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(601, 105);
            txtResultado.TabIndex = 10;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Location = new Point(231, 17);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(181, 15);
            lbltitulo.TabIndex = 11;
            lbltitulo.Text = "Encriptamiento por codigo Cesár";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 448);
            Controls.Add(lbltitulo);
            Controls.Add(txtResultado);
            Controls.Add(lblresultado);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEncriptar);
            Controls.Add(grOpcion);
            Controls.Add(txtTexto);
            Controls.Add(txtLlave);
            Controls.Add(lblllave);
            Controls.Add(lbltexto);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Encriptador/Desencriptador de Codigo de Cesar";
            Load += Form1_Load;
            grOpcion.ResumeLayout(false);
            grOpcion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbltexto;
        private Label lblllave;
        private TextBox txtLlave;
        private TextBox txtTexto;
        private GroupBox grOpcion;
        private RadioButton rdbDesencriptar;
        private RadioButton rdbEncriptar;
        private Button btnEncriptar;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label lblresultado;
        private TextBox txtResultado;
        private Label lbltitulo;
    }
}
