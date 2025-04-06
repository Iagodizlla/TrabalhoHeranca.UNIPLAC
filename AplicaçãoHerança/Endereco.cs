using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AplicacaoHeranca;
public class Endereco
{
    public string Rua { get; set; }
    public int Numero { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string Cep { get; set; }
    // construtor com parâmetros opcionais
    public Endereco(string rua = "", int numero = 0, string bairro = "", string cidade = "", string estado = "", string cep = "")
    {
        Rua = rua;
        Numero = numero;
        Bairro = bairro;
        Cidade = cidade;
        Estado = estado;
        Cep = cep;
    }
    public override string ToString()
    {
        return $"{Rua} - {Numero} - {Cidade}";
    }
}
//Iago Henrique Schlemper