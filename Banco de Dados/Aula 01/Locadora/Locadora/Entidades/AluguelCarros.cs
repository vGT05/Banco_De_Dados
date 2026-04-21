using static System.Console;
namespace Locadora.Entidades
{
    internal class AluguelCarros
    {
		private DateTime inicio;
		private DateTime fim;
		private string veiculo;


        public DateTime Inicio
		{
			get { return inicio; }
			set { inicio = value; }
		}
		public DateTime Fim
		{
			get { return fim; }
			set { fim = value; }
		}
        public Veiculo Veiculo { get; set; }
		public Fatura Fatura { get; set; }


        public AluguelCarros(DateTime inicio, DateTime fim, Veiculo veiculo)
        {
            Inicio = inicio;
            Fim = fim;
            Veiculo = veiculo;
        }







	}
}
