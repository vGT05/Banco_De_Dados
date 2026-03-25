using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Console;

namespace notas
{
    internal class Contagem
    {
        public string nome;
        public double nota1, nota2, nota3;

        public Contagem(string nome, double nota1, double nota2, double nota3)
        {
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }
        public double NotaFinal()
        {
            double notaFinal = nota1 + nota2 + nota3;
            return notaFinal;
        }
        public bool AprovOrReject()
        {
            double notaFinal = NotaFinal();
            if (notaFinal >= 60)
            {
                WriteLine("Aprovado.");
                return true;
            }
            else
            {
                double pontosFaltando = 60 - notaFinal;
                WriteLine($"Reprovado, pontos faltando: {pontosFaltando}");
                return false;
            }
        }
       
    }
}
