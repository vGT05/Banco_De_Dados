using static System.Console;
namespace Estudante.Classes.Entidades
{
    internal class Aluno
    {
        //propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public int RA { get; set; }
        public string Curso { get; set; }
        //construtores
        public Aluno()
        {
        }
        public Aluno(string nome, int rA, string curso)
        {
            Nome = nome;
            RA = rA;
            Curso = curso;
        }
        //métodos
        public void ExibirDados()
        {
            ForegroundColor= ConsoleColor.Blue;
            WriteLine(" -- Dados do Aluno -- ");
            ResetColor();
            
            WriteLine($"Nome do aluno: {Nome}");
            WriteLine($"RA: {RA}");
            WriteLine($"Curso Matriculado: {Curso}");
        }





    }


}
