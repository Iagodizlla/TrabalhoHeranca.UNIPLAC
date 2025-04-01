namespace ClassesHeranca;
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
}