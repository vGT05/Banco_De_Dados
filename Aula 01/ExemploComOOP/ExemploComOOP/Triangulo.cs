namespace ExemploComOOP
{
    internal class Triangulo
    {
        //Campos/atributos
        public double ladoA, ladoB, ladoC;

        //Método
        public double Area()
        {
            double p = (ladoA + ladoB + ladoC) / 2;
            double area = Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC));
            return area;
        }

    }
}
