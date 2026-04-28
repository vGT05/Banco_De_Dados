using MasterBanco.Classes.Entidade;
using static System.Console;
Banco conta1 = new("Dangos", 1011, 5025.50m);
Banco.CadastrarContas(conta1);
Banco.LerContas();