namespace Parte_1_Ejemplos_De_Ciclos_For_While_Do_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //Aqui se va hacer la declaracion de variables

            int numero;
            double suma, resta, multiplicacion, div;

            //Se hace la entrada de datos

            numero = Convert.ToInt32(txtnumero.Text);

            //Procedimiento..

            cbosuma.Items.Clear();
            cboresta.Items.Clear();
            cbomult.Items.Clear();
            cbodiv.Items.Clear();

            //Se crean los bucles para asi poder mostrar la tabla del 1 al 12

            for (int i = 1; i <= 12; i++)
            {
                suma = numero + i;
                resta = numero - i;
                multiplicacion = numero * i;
                div = numero / i;

                //Se agregar los resultados en los combobox
                cbosuma.Items.Add(numero + " + " + i + " = " + suma);
                cboresta.Items.Add(numero + " - " + i + " = " + resta);
                cbomult.Items.Add(numero + " * " + i + " = " + multiplicacion);
                cbodiv.Items.Add(numero + " / " + i + " = " + div);

            }

        }

        private void btnnuevo_Click_1(object sender, EventArgs e)
        {
            cbosuma.Items.Clear();
            cboresta.Items.Clear();
            cbomult.Items.Clear();
            cbodiv.Items.Clear();
            txtnumero.Clear();
        }
    }
}
