using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form2 : Form
    {
        private double TasaI;
        // valida que el dato recibido es un numero

        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }



        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void rdbInteres3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInteres3.Checked == true)
            {
                txtTasaInterEX.Enabled = true;
                txtTasaInterEX.Focus();
            }
            else
            {
                txtTasaInterEX.Text = "0";
                txtTasaInterEX.Enabled = false;
            }


        }

        private void rdbInteres1_CheckedChanged(object sender, EventArgs e)
        {
            double TasaI = 0.12;
        }

        private void rdbInteres2_CheckedChanged(object sender, EventArgs e)
        {
            double TasaI = 0.235;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            //Declaracion de variables autilizar
            string NomEmpre;
            double MontoInic = 0, MontoFin = 0;
            int Tiempo;

            NomEmpre = txtEmpresa.Text;
            NomEmpre = NomEmpre.Trim();//Quita el espacio-blanco al inicio-final

            if (NomEmpre.Length == 0)
            {
                //si no hay caracteres en nombre empresa
                MessageBox.Show("Debe indicar Nombre de la empresa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMonto.Focus(); //Metodo que indica que control txtEmpresa recibira cursor
                return;//sale del procedimiento btnanalisis
            }

            if (!(IsNumeric(txtMonto.Text)))
            {
                MessageBox.Show("Valor monto incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonto.Focus(); //Metodo que indica que control txtEmpresa recibira cursor
                return;
            }
            else
            {
                MontoInic = Convert.ToDouble(txtMonto.Text);
                if (!(MontoInic > 0))
                {
                    MessageBox.Show("Valor monto no´puede ser negativo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMonto.Focus(); //metodo que indica que control txtEmpresa recibira cursor
                    return;
                }
            }


            Tiempo = Convert.ToInt32(txtTiempo.Text);
            //si selecciono Tasa interes 3, valida que sea correcta

            txtTasaInterEX.Text = txtTasaInterEX.Text.Trim();

            if (rdbInteres3.Checked == true)
            {
                if (txtTasaInterEX.Text.Length > 0)
                {
                    if (!(IsNumeric(txtTasaInterEX.Text) == true))
                    {
                        MessageBox.Show("Tasa interes incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTasaInterEX.Text = "0";
                        txtTasaInterEX.Focus();
                        return;
                    }
                    else
                    {
                        TasaI = Convert.ToDouble(txtTasaInterEX.Text) / 100;
                    }
                }
                else
                {
                    MessageBox.Show("Aun no ha indicado una tasa interes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTasaInterEX.Focus();
                    return;

                }
            }

            //Hace el calculo esperandolo
            MontoFin = (1 + TasaI);
            MontoFin = MontoInic * (Math.Pow(Convert.ToDouble(MontoFin), Tiempo));
            TasaI *= 100;
            //Muestra la respuesta (Monto a pagar)

            lstResult.Items.Clear();
            lstResult.Items.Add("Empresa: " + txtEmpresa.Text);
            lstResult.Items.Add("Monto: $" + MontoInic + ", Tasa anual: " + TasaI);
            lstResult.Items.Add("Monto a pagar: $" + MontoFin);
        }
    }
}

        
        




        

            