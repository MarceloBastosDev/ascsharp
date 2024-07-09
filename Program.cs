using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Empresa minhaEmpresa = new Empresa();

        while (true)
        {
            MostrarMenu();

            string opcao = Console.ReadLine();
            Console.WriteLine();

            switch (opcao)
            {
                case "1":
                    AdicionarFuncionarioTempoIntegral(minhaEmpresa);
                    break;
                case "2":
                    AdicionarFuncionarioMeioPeriodo(minhaEmpresa);
                    break;
                case "3":
                    RemoverFuncionario(minhaEmpresa);
                    break;
                case "4":
                    ExibirFuncionarios(minhaEmpresa);
                    break;
                case "5":
                    AdicionarProjetoFuncionario(minhaEmpresa);
                    break;
                case "6":
                    Console.WriteLine("Encerrando o programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine();
        Console.WriteLine("### Menu ###");
        Console.WriteLine("1. Adicionar funcionário de tempo integral");
        Console.WriteLine("2. Adicionar funcionário de meio período");
        Console.WriteLine("3. Remover funcionário");
        Console.WriteLine("4. Exibir informações de todos os funcionários");
        Console.WriteLine("5. Adicionar projeto a um funcionário");
        Console.WriteLine("6. Sair do programa");
        Console.Write("Escolha uma opção: ");
    }

    static void AdicionarFuncionarioTempoIntegral(Empresa empresa)
    {
        Console.Write("Nome do funcionário de tempo integral: ");
        string nome = Console.ReadLine();

        Console.Write("Matrícula do funcionário: ");
        int matricula = int.Parse(Console.ReadLine());

        Console.Write("Salário mensal do funcionário: ");
        double salarioMensal = double.Parse(Console.ReadLine());

        FuncionarioTempoIntegral funcionario = new FuncionarioTempoIntegral(nome, matricula, salarioMensal);
        empresa.AdicionarFuncionario(funcionario);

        Console.WriteLine("Funcionário de tempo integral adicionado com sucesso!");
    }
    static void AdicionarFuncionarioMeioPeriodo(Empresa empresa)
    {
        Console.Write("Nome do funcionário de meio período: ");
        string nome = Console.ReadLine();
        Console.Write("Matrícula do funcionário: ");
        int matricula = int.Parse(Console.ReadLine());
        Console.Write("Salário por hora do funcionário: ");
        double salarioHora = double.Parse(Console.ReadLine());
        Console.Write("Número de horas trabalhadas por semana: ");
        int horasTrabalhadas = int.Parse(Console.ReadLine());

        FuncionarioMeioPeriodo funcionario = new FuncionarioMeioPeriodo(nome, matricula, salarioHora, horasTrabalhadas);
        empresa.AdicionarFuncionario(funcionario);

        Console.WriteLine("Funcionário de meio período adicionado com sucesso!");
    }

    static void RemoverFuncionario(Empresa empresa)
    {
        Console.Write("Matrícula do funcionário a ser removido: ");
        int matricula = int.Parse(Console.ReadLine());

        empresa.RemoverFuncionario(matricula);
    }

    static void ExibirFuncionarios(Empresa empresa)
    {
        empresa.ExibirFuncionarios();
    }

    static void AdicionarProjetoFuncionario(Empresa empresa)
    {
        Console.Write("Matrícula do funcionário: ");
        int matricula = int.Parse(Console.ReadLine());
        Console.Write("Nome do projeto a ser adicionado: ");
        string projeto = Console.ReadLine();

        empresa.AdicionarProjetoFuncionario(matricula, projeto);
    }
}
