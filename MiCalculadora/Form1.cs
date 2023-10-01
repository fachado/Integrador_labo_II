using ClassLibrary1;

namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        private Operacion calculadora;

        public Form1()
        {
            InitializeComponent();
            calculadora = new Operacion();

        }

        private void setResultado()
        {

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {

                if (EsNumeroValido(textBox1.Text) && EsNumeroValido(textBox2.Text))
                {

                    char operador = comboBox1.Text[0];


                    calculadora.Numero1.Valor = textBox1.Text;
                    calculadora.Numero2.Valor = textBox2.Text;


                    bool mostrarEnBinario = binario.Checked;


                    string resultado = calculadora.RealizarOperacion(operador, mostrarEnBinario);

       

                    label1.Text = resultado;
                }
                else
                {

                    label1.Text = "Por favor, ingrese números válidos en ambos cuadros de texto.";
                }
            }
            else
            {

                label1.Text = "Por favor, ingrese valores en ambos cuadros de texto.";
            }
        }

        private bool EsNumeroValido(string valor)
        {
            double resultado;
            return double.TryParse(valor, out resultado);
        }

        private void Decima_MouseClick(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(label1.Text))
            {
                setResultado();
            }

        }


        private void Binario_MouseClick(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(label1.Text))
            {
                setResultado();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("/");
            comboBox1.Items.Add("*");


            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            setResultado();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();


            label1.Text = "";
        }

        private void cerrar_click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Desea cerrar la calculadora?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}