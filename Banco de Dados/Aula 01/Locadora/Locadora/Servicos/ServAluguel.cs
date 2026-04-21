

using Locadora.Entidades;

namespace Locadora.Servicos
{
    internal class ServAluguel
    {

        private double precoPorDia;
        private double precoPorHora;

        public double PrecoPorDia
        {
            get { return precoPorDia; }
            set { precoPorDia = value; }
        }
        public double PrecoPorHora
        {
            get { return precoPorHora; }
            set { precoPorHora = value; }
        }


        public ServAluguel(double precoPorDia, double prepoPorHora)
        {
            PrecoPorDia = precoPorDia;
            PrecoPorHora = prepoPorHora;
        }

        private TaxaServBrasil imposto = new TaxaServBrasil();

        public void ProcessarFatura(AluguelCarros aluguel)
        {
            double horas = (aluguel.Fim - aluguel.Inicio).TotalHours;

            double pagamentoBasico;

            if (horas <= 12.0)
            {
                double contador = 0;

                while (contador < horas)
                {
                    contador++;
                }

                pagamentoBasico = contador * PrecoPorHora;
            }
            else
            {
                double dias = horas / 24.0;

                double contador = 0;

                while (contador < dias)
                {
                    contador++;
                }

                pagamentoBasico = contador * PrecoPorDia;
            }

            double taxa = imposto.TaxaServico(pagamentoBasico);

            aluguel.Fatura = new Fatura(pagamentoBasico, taxa);











        }
    }
}
