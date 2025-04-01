namespace ClassesHeranca;
public class Funcionario : Pessoa // herança, Funcionario é uma subclasse de Pessoa que é uma subclasse de Object
{
    public int MatriculaF { get; set; }
    public double Salario { get; set; }
    // construtor com parâmetros opcionais
    public Funcionario(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, int matriculaf = 0, double salario = 0)
    {
        // herda os atributos da classe base
        Nome = nome;
        Cpf = cpf;
        Rg = rg;
        Logradouro = logradouro ?? new Endereco();
        // atributos específicos da classe derivada
        MatriculaF = matriculaf;
        Salario = salario;
    }
}