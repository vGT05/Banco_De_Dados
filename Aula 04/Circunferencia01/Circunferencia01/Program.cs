using static System.Console;
using static System.ConsoleColor;

Title = "Calculadora 01";

double raio;
const double PI = Math.PI;

Write("Entre com o valor do raio da circunferencia: ");
ForegroundColor = Red;
raio = double.Parse(ReadLine());
ResetColor();

double Circunferencia(double r)
{
    return 2 * PI * r;
}

double Volume (double r)
{
    return (4 / 3) * PI * (r * r * r);
}

WriteLine($"Circunferencia: {Circunferencia(raio):F2}");
WriteLine($"Volume: {Volume(raio):F2}");
WriteLine($"PI: {PI}");
