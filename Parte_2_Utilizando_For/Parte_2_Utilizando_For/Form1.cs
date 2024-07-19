namespace Parte_2_Utilizando_For
{
    public partial class Form1 : Form
    {
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaraciones de variables
            long factorial = 1;
            int i;
            //Con la funcion IsNumeric verificamos que el txtnumero contenga un dato numerico
            if (IsNumeric(txtNumero.Text))
            {
                //se realiza un for desde el numero ingresado hasta llegar a uno

                for (i = Convert.ToInt32(txtNumero.Text); i >= 1; i--)
                {
                    //Se multiplica el factorial por todos los numeros menores
                    //factorial = factorial*i;
                    factorial *= i;
                }
                txtFactorial.Text = factorial.ToString();
            }
            else
            {
                txtNumero.BackColor = Color.Red;
                MessageBox.Show("Debe ingresar un numero!", "Informacion", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                txtNumero.Clear();
                txtFactorial.Clear();
                txtNumero.Focus();
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {   
          txtNumero.BackColor=Color.Blue;
        }
    }
}
