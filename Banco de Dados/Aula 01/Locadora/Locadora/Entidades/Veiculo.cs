using static System.Console;
namespace Locadora.Entidades
{
    internal class Veiculo
    {
		private string modelo;


        public string Modelo
		{
			get { return modelo; }
			set { modelo = value; }
		}
        public Veiculo(string modelo)
        {
            Modelo = modelo;
        }

        
               
        


	}
}
