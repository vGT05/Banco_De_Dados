using static System.Console;
namespace Dolar
{
    internal static class Conversor
    {
        public static double IOF = 6;

        public static double Converter(double ctc, double qtd)
        {
            double dolar = ctc * qtd;
            double pct = dolar * (IOF / 100);
            return dolar + pct;
        }



    }
}
