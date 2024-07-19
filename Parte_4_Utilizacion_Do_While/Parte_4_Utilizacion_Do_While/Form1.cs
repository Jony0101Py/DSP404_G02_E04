namespace Parte_4_Utilizacion_Do_While
{
    public partial class Form1 : Form
    {
        public static Boolean IsNumeric(string valor)
        {
            int numero;
            return int.TryParse(valor, out numero);
        }

        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnCalcular_Click(object sender, EventArgs e)
        {
         if (IsNumeric(txtNumero.Text) && (long.Parse(txtNumero.Text) > 0))
            {
                //Permite poner al reves un numero que hay que ir dividiendo el numero
                //Para asi sacar el digito mas significativo y asignarlo en el nuevo
                //numero es decir en el digito menos significativo y asi sucesivamente

                long r, div, reves = 0, multi = 1;
                

                txtNumero.Text = numero.ToString();

                if(numero  >=100000 & numero <= 999999)
                {
                    div = 100000;
                }
                else if (numero >=100000 & numero <=99999) 
                {
                    div = 10000;
                }
                else if (numero >=1000 & numero <=9999)
                {
                    div = 1000;
                }
                else if (numero >=100 & numero <= 999)
                {
                    div = 100;
                }
                else if (numero >=10 & numero <= 99){
                    div = 10;
                }
                else
                {
                    MessageBox.Show("Numero fuera de rango(1-99999999)", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtNumero.Clear();
                    txtNumero.BackColor = Color.Blue;
                    return;
                }
                do
                {
                    //Se va a capturar los digitos mas significativos
                    r = numero / div;
                    //Se resta el digito al numero
                    numero = numero - r * div;
                    //Se calcula el siguiente divisor
                    div = div / 10;
                    //Se multiplica el digito segun su peso y se suma al numero numero
                    reves = reves + (r * multi);
                    //Dicho proceso se repite hasta que el numero es igual a 0
                } while (numero != 0); 
            }
        }
    }
}
