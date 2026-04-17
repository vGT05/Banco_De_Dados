

namespace Locadora.Servicos
{
    internal class ServAluguel
    {

		private double prepoPorDia;
		private double prepoPorHora;

		public double PrecoPorDia
		{
			get { return prepoPorDia; }
			set { prepoPorDia = value; }
		}
		public double PrepoPorHora
		{
			get { return prepoPorHora; }
			set { prepoPorHora = value; }
		}

	}
}
