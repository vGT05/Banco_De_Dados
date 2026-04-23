using static System.Console;
using Microsoft.EntityFrameworkCore;

using Estudante.Classes.Dados;
using Estudante.Classes.Entidades;
using var context = new AlunoContext();

context.Database.EnsureCreated();

Aluno pessoa1 = new Aluno("Pneumoultramicroscopicosilicovulcanoconeótico", 54321, "doença");
context.Alunos.Add(pessoa1);
context.SaveChanges();
