using static System.Console;

namespace Circunferencia02
{
    internal class Calculadora
    {
        public const double PI = Math.PI;
        public double raio;

        public Calculadora(double raio)
        {
            this.raio = raio;
        }

        public double Circunferencia()
        {
            return 2 * PI * raio;
        }
        
        public double Volume()
        {
            return (4 / 3) * PI * Math.Pow(raio, 3);        
        }

        public string Pi()
        {
            return $"{PI}";
        }









    }
}
