using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AplicacaoHeranca;
public class Professor : Funcionario // herança, Professor é uma subclasse de Funcionario que é uma subclasse de Pessoa que é uma subclasse de Object
{
    public string Titulacao { get; set; }
    public string Area { get; set; }
    // construtor com parâmetros opcionais e uso de construtor da classe base
    public Professor(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, decimal salario = 0, string matricula = "", string titulacao = "", string area =
    "") : base(nome, cpf, rg, logradouro, salario, matricula)
    {
        // os atributos da classe base são herdados e inicializados pelo construtor da classe base
        // atributos específicos da classe derivada
        Titulacao = titulacao;
        Area = area;
    }
    // implementa membro abstrato herdado "Pessoa.RetornarDados()
    public override List<(string campo, string valor)> RetornarDados()
    {
        // cria uma lista de tuplas com os dados do aluno, utilizando variavel temporaria embutida para criar a lista de tuplas
        return new List<(string campo, string valor)>
        {
            ("Nome", Nome), ("Cpf", Cpf), ("Rg", Rg), ("Rua", Logradouro.Rua),
            ("Numero", Logradouro.Numero.ToString()), ("Bairro", Logradouro.Bairro), ("Cidade", Logradouro.Cidade),
            ("Estado", Logradouro.Estado), ("Cep", Logradouro.Cep.ToString()),
            ("Salário", Salario.ToString()), ("Matricula", Matricula.ToString()),
            ("Titulacao", Titulacao), ("Area", Area)
        };
    }
    public override string ToString()
    {
        return $"{Nome} - {Titulacao} - {Matricula}";
    }
}
//Iago Henrique Schlemper