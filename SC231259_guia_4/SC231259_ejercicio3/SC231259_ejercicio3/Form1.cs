﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC231259_ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void InicializarControles()
        {
            /*Prepara controles antes de mostrar form a usuario
            Define limites de c/control NumeriUpDown
            (rango valores que aceptara: de -20.0 hasta 35.0)
            */
            nudN1.Minimum = -20;
            nudN1.Maximum = 35;
            nudN1.DecimalPlaces = 1;
            nudN1.Increment = 2;
            nudN2.Minimum = -20;
            nudN2.Maximum = 35;
            nudN2.DecimalPlaces = 1;
            nudN2.Increment = 2;
            //Define presentacion de control cmbOperaciones
            cmbOperaciones.Items.Add("1. Suma");
            cmbOperaciones.Items.Add("2. Resta");
            cmbOperaciones.Items.Add("3. Multiplicación");
            cmbOperaciones.Items.Add("4. División");
            cmbOperaciones.Items.Add("5. Potencia");
            //Listado será solo selección (solo lectura) de valores del combobox
            cmbOperaciones.DropDownStyle = ComboBoxStyle.DropDownList;
            lblResul.Text = "(RESULTADO)";
        }
        private void SumarEstosNumeros()
        {
            //calcula la suma de parámetros A y B recibidos
            double su;
            su = Convert.ToDouble(nudN1.Value) + Convert.ToDouble(nudN2.Value);
            /*Muestra resultado de suma (operac 1) y como no hay
            error no se envia ultimo parámetro*/
            MostrarResultado(su, 1);
        }
        private void MostrarResultado(double R, int Oper, Boolean hayError = false)
        {


         /*Muestre respuesta en label, resalta en
         A. fondo verde y letra blanca (si es error)
         B. fondo rojo y letra amarilla (si hay errores)
         copia texto del item seleccionado en cmbOperaciones*/
            string descripOpe = cmbOperaciones.Text;
            if (!hayError)
            {
                lblResul.BackColor = Color.Green;
                lblResul.ForeColor = Color.White;
                lblResul.Text = descripOpe + "es " + Convert.ToString(R);
            }
            else
            {
                lblResul.BackColor = Color.Red;
                lblResul.ForeColor = Color.Yellow;
                lblResul.Text = "(ERROR, DIVISION POR CERO)";
            }
        }
        private double Potencia(double A, double B)
        {
            /*Calcula potencia de A^B
            Retorna potencia a llamada recursiva anterior de misma función potencia*/
            return Math.Pow(A, B);
        }
        private void Multiplicar(double x, double y, ref double M)
        {
            /*Recibe 2 factores X e Y de parámetros entrada, para luego
            retornar en parámetro de salida (M) al resultado de multiplicación*/
            M = x * y;
        }
        private Boolean Dividir(double x, double y, ref double d)
        {
            /*Recibe 2 parámetros (x e y) de entrada, para intentar dividirlos y guardar resultados en 0
             confirma si hay división entre cero(0)*/
            if (y == 0.0)
            {
                //retorna False porque la division noo puede hacerse
                return (false);
            }
            else
            {
                /*Hace división y retorna True indicando que operacion se realizo*/
                d = x / y;
                return true;
            }
        }
        private void RestarA(double a, double b)
        {
            /*Calcula la suma de parámetros A y B recibidos*/
            double su;
            int opc;
            //Toma valores escritos en controles NumericUpDown
            su = a - b;
            opc = cmbOperaciones.SelectedIndex + 1;
            /*Muestra resultado de suma (operac 1) y como
            no hay error no se envia ultimo parámetro*/
            MostrarResultado(su, 1);
        }

        private void HacerOperacion(int numOperac)
        {
            switch (numOperac)
            {
                case 1:
                    SumarEstosNumeros();
                    break;
                case 2:
                    RestarA(Convert.ToDouble(nudN1.Value), Convert.ToDouble(nudN2.Value));
                    break;
                case 3:
                    double prod = 0;
                    Multiplicar(Convert.ToDouble(nudN1.Value), Convert.ToDouble(nudN2.Value), ref prod);
                    MostrarResultado(prod, 3, false);
                    break;
                case 4:
                    double division = 0;
                    if (Dividir(Convert.ToDouble(nudN1.Value), Convert.ToDouble(nudN2.Value), ref division))
                    {
                        MostrarResultado(division, 3);
                    }
                    else
                    {
                        MostrarResultado(division, 4, true);
                    }
                    break;
                case 5:

                    MostrarResultado(Potencia(Convert.ToDouble(nudN1.Value), Convert.ToDouble(nudN2.Value)), 5);
                    break;
                default:
                    MessageBox.Show("Operación solicitada no valida", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    break;
            }
        }

        private void cmbOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Hace operaciones matemáticas especifica cuando usuario selecciona item del combo*/
            int nop;/*num de operacion selecciona en comobo
            toma indice(0-4) seleccionado actualmente del cmboperaciones,para obtener num operacion solicitada*/
            nop = cmbOperaciones.SelectedIndex + 1;
            //procede a realizar operacion matematica indicada
            HacerOperacion(nop);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }
    }
}