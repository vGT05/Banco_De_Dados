using Locadora.Entidades;
using Locadora.Servicos;
using static System.Console;
using static System.ConsoleColor;

ForegroundColor = Cyan;
WriteLine("-=Programa de aluguel de carros=-");
ResetColor();

Write("Digite o modelo do carro: ");
string modelo = ReadLine();

ForegroundColor = Yellow;
Write("Data de retirada. ");
ResetColor();
Write("(dd/MM/yyyy hh:mm): ");
DateTime inicio = DateTime.Parse(ReadLine());

ForegroundColor = Yellow;
Write("Data de devolução. ");
ResetColor();
Write("(dd/MM/yyyy hh:mm): ");
DateTime fim = DateTime.Parse(ReadLine());

WriteLine("Preço por hora: ");
double precoPorHora = double.Parse(ReadLine());

WriteLine("Preço por dia: ");
double precoPorDia = double.Parse(ReadLine());

Veiculo carrinho = new Veiculo(modelo);
AluguelCarros aluguel = new AluguelCarros(inicio, fim, carrinho);

ServAluguel servAluguel = new ServAluguel(precoPorDia, precoPorHora);
servAluguel.ProcessarFatura(aluguel);

ForegroundColor = Green;
WriteLine("--FATURA--");
ResetColor();

WriteLine($"Pagamento base: {aluguel.Fatura.PagamentoBasico.ToString()}");
WriteLine($"Imposto adicional: {aluguel.Fatura.Taxa.ToString()}");

ForegroundColor = Green;
WriteLine($"Pagamento total: {aluguel.Fatura.Total()}");
ResetColor();
ReadKey();