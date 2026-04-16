using static System.Console;
using Microsoft.EntityFrameworkCore;
using SistemaBancario.Classes.Contextos;

try
{
    using var context = new BancoContext();

    context.Database.EnsureCreated();
}
catch (Exception ex)
{
    WriteLine("Falha ao inicializar o banco de dados:\n" + ex.GetType().FullName + ": " + ex.Message);
    if (ex.InnerException is not null)
    {
        WriteLine("Inner: " + ex.InnerException.Message);
    }
    WriteLine("Verifique se o SQL Server LocalDB está instalado e a instância 'MSSQLLocalDB' existe.");
    return;
}

//Menu do programa
WriteLine("=== Sistema Bancário ===");
WriteLine("\n--MENU PRINCIPAL--");
WriteLine("[1] - Cadastrar nova conta.");
WriteLine("[2]- Consultar conta existente.");
WriteLine("[3] - Sair.\n");

Write("Escolha uma opção: ");


