//Criação das Classes Derivadas:
public class FuncionarioMeioPeriodo : Funcionario
{
    //Criando as variaveis privadas salarioPorHora e horasTrabalhadas.
    private double salarioPorHora;
    private int horasTrabalhadas;

    //Implementando o construtor para inicializar o nome, a matrícula, o salário por hora e o número de horas trabalhadas.
    public FuncionarioMeioPeriodo(string nome, int matricula, double salarioPorHora, int horasTrabalhadas) : base(nome, matricula)
    {
        this.salarioPorHora = salarioPorHora;
        this.horasTrabalhadas = horasTrabalhadas;
    }

    //implementando o metodo CalcularSalario e o metodo Exibir informações
    public override double CalcularSalario()
    {
        return salarioPorHora;
    }
    public override void ExibirInformacoes()
    {
        Console.WriteLine($"O funcionário {nome} nº{matricula}, recebe {salarioPorHora} reais por hora, trabalhando por {horasTrabalhadas} horas.");
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

    // Implementação do método CalcularBonus
    public double CalcularBonus()
    {
        return CalcularSalario() * 0.05;
    }

}