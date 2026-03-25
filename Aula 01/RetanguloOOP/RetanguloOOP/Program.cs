using RetanguloOOP;
using static System.Console;
Title = "Retangulos DENOVO.";
Retangulo a = new Retangulo();
Retangulo b = new Retangulo();  


WriteLine("Digite os valores do primeiro retângulo.");
Write("Digite o valor da altura: ");
a.altura = int.Parse(ReadLine());
Write("Digite o valor da largura: ");
a.largura = int.Parse(ReadLine());


WriteLine("Digite os valores do segundo retângulo.");
Write("Digite o valor da altura: ");
b.altura = int.Parse(ReadLine());
Write("Digite o valor da largura: ");
b.largura = int.Parse(ReadLine());
WriteLine();
WriteLine($"PRIMEIRO TRIANGULO: o valor da área é {a.Area()}, o perímetro é {a.Perimeter()}, e a diagonal é {a.Diagonal():F2}\n");
WriteLine($"SEGUNDO TRIANGULO: o valor da área é {b.Area()}, o perímetro é {b.Perimeter()}, e a diagonal é {b.Diagonal():F2}\n");
ReadKey();

