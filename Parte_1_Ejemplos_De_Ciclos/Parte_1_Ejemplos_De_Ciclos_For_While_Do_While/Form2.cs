using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte_1_Ejemplos_De_Ciclos_For_While_Do_While
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Se hace la declaracion de variables

            int stock;
            int cantPersonas, cantEntrega;

            //Se hace la entrada de datos

            stock = Convert.ToInt32(txtStock.Text);
            cantPersonas = 0;

            //Empezamos a repartir las vacunas

            while (stock >= 10)
            {
                cantEntrega = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese cantidad entregada persona" + (cantPersonas + 1), "Reparto de vacunas"));
                //Se validan que la cantidad entregada menor o igual que el stock

                if (stock >= cantEntrega)
                {

                    cantPersonas = cantPersonas + 1;
                    stock = stock - cantEntrega;

                }
                else
                {
                    MessageBox.Show("No hay suficiente stock", "Reparto de vacunas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MessageBox.Show("El stock es inferior a 1' unidades ", "Reparto de vacunas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Se realiza la salida de la informacion
            txtStockFinal.Text = Convert.ToString(stock);
            txtCantidadPersonas.Text = Convert.ToString(cantPersonas);

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtStock.Clear();
            txtStockFinal.Clear();
            txtCantidadPersonas.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
