namespace ClassesHerança;
public class Coordenador : Funcionario // herança, Professor é uma subclasse de Pessoa que é uma subclasse de Object
{
    public string SenhaAlarme { get; set; }
    // construtor com parâmetros opcionais
    public Coordenador(string senhaalarma = "", string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, int matriculaf = 0, decimal salario = 0)
    {
        // herda os atributos da classe base
        Nome = nome;
        Cpf = cpf;
        Rg = rg;
        Logradouro = logradouro ?? new Endereco();
        MatriculaF = matriculaf;
        Salario = salario;
        // atributos específicos da classe derivada
        SenhaAlarme = senhaalarma;
    }
}