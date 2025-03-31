// chama a classe Curso, Aluno, Professor, Funcioanrio, Coordenador, TecnicoAdministrativo e Endereco do namespace ClassesHerança
// somente é possivel pois o projeto AplicaçãoHerança tem uma referência para o projeto ClassesHerança
using ClassesHerança;
using System.Collections.Generic;
public class Program
{
    #region Aparentemente isso nao irei utilizar
    Program(List<Pessoa> pessoas)
    {
        Curso auxCurso1 = new Curso();
        auxCurso1.Nome = "Curso 1";
        auxCurso1.Descricao = "Descrição 1";
        auxCurso1.CargaHoraria = 1000;
        Curso auxCurso2 = new Curso("Curso 2", "Descrição 2", 2145);
        Aluno auxAluno1 = new Aluno("Iago Henrique Schlemper", "123", "456", new Endereco("Jose de alencar", 4, "Coral", "lages", "SC", "12345-678"), 123, auxCurso1);
        Aluno auxAluno2 = new Aluno("Aluno 2", "789", "101", new Endereco("Rua 2", 43, "Bairro 2", "Cidade 2", "Estado 2", "12345-678"), 456, auxCurso1);
        Aluno auxAluno3 = new Aluno("Aluno 3", "325", "748", new Endereco("Rua 4", 43, "Bairro 4", "Cidade 4", "Estado 4", "12345-678"), 456, auxCurso2);
        Endereco auxEnd = new Endereco("Rua 3", 45, "Bairro 3", "Cidade 3", "Estado 3", "12345-678");
        
        Funcionario auxFun = new Funcionario("Funcionario 1", "123", "111", new Endereco("Rua 1", 40, "Bairro 1", "Cidade 1", "Estado 1", "2314-244"), 287934, 4100);
        
        Professor auxProfessor1 = new Professor("Doutor", "Computação", "Professor 1", "123", "456", auxEnd, 2134224, 3000);
        Professor auxProfessor2 = new Professor("Mestre", "Matemática", "Professor 2", "789", "101", new Endereco("Rua 4", 245, "Ba 4", "C 4", "UF 4", "12-678"), 3214441, 2900);
        //adicionar alunos e professores em um list, do tipo Pessoa, afinal tanto Aluno quanto Professor são do tipo Pessoa
        pessoas.Add(auxAluno1);
        pessoas.Add(auxAluno2);
        pessoas.Add(auxAluno3);
        pessoas.Add(auxProfessor1);
        pessoas.Add(auxProfessor2);
        pessoas.Add(auxFun);
        //listar todo o conteúdo do list mostrando todos os dados e os dados específicos de cada classe
        //foreach (var item in pessoas)
        //{
        //    if (item.GetType() == typeof(Aluno))
        //    {
        //    Console.WriteLine($"{item.GetType().Name} => Nome: {item.Nome}, CPF: {item.Cpf}, RG: {item.Rg}, Endereço: {item.Logradouro.Rua}, Matrícula: {((Aluno)item).Matricula}, Curso: {((Aluno)item).CursoAluno.Nome}\n");
        //    }
        //    else if (item is Professor p) // verifica o tipo do objeto e referência em uma variável auxiliar do tipo correto
        //    {
        //    Console.WriteLine($"{item.GetType().Name} => Nome: {p.Nome}, CPF: {p.Cpf}, RG: {p.Rg}, Endereço: {p.Logradouro.Rua}, Titulação: {p.Titulacao}, Área: {p.Area}\n");
        //    }
        //}
        //Console.ReadLine();
    }
    #endregion
    public static void Main(string[] args)
    {
        List<Pessoa> pessoas = new List<Pessoa>();
        _ = new Program(pessoas);
        bool faz = true;
        while (faz == true)
        {
            Console.Clear();
            Console.WriteLine("S. Sair\n1. Cadastrar Aluno\n2. Listar Pessoas\n3. Cadastrar Pessoa\n4. Cadastrar Funcioanrio");
            char n = char.Parse(Console.ReadLine()!.ToUpper());
            switch (n) {
                case 'S': faz = false; break;
                case '1': CadastrarAluno(pessoas); break;
                case '2': ListarPessoas(pessoas) ;break;
                case '3': CadastrarPessoa(pessoas); break;
                case '4': CadastrarFuncionario(pessoas); break;
                default: Console.WriteLine("Opcao invalida"); break;
            }
            Console.ReadLine();
        }
    }
    private static void CadastrarPessoa(List<Pessoa> pessoas)
    {
        Console.Write("CPF: ");
        string cpf = Console.ReadLine()!;

        Console.Write("Nome da Pessoa: ");
        string nome = Console.ReadLine()!;

        Console.Write("RG: ");
        string rg = Console.ReadLine()!;

        Console.Write("Rua: ");
        string rua = Console.ReadLine()!;

        Console.Write("Número: ");
        int numero = int.Parse(Console.ReadLine()!);

        Console.Write("Bairro: ");
        string bairro = Console.ReadLine()!;

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine()!;

        Console.Write("Estado: ");
        string estado = Console.ReadLine()!;

        Console.Write("CEP: ");
        string cep = Console.ReadLine()!;

        Endereco endereco = new Endereco(rua, numero, bairro, cidade, estado, cep);
        Pessoa novaPessoa = new Pessoa(cpf, nome, rg, endereco);
        pessoas.Add(novaPessoa);

        Console.WriteLine("\nPessoa cadastrado com sucesso!");
    }
    private static void CadastrarFuncionario(List<Pessoa> pessoas)
    {
        Console.Write("CPF: ");
        string cpf = Console.ReadLine()!;

        Console.Write("Nome do Funcionario: ");
        string nome = Console.ReadLine()!;

        Console.Write("RG: ");
        string rg = Console.ReadLine()!;

        Console.Write("Rua: ");
        string rua = Console.ReadLine()!;

        Console.Write("Número: ");
        int numero = int.Parse(Console.ReadLine()!);

        Console.Write("Bairro: ");
        string bairro = Console.ReadLine()!;

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine()!;

        Console.Write("Estado: ");
        string estado = Console.ReadLine()!;

        Console.Write("CEP: ");
        string cep = Console.ReadLine()!;

        Console.WriteLine("Matricula: ");
        int matriculaf = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Salario: ");
        double salario = double.Parse(Console.ReadLine()!);

        Endereco endereco = new Endereco(rua, numero, bairro, cidade, estado, cep);
        Funcionario novoFuncionario = new Funcionario(cpf, nome, rg, endereco, matriculaf, salario);
        pessoas.Add(novoFuncionario);

        Console.WriteLine("\nFuncionario cadastrado com sucesso!");
    }
    private static void ListarPessoas(List<Pessoa> pessoas)
    {
        Console.Clear();
        Console.WriteLine("\n--- LISTA DE PESSOAS ---");
        foreach (var item in pessoas)
        {
            if (item is Aluno aluno)
            {
                Console.WriteLine($"{item.GetType().Name} => Nome: {aluno.Nome}, CPF: {aluno.Cpf}, RG: {aluno.Rg}, " +
                                  $"Endereço: {aluno.Logradouro.Rua}, Matrícula: {aluno.Matricula}, Curso: {aluno.CursoAluno.Nome}\n");
            }
            else if (item is Professor professor)
            {
                Console.WriteLine($"{item.GetType().Name} => Nome: {professor.Nome}, CPF: {professor.Cpf}, RG: {professor.Rg}, " +
                                  $"Endereço: {professor.Logradouro.Rua}, Titulação: {professor.Titulacao}, Área: {professor.Area}, " +
                                  $"Matricula: {professor.MatriculaF}, Salario: {professor.Salario}\n");
            }
            else if (item is Funcionario funcionario)
            {
                Console.WriteLine($"{item.GetType().Name} => Nome: {funcionario.Nome}, CPF: {funcionario.Cpf}, RG: {funcionario.Rg}, " +
                                  $"Endereço: {funcionario.Logradouro.Rua}, Matricula: {funcionario.MatriculaF}, " +
                                  $"Salario: {funcionario.Salario}\n");
            }
            else if(item is Pessoa pessoa)
            {
                Console.WriteLine($"{item.GetType().Name} => Nome: {pessoa.Nome}, CPF: {pessoa.Cpf}, RG: {pessoa.Rg}, " +
                                  $"Endereço: {pessoa.Logradouro.Rua}\n");
            }
        }
    }
    private static void CadastrarAluno(List<Pessoa> pessoas)
    {
        Console.Write("CPF: ");
        string cpf = Console.ReadLine()!;

        Console.Write("Nome do Aluno: ");
        string nome = Console.ReadLine()!;

        Console.Write("RG: ");
        string rg = Console.ReadLine()!;

        Console.Write("Rua: ");
        string rua = Console.ReadLine()!;

        Console.Write("Número: ");
        int numero = int.Parse(Console.ReadLine()!);

        Console.Write("Bairro: ");
        string bairro = Console.ReadLine()!;

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine()!;

        Console.Write("Estado: ");
        string estado = Console.ReadLine()!;

        Console.Write("CEP: ");
        string cep = Console.ReadLine()!;

        Endereco endereco = new Endereco(rua, numero, bairro, cidade, estado, cep);

        Console.Write("Matrícula: ");
        int matricula = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Escolha o curso (1 ou 2): ");
        Console.WriteLine("1 - Curso 1");
        Console.WriteLine("2 - Curso 2");
        int opcaoCurso = int.Parse(Console.ReadLine()!);

        Curso cursoAluno = (opcaoCurso == 1) ? new Curso("Curso 1", "Descrição 1", 1000) : new Curso("Curso 2", "Descrição 2", 2145);

        Aluno novoAluno = new Aluno(cpf, nome, rg, endereco, matricula, cursoAluno);
        pessoas.Add(novoAluno);

        Console.WriteLine("\nAluno cadastrado com sucesso!");
    }
}