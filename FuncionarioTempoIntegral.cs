//Criação das Classes Derivadas:
public class FuncionarioTempoIntegral : Funcionario
{
    //adicionando a variavel privada para armazenar o salário mensal
    private double salarioMensal;

    //implementando o construtor 
    public FuncionarioTempoIntegral(string nome, int matricula, double salarioMensal) : base(nome, matricula)
    {
        this.salarioMensal = salarioMensal;
    }

    //implementando o metodo CalcularSalario e o metodo Exibir informações
    public override double CalcularSalario()
    {
        return salarioMensal;
    }
    public override void ExibirInformacoes()
{
    Console.WriteLine($"O funcionário {nome} nº{matricula}, recebe {salarioMensal} reais mensalmente.");

    if (Projetos.Count > 0)
    {
        Console.WriteLine("Projetos:");
        foreach (var projeto in Projetos)
        {
            Console.WriteLine($"Associado ao projeto: {projeto}");
        }
    }
    else
    {
        Console.WriteLine("Este funcionário não está associado a nenhum projeto.");
    }
}
    
    // Implementando o método CalcularBonus
    public double CalcularBonus()
    {
        return salarioMensal * 0.10;
    }

}