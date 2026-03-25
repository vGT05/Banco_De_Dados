using static System.Console;


namespace terreno
{
    internal class Terreno
    {
        //Campos
        public double largura, comprimento, valor;

        //Construtor
        public Terreno(double largura, double comprimento, double valor)
        {
            this.largura = largura;
            this.comprimento = comprimento;
            this.valor = valor;
        }

        //Metodos
        public double Area()
        {
            return largura * comprimento;
        }

        public double Preco()
        {
            return Area() * valor;
        }

        public void Saida()
        {
            WriteLine($"Area do terreno = {Area()}");
            WriteLine($"Preço do terreno = R${Preco()}");
        }
    }
}
