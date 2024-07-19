namespace Parte_3_Utilizando_For_Each
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            if (IsNumeric(txtLlave.Text) && (Convert.ToInt16(txtLlave.Text) > 0))
            {
                txtResultado.Clear();
                int ascii;
                //para cada caracter en el objeto txtTexto
                foreach (int c in txtTexto.Text)
                {
                    //verificamos si el usuario desea encriptar o desencriptar el texto 
                    if (rdbEncriptar.Checked == true)
                    {
                        /*Se convierte el caracter extraido a su equivalente numero ASCII y le sumamos la llave */
                        ascii = (int)c + Convert.ToInt16(txtLlave.Text);
                    }
                    else
                    {
                        ascii = (int)c - Convert.ToInt16(txtLlave.Text);
                    }
                    txtResultado.Text += (char)ascii;
                }
                lblresultado.Text = "Texto encriptado:";
            }
            else
            {
                MessageBox.Show("El dato introducido en la llave es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLlave.Focus();
                txtLlave.Clear();
                txtLlave.BackColor = Color.Red;
            }
        }

        private void txtLlave_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtLlave.BackColor = Color.White;
        }

        private void rdbEncriptar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEncriptar.Checked == true)
            {
                btnEncriptar.Text = "Encriptar";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            txtLlave.Clear();
            txtTexto.Clear();
            txtResultado.Clear();
            
            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rdbDesencriptar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDesencriptar.Checked== true) {
                btnEncriptar.Text = "Desencriptar";
               
                
            }
           
        }
    }
}
    

    
