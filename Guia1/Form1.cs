using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        private string mensa;
        private int conta;

        public Form1()
        {
            InitializeComponent();
            conta = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Evento se ejecuta al iniciar ejecucion de form1


            mensa = "Aun no ha presionado el boton contar";
            label1.Text = mensa;


        }

        private void btnContar_Click(object sender, EventArgs e)
        {
             conta ++;
            //Incrementa en 1

            mensa = "Presiono boton Contar, un total de " + conta.ToString() + " veces"; 
            label1.Text = mensa;

        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            conta = 0; //Reinicia conta a 0
            mensa = "Reinicio realizado, Aun no a presionado el boton Contar";
            label1.Text = mensa;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close(); // Finaliza la aplicacion
        }
    }
}
