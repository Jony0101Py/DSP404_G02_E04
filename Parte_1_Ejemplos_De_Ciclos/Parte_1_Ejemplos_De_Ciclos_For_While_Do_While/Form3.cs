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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int cantAlumno, nota;
            Double promedio = 0;

            //Se da la entrada de datos

            cantAlumno = Convert.ToInt32(txtCantAlumnos.Text);

            //Procedimiento
            //Se hace la insersion de un bucle para pedir la nota de los alumnos

            for (int i = 1; i <= cantAlumno; i++)
            {
                //Leer la nota del alumno 
                do
                {

                    nota = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese nota del alumno" + i, "Registro Notas"));
                } while (nota < 0 || nota > 20);
                promedio = promedio + nota;
            }

            //Se hace la salida de informacion
            txtpromedio.Text = Convert.ToString(promedio / cantAlumno);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCantAlumnos.Clear();
            txtpromedio.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
