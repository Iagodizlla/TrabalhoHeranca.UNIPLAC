// chama a classe Curso, Aluno, Professor, Funcioanrio, Coordenador, TecnicoAdministrativo e Endereco do namespace ClassesHerança
// somente é possivel pois o projeto AplicaçãoHerança tem uma referência para o projeto ClassesHerança
using ClassesHeranca;
public class Program
{
    #region Dados ja implantados
    Program(List<Pessoa> pessoas)
    {
        Curso auxCurso1 = new Curso();
        auxCurso1.Nome = "Sistemas de Informacao";
        auxCurso1.Descricao = "Descrição 1";
        auxCurso1.CargaHoraria = 1000;
        Curso auxCurso2 = new Curso("Curso 2", "Descrição 2", 2145);
        Endereco auxEnd = new Endereco("Rua 3", 45, "Bairro 3", "Cidade 3", "Estado 3", "12345-678");
        Pessoa auxPe = new Pessoa("Iago Henrique Schlemper", "23123", "8567", auxEnd);
        Funcionario auxFun = new Funcionario("Iago Henrique Schlemper", "32142", "321412", new Endereco("3443", 321, "32142", "3134", "13", "1344444"), 143314, 1220.9);
        Aluno auxAluno1 = new Aluno("Iago Henrique Schlemper", "123", "456", new Endereco("Jose de alencar", 4, "Coral", "lages", "SC", "12345-678"), 123, auxCurso1);
        Aluno auxAluno2 = new Aluno("Aluno 2", "789", "101", new Endereco("Rua 2", 43, "Bairro 2", "Cidade 2", "Estado 2", "12345-678"), 456, auxCurso1);
        Aluno auxAluno3 = new Aluno("Aluno 3", "325", "748", new Endereco("Rua 4", 43, "Bairro 4", "Cidade 4", "Estado 4", "12345-678"), 456, auxCurso2);
        Professor auxProfessor1 = new Professor("Mestre", "Tecnilogia", "Iago Henrique Schlemper", "123", "456", auxEnd, 2134224, 3000);
        Professor auxProfessor2 = new Professor("Mestre", "Matemática", "Professor 2", "789", "101", new Endereco("Rua 4", 245, "Ba 4", "C 4", "UF 4", "12-678"), 3214441, 2900);
        Coordenador auxCoo = new Coordenador("AbcBolinhas", "Iago Henrique Schlemper", "314423", "32142", auxEnd, 32144, 9000);
        TecnicoAdministrativo auxTec = new TecnicoAdministrativo("Desenvolvedor", "Iago Henrique Schlemper", "23132", "3411", auxEnd, 124441, 7030);
        TecnicoAdministrativo auxTec2 = new TecnicoAdministrativo("Analitico", "Seu jorge", "23133", "34112", auxEnd, 1244341, 7000);
        //adicionar alunos e professores em um list, do tipo Pessoa, afinal tanto Aluno quanto Professor são do tipo Pessoa
        pessoas.Add(auxPe);
        pessoas.Add(auxFun);
        pessoas.Add(auxAluno1);
        pessoas.Add(auxAluno2);
        pessoas.Add(auxAluno3);
        pessoas.Add(auxProfessor1);
        pessoas.Add(auxProfessor2);
        pessoas.Add(auxCoo);
        pessoas.Add(auxTec);
        pessoas.Add(auxTec2);
    }
    #endregion
    public static void Main(string[] args)
    {
        #region Coisas
        List<Pessoa> pessoas = new List<Pessoa>();
        _ = new Program(pessoas);
        bool faz = true;
        #endregion
        while (faz == true)
        {
            #region Menu (Sair / Lista Pessoas / Cadastrar Pessoa)
            Console.Clear();
            Console.WriteLine("S. Sair\n1. Listar Pessoas\n2. Cadastrar Pessoa");
            char n = char.Parse(Console.ReadLine()!.ToUpper());
            #endregion
            #region Ir para escolha do menu
            switch (n)
            {
                case 'S': faz = false; break;
                case '1': ListarPessoas(pessoas); break;
                case '2': CadastrarPessoa(pessoas); break;
                default: Console.WriteLine("Opcao invalida"); break;
            }
            #endregion
        }
    }
    private static void CadastrarPessoa(List<Pessoa> pessoas)
    {
        #region Perguntas
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
        #endregion
        #region Menu (Aluno / Funcionario)
        Console.WriteLine("1. Aluno\n2. Funcionario");
        char m = char.Parse(Console.ReadLine()!);
        #endregion
        #region Ir para outro metodo
        Endereco endereco = new Endereco(rua, numero, bairro, cidade, estado, cep);
        if (m == '1')
        {
            CadastrarAluno(pessoas, cpf, nome, rg, endereco);
        }
        else if (m == '2')
        {
            CadastrarFuncionario(pessoas, cpf, nome, rg, endereco);
        }
        #endregion
        Console.ReadLine();
    }
    private static void CadastrarFuncionario(List<Pessoa> pessoas, string cpf, string nome, string rg, Endereco endereco)
    {
        #region Perguntas
        Console.WriteLine("Matricula: ");
        int matriculaf = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Salario: ");
        double salario = double.Parse(Console.ReadLine()!);
        #endregion
        #region Menu(Professor / Coordenador / Tecnico ADM)
        Console.WriteLine("1. Professor\n2. Coordenador\n3. Tecnico ADM");
        char m = char.Parse(Console.ReadLine()!);
        #endregion
        #region Ir para outro metodo
        if (m == '1')
        {
            #region Perguntas
            Console.Write("Titulacao: ");
            string titulacao = Console.ReadLine()!;

            Console.Write("Area: ");
            string area = Console.ReadLine()!;
            #endregion
            Professor novoProfessor = new Professor(titulacao, area, cpf, nome, rg, endereco, matriculaf, salario);
            pessoas.Add(novoProfessor);
        }
        else if (m == '2')
        {
            #region Perguntas
            Console.Write("Senha do Alarme: ");
            string senhaalarme = Console.ReadLine()!;
            #endregion
            Coordenador novoCoordenador = new Coordenador(senhaalarme, cpf, nome, rg, endereco, matriculaf, salario);
            pessoas.Add(novoCoordenador);
        }
        else if (m == '3')
        {
            #region Perguntas
            Console.Write("Funcao: ");
            string funcao = Console.ReadLine()!;
            #endregion
            TecnicoAdministrativo novoTecnicoADM = new TecnicoAdministrativo(funcao, cpf, nome, rg, endereco, matriculaf, salario);
            pessoas.Add(novoTecnicoADM);
        }
        #endregion
        Console.WriteLine("\nFuncionario cadastrado com sucesso!");
    }
    private static void ListarPessoas(List<Pessoa> pessoas)
    {
        #region Cabecalho
        Console.Clear();
        Console.WriteLine("\n--- LISTA DE PESSOAS ---");
        #endregion
        #region Exibir lista
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
            else if (item is Coordenador coordenador)
            {
                Console.WriteLine($"{item.GetType().Name} => Nome: {coordenador.Nome}, CPF: {coordenador.Cpf}, RG: {coordenador.Rg}, " +
                                  $"Endereço: {coordenador.Logradouro.Rua}, Matricula: {coordenador.MatriculaF}, " +
                                  $"Salario: {coordenador.Salario}, Senha Alarme: {coordenador.SenhaAlarme}\n");
            }
            else if (item is TecnicoAdministrativo tecnicoAdministrativo)
            {
                Console.WriteLine($"{item.GetType().Name} => Nome: {tecnicoAdministrativo.Nome}, CPF: {tecnicoAdministrativo.Cpf}, " +
                                  $"RG: {tecnicoAdministrativo.Rg}, Endereço: {tecnicoAdministrativo.Logradouro.Rua}, " +
                                  $"Matricula: {tecnicoAdministrativo.MatriculaF}, Salario: {tecnicoAdministrativo.Salario}, " +
                                  $"Funcao: {tecnicoAdministrativo.Funcao}\n");
            }
            else if (item is Pessoa pessoa)
            {
                Console.WriteLine($"{item.GetType().Name} => Nome: {pessoa.Nome}, CPF: {pessoa.Cpf}, RG: {pessoa.Rg}, " +
                                 $"Endereço: {pessoa.Logradouro.Rua}\n");
            }
        }
        #endregion
        Console.ReadLine();
    }
    private static void CadastrarAluno(List<Pessoa> pessoas, string cpf, string nome, string rg, Endereco endereco)
    {
        #region Perguntas
        Console.Write("Matrícula: ");
        int matricula = int.Parse(Console.ReadLine()!);
        #endregion
        #region Menu(SI / DI)
        Console.WriteLine("Escolha o curso (1 ou 2): ");
        Console.WriteLine("1 - Sistemas de infromacao");
        Console.WriteLine("2 - Direito");
        int opcaoCurso = int.Parse(Console.ReadLine()!);
        #endregion
        #region Atribuir valores a lista
        Curso cursoAluno = (opcaoCurso == 1) ? new Curso("SI", "Descrição 1", 1000) : new Curso("DI", "Descrição 2", 2145);
        Aluno novoAluno = new Aluno(cpf, nome, rg, endereco, matricula, cursoAluno);
        pessoas.Add(novoAluno);
        #endregion
        Console.WriteLine("\nAluno cadastrado com sucesso!");
    }
}