using static System.Console;
Title = "Calculadora de triângulos";
//Entrada de dados
WriteLine("Digite as medidas do triângulo X.");
Write("Digite o valor de A: ");
double ax = double.Parse(ReadLine());
Write("Digite o valor de B: ");
double bx = double.Parse(ReadLine());
Write("Digite o valor de C: ");
double cx = double.Parse(ReadLine());

WriteLine("Digite as medidas do triângulo Y.");
Write("Digite o valor de A: ");
double ay = double.Parse(ReadLine());
Write("Digite o valor de B: ");
double by = double.Parse(ReadLine());
Write("Digite o valor de C: ");
double cy = double.Parse(ReadLine());

//Processamento de dados

double px = (ax + bx + cx) / 2;
double py = (ay + by + cy) / 2;
double areax = Math.Sqrt(px * (px - ax) * (px - bx) * (px - cx));
double areay = Math.Sqrt(py * (py - ay) * (py - by) * (py - cy));

//Saída de dados
WriteLine($"A área do triângulo X é de {areax:F2}");
WriteLine($"A área do triângulo Y é de {areay:F2}");

if (areax > areay)
{
    WriteLine("Maior área é do triângulo X.");
}
else if (areay > areax)
{
    WriteLine("Maior área é do triângulo Y.");
}
else
{
    WriteLine("Os dois triâgulos tem áreas iguais.");
}

ReadKey();

