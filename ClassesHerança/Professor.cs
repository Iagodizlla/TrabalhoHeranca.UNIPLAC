namespace ClassesHerança;
public class Professor : Funcionario // herança, Professor é uma subclasse de Pessoa que é uma subclasse de Object
{
    public string Area{ get; set; }
    public string Titulacao{ get; set;}
    // construtor com parâmetros opcionais
    public Professor(string titulacao = "", string area = "", string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, int matriculaf = 0, decimal salario = 0)
    {
        // herda os atributos da classe base
        Nome = nome;
        Cpf = cpf;
        Rg = rg;
        Logradouro = logradouro ?? new Endereco();
        MatriculaF = matriculaf;
        Salario = salario;
        // atributos específicos da classe derivada
        Titulacao = titulacao;
        Area = area;
    }
}