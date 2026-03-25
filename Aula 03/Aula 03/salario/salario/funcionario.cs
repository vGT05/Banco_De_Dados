using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Console;
//tenso
namespace salario
{
    internal class funcionario
    {
        public string nome;
        public double salarioB , imposto, pctg;

        public funcionario(string nome, double salarioB, double imposto)
        {
            this.nome = nome;
            this.salarioB = salarioB;
            this.imposto = imposto;
        }

        public double SalarioL()
        {
            double liquid = salarioB - imposto;
            return liquid;
        }

        public void Aumento(double pctg)
        {
            double liquid = SalarioL();
            double x = pctg / 100;
            double y = liquid * x;
            double raise = liquid + y;
            WriteLine("Dados atualizados.");
            WriteLine($"    Nome do funcionário: {nome}");
            WriteLine($"    Salário liquido do funcionário: {raise}");
            
            return;
            
        }









    }






}
