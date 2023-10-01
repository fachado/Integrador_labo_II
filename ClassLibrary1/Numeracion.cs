

namespace ClassLibrary1
{
    public enum Esistema
    {
        Decimal,
        Binario,
        Inválido,
       
    }

    public class Numeracion
    {
        private double valorDecimal;
        private Esistema sistema;

        public Numeracion()
        {
            InicializarValores("");
        }

        public Numeracion(double valorDecimal, Esistema sistema)
        {
            this.sistema = sistema;
            this.valorDecimal = valorDecimal;
        }

        private void InicializarValores(string valor)
        {
            if (EsDecimal(valor))
            {
                if (double.TryParse(valor, out valorDecimal))
                {
                    sistema = Esistema.Decimal;
                }
                else
                {
                    valorDecimal = double.MinValue;
                    sistema = Esistema.Inválido;
                }
            }
            else
            {
                valorDecimal = double.MinValue;
                sistema = Esistema.Inválido;
            }
        }

        public string Valor
        {
            get { return valorDecimal.ToString(); }
            set { InicializarValores(value); }
        }

        public double ValorDecimal
        {
            get { return valorDecimal; }
        }

        public Esistema Sistema
        {
            get { return sistema; }
        }

        public string ConvertirASistema(Esistema nuevoSistema, double valor)
        {
            if (nuevoSistema == Esistema.Binario)
            {
                return DecimalABinario(valor);
            }
            else if (nuevoSistema == Esistema.Decimal)
            {
                return valor.ToString();
            }
            else
            {
                return "Sistema no válido";
            }
        }

        private bool EsDecimal(string valor)
        {
            double resultado;
            return double.TryParse(valor, out resultado);
        }

        private static string DecimalABinario(double valor)
        {
            if (valor == 0)
            {
                return "0";
            }

            long Valor = (long)Math.Abs(valor);
            string Rbinario = "";

            while (Valor > 0)
            {
                long reduc = Valor % 2;
                Rbinario = reduc + Rbinario;
                Valor = Valor / 2;
            }

            if (valor < 0)
            {
                Rbinario = "-" + Rbinario;
            }

            return Rbinario;
        }

        public static bool operator !=(Numeracion sistema1, Numeracion sistema2)
        {
            return sistema1.sistema != sistema2.sistema;
        }

        public static bool operator ==(Numeracion sistema1, Numeracion sistema2)
        {
            return sistema1.sistema == sistema2.sistema;
        }
        public static double operator *(Numeracion numero1, Numeracion numero2)
        {
            return numero1.ValorDecimal * numero2.ValorDecimal;
        }
        public static double operator /(Numeracion numero1, Numeracion numero2)
        {
            return numero1.ValorDecimal / numero2.ValorDecimal;
        }
        public static double operator +(Numeracion numero1, Numeracion numero2)
        {
            return numero1.ValorDecimal + numero2.ValorDecimal;
        }
        public static double operator -(Numeracion numero1, Numeracion numero2)
        {
            return numero1.ValorDecimal - numero2.ValorDecimal;
        }
    }
}