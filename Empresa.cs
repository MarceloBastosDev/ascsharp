public class Empresa
{
    //Criando uma lista de funcionarios
    public List<Funcionario> funcionarios;

    //Criando construtor para inicializar a lista de funcionarios
    public Empresa()
    {
        funcionarios = new List<Funcionario>();
    }

    //Criando metodo para adicionar funcionario e verificando se a matricula já existe
    public void AdicionarFuncionario(Funcionario funcionario)
    {

        if (funcionarios.Any(f => f.matricula == funcionario.matricula))
        {
            Console.WriteLine($"Já existe um funcionário com a matrícula {funcionario.matricula}. Não é possível adicionar.");
            return;
        }

        funcionarios.Add(funcionario);
    }
    //Criando metodo para remover funcionario
    public void RemoverFuncionario(int matricula)
    {
        Funcionario? funcionario = funcionarios.Find(f => f.matricula == matricula);
        if (funcionario != null)
        {
            funcionarios.Remove(funcionario);
            Console.WriteLine($"Funcionário com matrícula {matricula} removido.");
        }
        else
        {
            Console.WriteLine($"Funcionário com matrícula {matricula} não encontrado.");
        }
    }

    // Dentro da classe Empresa
    public void AdicionarProjetoFuncionario(int matricula, string projeto)
    {
        Funcionario? funcionario = funcionarios.Find(f => f.matricula == matricula);
        if (funcionario != null)
        {
            funcionario.AdicionarProjeto(projeto);
            Console.WriteLine($"Projeto '{projeto}' adicionado ao funcionário com matrícula {matricula}.");
        }
        else
        {
            Console.WriteLine($"Funcionário com matrícula {matricula} não encontrado.");
        }
    }


    //Criando metodo para exibir informações de todos os funcionários na lista
    public void ExibirFuncionarios()
    {
        Console.WriteLine("Lista de Funcionários:");
        foreach (Funcionario funcionario in funcionarios)
        {
            funcionario.ExibirInformacoes();
        }
    }

}