// chama a classe Curso, Aluno, Professor e Endereco do namespace ClassesHerança
// somente é possivel pois o projeto AplicaçãoHerança tem uma referência para o projeto ClassesHerança
using ClassesHerança;
internal class Program
{
    Program()
    {
        Curso auxCurso1 = new Curso();
        auxCurso1.Nome = "Curso 1";
        auxCurso1.Descricao = "Descrição 1";
        auxCurso1.CargaHoraria = 1000;
        Curso auxCurso2 = new Curso("Curso 2", "Descrição 2", 2145);
        Aluno auxAluno1 = new Aluno("Aluno 1", "123", "456", new Endereco("Rua 1", 12, "Bairro 1", "Cidade 1", "Estado 1", "12345-678"), 123, auxCurso1);
        Aluno auxAluno2 = new Aluno("Aluno 2", "789", "101", new Endereco("Rua 2", 43, "Bairro 2", "Cidade 2", "Estado 2", "12345-678"), 456, auxCurso1);
        Aluno auxAluno3 = new Aluno("Aluno 3", "325", "748", new Endereco("Rua 4", 43, "Bairro 4", "Cidade 4", "Estado 4", "12345-678"), 456, auxCurso2);
        Endereco auxEnd = new Endereco("Rua 3", 45, "Bairro 3", "Cidade 3", "Estado 3", "12345-678");
        Professor auxProfessor1 = new Professor("Doutor", "Computação", "Professor 1", "123", "456", auxEnd, 2134224, 3000);
        Professor auxProfessor2 = new Professor("Mestre", "Matemática", "Professor 2", "789", "101", new Endereco("Rua 4", 245, "Ba 4", "C 4", "UF 4", "12-678"), 3214441, 2900);
        //adicionar alunos e professores em um list, do tipo Pessoa, afinal tanto Aluno quanto Professor são do tipo Pessoa
        List<Pessoa> pessoas = new List<Pessoa>();
        pessoas.Add(auxAluno1);
        pessoas.Add(auxAluno2);
        pessoas.Add(auxAluno3);
        pessoas.Add(auxProfessor1);
        pessoas.Add(auxProfessor2);
        //listar todo o conteúdo do list mostrando todos os dados e os dados específicos de cada classe
        foreach (var item in pessoas)
        {
            if (item.GetType() == typeof(Aluno))
            {
            Console.WriteLine($"{item.GetType().Name} => Nome: {item.Nome}, CPF: {item.Cpf}, RG: {item.Rg}, Endereço: {item.Logradouro.Rua}, Matrícula: {((Aluno)item).Matricula}, Curso: {((Aluno)item).CursoAluno.Nome}\n");
            }
            else if (item is Professor p) // verifica o tipo do objeto e referência em uma variável auxiliar do tipo correto
            {
            Console.WriteLine($"{item.GetType().Name} => Nome: {p.Nome}, CPF: {p.Cpf}, RG: {p.Rg}, Endereço: {p.Logradouro.Rua}, Titulação: {p.Titulacao}, Área: {p.Area}\n");
            }
        }
    }
    public static void Main(string[] args)
    {
    _ = new Program();
    }
}