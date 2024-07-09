public abstract class Funcionario
{
    //definindo variaveis
    public string nome;      
    public int matricula; 

    //criando lista de projetos
    protected List<string> Projetos = new List<string>();

    //definindo metodo construtor
    public Funcionario(string nome, int matricula)
    {
        this.nome = nome;
        this.matricula = matricula;
    }

    //declarando metodos abstratos
    public abstract double CalcularSalario();
    public abstract void ExibirInformacoes();

    //Cirando metodo sobrecarregado para adicionar projeto
    public void AdicionarProjeto(string projeto)
    {
        Projetos.Add(projeto);
    }

    //Criando metodo sobrecarregado para adicionar uma lista de projetos
    public void AdicionarProjeto(List<string> projetos)
    {
        Projetos.AddRange(projetos);
    }
}   