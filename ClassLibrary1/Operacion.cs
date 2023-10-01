

namespace ClassLibrary1
{
    public class Operacion
    {
        private Numeracion numero1;
        private Numeracion numero2;
        public Esistema Esistema { get; set; }

        public Operacion()
        {
            numero1 = new Numeracion();
            numero2 = new Numeracion();
        }

        public Numeracion Numero1
        {
            get { return numero1; }
            set { numero1 = value; }
        }

        public Numeracion Numero2
        {
            get { return numero2; }
            set { numero2 = value; }
        }

        public string RealizarOperacion(char operador, bool mostrarEnBinario)
        {
            double resultado = 0;
            switch (operador)
            {
                case '+':
                    resultado = numero1.ValorDecimal + numero2.ValorDecimal;
                    break;
                case '-':
                    resultado = numero1.ValorDecimal - numero2.ValorDecimal;
                    break;
                case '*':
                    resultado = numero1.ValorDecimal * numero2.ValorDecimal;
                    break;
                case '/':
                    if (numero2.ValorDecimal != 0)
                        resultado = numero1.ValorDecimal / numero2.ValorDecimal;
                    else
                        return "Error: División por cero";
                    break;
                default:
                    return "Operador no válido";
            }

            if (mostrarEnBinario)
            {
                return numero1.ConvertirASistema(Esistema.Binario, resultado);
            }
            else
            {
                return resultado.ToString();
            }
        }
    }
}