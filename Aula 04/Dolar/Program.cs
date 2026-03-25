using static System.Console;
using static System.ConsoleColor;
using static Dolar.Conversor;

ForegroundColor = Yellow;
Write("Qual é a cotação do dólar? ");
ResetColor();
ForegroundColor = Red;
double cotacao = double.Parse(ReadLine());
ResetColor();

ForegroundColor = Yellow;
Write("Quantos dolares voce vai comprar? ");
ResetColor();
ForegroundColor = Red;
double quantidade = double.Parse(ReadLine());
ResetColor();

WriteLine($"Valor a ser pago em reais: {Converter(cotacao, quantidade)}");
ReadKey();

