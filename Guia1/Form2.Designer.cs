namespace Ejemplo1
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
            lblEmpresa = new Label();
            txtEmpresa = new TextBox();
            lblMonto = new Label();
            txtMonto = new TextBox();
            lbltiempo = new Label();
            txtTiempo = new TextBox();
            lblTasaInter = new Label();
            rdbInteres1 = new RadioButton();
            rdbInteres2 = new RadioButton();
            rdbInteres3 = new RadioButton();
            txtTasaInterEX = new TextBox();
            lstResult = new ListBox();
            btnAnalisis = new Button();
            btnFin = new Button();
            SuspendLayout();
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(81, 44);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(146, 20);
            lblEmpresa.TabIndex = 0;
            lblEmpresa.Text = "Nombre de Empresa";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(242, 44);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(443, 27);
            txtEmpresa.TabIndex = 1;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(81, 121);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(142, 20);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Monto prestamo ($)";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(242, 118);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(153, 27);
            txtMonto.TabIndex = 3;
            // 
            // lbltiempo
            // 
            lbltiempo.AutoSize = true;
            lbltiempo.Location = new Point(409, 121);
            lbltiempo.Name = "lbltiempo";
            lbltiempo.Size = new Size(101, 20);
            lbltiempo.TabIndex = 4;
            lbltiempo.Text = "Tiempo(años)";
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(532, 118);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(153, 27);
            txtTiempo.TabIndex = 5;
            txtTiempo.Text = "2";
            // 
            // lblTasaInter
            // 
            lblTasaInter.AutoSize = true;
            lblTasaInter.Location = new Point(81, 192);
            lblTasaInter.Name = "lblTasaInter";
            lblTasaInter.Size = new Size(85, 20);
            lblTasaInter.TabIndex = 6;
            lblTasaInter.Text = "Tasa Interes";
            // 
            // rdbInteres1
            // 
            rdbInteres1.AutoSize = true;
            rdbInteres1.Checked = true;
            rdbInteres1.Location = new Point(81, 254);
            rdbInteres1.Name = "rdbInteres1";
            rdbInteres1.Size = new Size(58, 24);
            rdbInteres1.TabIndex = 7;
            rdbInteres1.TabStop = true;
            rdbInteres1.Text = "12%";
            rdbInteres1.UseVisualStyleBackColor = true;
            rdbInteres1.CheckedChanged += rdbInteres1_CheckedChanged;
            // 
            // rdbInteres2
            // 
            rdbInteres2.AutoSize = true;
            rdbInteres2.Location = new Point(242, 254);
            rdbInteres2.Name = "rdbInteres2";
            rdbInteres2.Size = new Size(69, 24);
            rdbInteres2.TabIndex = 8;
            rdbInteres2.Text = "23.5%";
            rdbInteres2.UseVisualStyleBackColor = true;
            rdbInteres2.CheckedChanged += rdbInteres2_CheckedChanged;
            // 
            // rdbInteres3
            // 
            rdbInteres3.AutoSize = true;
            rdbInteres3.Location = new Point(395, 254);
            rdbInteres3.Name = "rdbInteres3";
            rdbInteres3.Size = new Size(120, 24);
            rdbInteres3.TabIndex = 9;
            rdbInteres3.Text = "Otro, indique:";
            rdbInteres3.UseVisualStyleBackColor = true;
            rdbInteres3.CheckedChanged += rdbInteres3_CheckedChanged;
            // 
            // txtTasaInterEX
            // 
            txtTasaInterEX.Enabled = false;
            txtTasaInterEX.Location = new Point(560, 253);
            txtTasaInterEX.Name = "txtTasaInterEX";
            txtTasaInterEX.Size = new Size(125, 27);
            txtTasaInterEX.TabIndex = 10;
            txtTasaInterEX.Text = "0";
            // 
            // lstResult
            // 
            lstResult.Enabled = false;
            lstResult.FormattingEnabled = true;
            lstResult.Location = new Point(81, 316);
            lstResult.Name = "lstResult";
            lstResult.Size = new Size(604, 144);
            lstResult.TabIndex = 11;
            // 
            // btnAnalisis
            // 
            btnAnalisis.Location = new Point(159, 488);
            btnAnalisis.Name = "btnAnalisis";
            btnAnalisis.Size = new Size(152, 29);
            btnAnalisis.TabIndex = 12;
            btnAnalisis.Text = "Analisis Financiero";
            btnAnalisis.UseVisualStyleBackColor = true;
            btnAnalisis.Click += btnAnalisis_Click;
            // 
            // btnFin
            // 
            btnFin.Location = new Point(452, 488);
            btnFin.Name = "btnFin";
            btnFin.Size = new Size(154, 29);
            btnFin.TabIndex = 13;
            btnFin.Text = "Salir del Programa";
            btnFin.UseVisualStyleBackColor = true;
            btnFin.Click += btnFin_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 578);
            Controls.Add(btnFin);
            Controls.Add(btnAnalisis);
            Controls.Add(lstResult);
            Controls.Add(txtTasaInterEX);
            Controls.Add(rdbInteres3);
            Controls.Add(rdbInteres2);
            Controls.Add(rdbInteres1);
            Controls.Add(lblTasaInter);
            Controls.Add(txtTiempo);
            Controls.Add(lbltiempo);
            Controls.Add(txtMonto);
            Controls.Add(lblMonto);
            Controls.Add(txtEmpresa);
            Controls.Add(lblEmpresa);
            Name = "Form2";
            Text = "Calculo del monto a pagar por un Prestamo";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmpresa;
        private TextBox txtEmpresa;
        private Label lblMonto;
        private TextBox txtMonto;
        private Label lbltiempo;
        private TextBox txtTiempo;
        private Label lblTasaInter;
        private RadioButton rdbInteres1;
        private RadioButton rdbInteres2;
        private RadioButton rdbInteres3;
        private TextBox txtTasaInterEX;
        private ListBox lstResult;
        private Button btnAnalisis;
        private Button btnFin;
    }
}