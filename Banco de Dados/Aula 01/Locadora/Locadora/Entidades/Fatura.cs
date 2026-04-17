
namespace Locadora.Entidades
{
    internal class Fatura
    {
		private double pagamentoBasico;
		private double taxa;
		private double totalPagamento;

		public double PagamentoBasico
		{
			get { return pagamentoBasico; }
			set { pagamentoBasico = value; }
		}
		public double Taxa
		{
			get { return taxa; }
			set { taxa = value; }
		}
		public double TotalPagamento
		{
			get { return totalPagamento; }
			set { totalPagamento = value; }
		}

		public string ToString()
		{
			return;
		}

	}
}
