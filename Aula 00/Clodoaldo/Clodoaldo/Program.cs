using static System.Console;

int a, b, resultado;
WriteLine("Digite dois números.");
Write("Primeiro número: ");
a = int.Parse(ReadLine());
Write("Segundo número: ");
b = int.Parse(ReadLine());
resultado = (a + b);
WriteLine($"O restultado é {resultado}");
