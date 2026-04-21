
namespace Locadora.Entidades
{
    internal class Fatura
    {
        public double PagamentoBasico { get; set; }
        public double Taxa { get; set; } 
        
        public Fatura(double pagamentoBasico, double taxa)
        {
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
        }
        
        public double Total()
        {
            return PagamentoBasico + Taxa;
        }


    }
}
