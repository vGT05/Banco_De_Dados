
namespace RetanguloOOP
{
    internal class Retangulo
    {
        public int altura, largura;

        public double Area()
        {
            double area = altura * largura;
            return area;
        }
        public double Perimeter()
        {
            double per = (altura + largura) * 2;
            return per;
        }
        public double Diagonal()
        {
            double diag = Math.Sqrt((altura * altura) + (largura * largura));
            return diag;    
        }



    }
}
