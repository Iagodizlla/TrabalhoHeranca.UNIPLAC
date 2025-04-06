using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AplicacaoHeranca;
public class Coordenador : Funcionario // herança, Coordenador é uma subclasse de Funcionario que é uma subclasse de Pessoa que é uma subclasse de Object
{
    public string SenhaAlarme { get; set; }
    // construtor com parâmetros opcionais e uso de construtor da classe base
    public Coordenador(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, decimal salario = 0, string matricula = "", string senha = "") : base(nome, cpf,
    rg, logradouro, salario, matricula)
    {
        // os atributos da classe base são herdados e inicializados pelo construtor da classe base
        // atributos específicos da classe derivada
        SenhaAlarme = senha;
    }
    // implementa membro abstrato herdado "Pessoa.RetornarDados()
    public override List<(string campo, string valor)> RetornarDados()
    {
        // cria uma lista de tuplas com os dados do aluno,
        // utilizando variavel temporaria embutida para criar a lista de tuplas
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
            ("Salário", Salario.ToString()),
            ("Matricula", Matricula.ToString()),
            ("Senha", SenhaAlarme)
        };
    }
    public override string ToString()
    {
        return $"{Nome} - {Matricula}";
    }
}
//Iago Henrique Schlemper