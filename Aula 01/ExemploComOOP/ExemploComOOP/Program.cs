using ExemploComOOP;
using static System.Console;
//Instanciação dos triangulos X e Y
Title = "Calculadora de triângulos";
Triangulo x = new Triangulo();
Triangulo y = new Triangulo();
//EntryX
WriteLine("Digite as medidas do triângulo X.");
Write("Digite a medida A: ");
x.ladoA = double.Parse(ReadLine());
Write("Digite a medida B: ");
x.ladoB = double.Parse(ReadLine());
Write("Digite a medida C: ");
x.ladoC = double.Parse(ReadLine());
//EntryY
WriteLine("Digite as medida do triângulo Y.");
Write("Digite a medida A: ");
y.ladoA = double.Parse(ReadLine());
Write("Digite a medida B: ");
y.ladoB = double.Parse(ReadLine());
Write("DIgite a medida C: ");
y.ladoC = double.Parse(ReadLine());

//Saída de dados
WriteLine($"A área do triângulo X é de {x.Area():F2}");
WriteLine($"A área do triângulo Y é de {y.Area():F2}");
ReadKey();

