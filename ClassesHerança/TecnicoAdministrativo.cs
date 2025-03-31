namespace ClassesHerança;
public class TecnicoAdministrativo : Funcionario // herança, Professor é uma subclasse de Pessoa que é uma subclasse de Object
{
    public string Funcao{ get; set; }
    // construtor com parâmetros opcionais
    public TecnicoAdministrativo(string funcao = "", string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, int matriculaf = 0, double salario = 0)
    {
        // herda os atributos da classe base
        Nome = nome;
        Cpf = cpf;
        Rg = rg;
        Logradouro = logradouro ?? new Endereco();
        MatriculaF = matriculaf;
        Salario = salario;
        // atributos específicos da classe derivada
        Funcao = funcao;
    }
}