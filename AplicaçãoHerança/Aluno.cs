using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AplicacaoHeranca;
public class Aluno : Pessoa // herança, Aluno é uma subclasse de Pessoa que é uma subclasse de Object
{
    public int Matricula { get; set; }
    public Curso CursoAluno { get; set; } // uso de delegação
                                          // construtor com parâmetros opcionais e uso de construtor da classe base
    public Aluno(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, int matricula = 0, Curso? cursoAluno = null) : base(nome, cpf, rg, logradouro)
    {
        // os atributos da classe base são herdados e inicializados pelo construtor da classe base
        // atributos específicos da classe derivada
        Matricula = matricula;
        CursoAluno = cursoAluno ?? new Curso();
    }
    // implementa membro abstrato herdado "Pessoa.RetornarDados()
    public override List<(string campo, string valor)> RetornarDados()
    {
        // cria uma lista de tuplas com os dados do aluno,
        // utilizando variável temporária embutida para criar a lista de tuplas
        return new List<(string campo, string valor)>
        {
            ("Nome", Nome),
            ("Cpf", Cpf),
            ("Rg", Rg),
            ("Rua", Logradouro.Rua),
            ("Numero", Logradouro.Numero.ToString()),
            ("Bairro", Logradouro.Bairro),
            ("Cidade", Logradouro.Cidade),
            ("Estado", Logradouro.Estado),
            ("Cep", Logradouro.Cep.ToString()),
            ("Matricula", Matricula.ToString()),
            ("Nome do Curso", CursoAluno.Nome),
            ("Descrição do Curso", CursoAluno.Descricao),
            ("Carga Horária", CursoAluno.CargaHoraria.ToString())
        };
    }
    public override string ToString()
    {
        return $"{Nome} - {Matricula} - {CursoAluno}";
    }
}
//Iago Henrique Schlemper