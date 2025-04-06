using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AplicacaoHeranca;
internal class Program
{
    private List<Pessoa> pessoas; // Criando uma variável de instância acessível pela Main

    public Program() // Construtor
    {
        pessoas = new List<Pessoa>(); // Inicializa a lista

        Curso auxCurso1 = new Curso { Nome = "Sistemas de Informação", Descricao = "Um curso", CargaHoraria = 1000 };
        Curso auxCurso2 = new Curso("Educação Física", "Esportes e Anatomia", 2005);
        Aluno auxAluno1 = new Aluno("Iago Henrique Schlemper", "547143200", "412564", new Endereco("Rua J1", 37, "South Africa", "Lages", "Santa Catarina", "74162-209"), 123711, auxCurso1);
        Aluno auxAluno2 = new Aluno("João", "45137890428", "1016561", new Endereco("Rua 1", 43, "Limoeiro", "Cajuzeiro", "Paraná", "444345-678"), 456041, auxCurso1);
        Aluno auxAluno3 = new Aluno("Neymar", "47154267300", "7488740", new Endereco("Rua 1", 11, "Madrillena", "Santos", "São Paulo", "123233-859"), 451931, auxCurso2);
        Endereco auxEnd = new Endereco("Rua 1", 3124, "Pitágoras", "Derivadas", "Bhaskara", "3221-431");
        Professor auxProfessor1 = new Professor("Iago Henrique Schlemper", "94354", "45421", auxEnd, 3000, "101010", "Mestre", "Tecnologia e Computação");
        Professor auxProfessor2 = new Professor("Cristiano", "73`214", "10133345", new Endereco("Rua 1", 777, "Madeira", "Lisboa", "Sporting", "3`21-777"), 7000, "111177", "Doutor", "Matemática");
        Coordenador auxCoor = new Coordenador("Eduardo da Silva Ramos", "888169", "3214", new Endereco("Rua 2", 16, "Hincha del Norte", "Corinthians", "Colossal", "3131-313"), 16000, "13223", "AbcBolinhas");
        TecAdm auxTecAdm1 = new TecAdm("Iago Henrique Schlemper", "94949494900", "1010101", new Endereco("Rua 2", 94, "Rotterdam", "Haia", "Holanda do Sul", "94949-123"), 94000, "943224", "Desenvolvedor");
        TecAdm auxTecAdm2 = new TecAdm("Alberto", "92333977", "96539", new Endereco("Rua Corinthians", 9, "Itaquera", "Gigantossauro", "Colossal", "91249-977"), 99000, "997799", "Proganista");

        // Adicionando à lista
        pessoas.Add(auxAluno1);
        pessoas.Add(auxAluno2);
        pessoas.Add(auxAluno3);
        pessoas.Add(auxProfessor1);
        pessoas.Add(auxProfessor2);
        pessoas.Add(auxCoor);
        pessoas.Add(auxTecAdm1);
        pessoas.Add(auxTecAdm2);
    }
    public static void Main(string[] args)
    {
        Program aplicacao = new Program();
        bool faz = true;

        while (faz)
        {
            Console.Clear();
            Console.WriteLine("S. Sair\n1. Listar Pessoas");
            char n = Console.ReadLine()!.ToUpper()[0];

            switch (n)
            {
                case 'S':
                    faz = false;
                    break;
                case '1':
                    ListarPessoas(aplicacao.pessoas);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opção inválida. Pressione Enter para continuar...");
                    Console.ReadLine();
                    break;
            }
        }
    }
    private static void ListarPessoas(List<Pessoa> pessoas)
    {
        Console.Clear();
        Console.WriteLine("\n--- LISTA DE PESSOAS ---");

        foreach (var item in pessoas)
        {
            Console.Write($"{item.GetType().Name} => ");
            foreach (var (campo, valor) in item.RetornarDados())
            {
                Console.Write($"{campo}: {valor}, ");
            }
            Console.WriteLine("\n");
        }
    }
}
//Iago Henrique Schlemper