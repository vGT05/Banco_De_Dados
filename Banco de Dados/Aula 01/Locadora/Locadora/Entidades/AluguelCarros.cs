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
        public string Veiculo { get; set; }
        public AluguelCarros(DateTime inicio, DateTime fim, string veiculo)
        {
            Inicio = inicio;
            Fim = fim;
            Veiculo = veiculo;
        }


		public void Aluguel()
		{
			
			WriteLine("Data de retirada (dd/mm/aa hh/ss) ");
			DateTime inicio = DateTime.Now;
			WriteLine("Digite a data de devolução (dd//mm/aa hh/ss)");
			DateTime fim = DateTime.Parse(ReadLine());
			if (fim <= inicio)
			{
				WriteLine("Digite uma data válida.");
				return;
			}




		}





	}
}
