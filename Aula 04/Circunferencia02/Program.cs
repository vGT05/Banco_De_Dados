using Circunferencia02;
using static System.Console;
using static System.ConsoleColor;

ForegroundColor = Yellow;
Write("Digite o raio da circunferencia: ");
ResetColor();
ForegroundColor = Cyan;
double raio = double.Parse(ReadLine());
ResetColor();

Calculadora c1 = new Calculadora(raio);

WriteLine($"Circunferencia: {c1.Circunferencia():F2}");
WriteLine($"Volume: {c1.Volume():F2}");
WriteLine($"PI: {c1.Pi()}");


