using static System.Console;
using Microsoft.EntityFrameworkCore;
using SistemaBancario.Classes.Contextos;

using var context = new BancoContext();


context.Database.EnsureCreated();

//Menu do programa
WriteLine("=== Sistema Bancário ===");
WriteLine("\n--MENU PRINCIPAL--");
WriteLine("1 - Cadastras nova conta.");
WriteLine("2 - Consultar conta existente.");
WriteLine("3 - Sair.\n");

Write("Escolha uma opção: ");

