using static System.Console;
using static System.ConsoleColor;
using static Circunferencia03.Calculadora;

Title = "Calculadora 03";

ForegroundColor = Yellow;
Write("Digite o raio da circunferencia: ");
ResetColor();
ForegroundColor = Cyan;
double raio = double.Parse(ReadLine());
ResetColor();

WriteLine($"Circunferencia: {Circunferencia(raio):F2}");
WriteLine($"Volume: {Volume(raio):F2}");
WriteLine($"PI: {PI}");