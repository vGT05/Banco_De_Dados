using salario;
using static System.Console;

Write("Digite o nome do funcionário: ");
string nome = ReadLine();
Write("Digite o salário bruto do funcionário: ");
double salarioB = double.Parse(ReadLine());
Write("Digite o valor total de imposto pago: ");
double imposto = double.Parse(ReadLine());

funcionario f = new funcionario(nome, salarioB, imposto);

WriteLine("Dados do funcionário.");
WriteLine($"    Nome do funcionário: {nome}\n" +
          $"    Salario liquido do funcionário: {f.SalarioL()}");

WriteLine("Digite a porcentagem do aumento do salário: ");
double pctg = double.Parse(ReadLine());

WriteLine($"Salario do funcionário aumentado em {pctg}%");

f.Aumento(pctg);