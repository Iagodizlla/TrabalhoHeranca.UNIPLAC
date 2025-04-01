namespace ClassesHeranca;
public class Aluno : Pessoa // herança, Aluno é uma subclasse de Pessoa que é uma subclasse de Object
{
    public int Matricula { get; set; }
    public Curso CursoAluno { get; set; } // uso de delegação
    // construtor com parâmetros opcionais
    public Aluno(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, int matricula = 0, Curso? cursoAluno = null)
    {
        // herda os atributos da classe base
        Nome = nome;
        Cpf = cpf;
        Rg = rg;
        Logradouro = logradouro ?? new Endereco();
        // atributos específicos da classe derivada
        Matricula = matricula;
        CursoAluno = cursoAluno ?? new Curso();
    }
}