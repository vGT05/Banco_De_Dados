using notas;
using static System.Console;

Write("Nome do aluno: ");
string nome = ReadLine();
WriteLine("Digite as tres notas do aluno: ");
double nota1 = double.Parse(ReadLine());
double nota2 = double.Parse(ReadLine());
double nota3 = double.Parse(ReadLine());


Contagem x  = new Contagem(nome, nota1, nota2, nota3);


WriteLine($"Nota final do aluno: {x.NotaFinal()}");

x.AprovOrReject();