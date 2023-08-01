public class Produto
{
    public int codigo { get; set; }
    public string descricao { get; set; }
    public double lucro { get; set; }
    public double valordevenda { get; set; }
    public double precoaquisicao { get; set; }


    public Produto()
    {

    }

    public Produto(int codigo, string descricao, double lucro, double valordevenda, double precoaquisicao)
    {
        this.codigo = codigo;
        this.descricao = descricao;
        this.lucro = lucro;
        this.valordevenda = valordevenda;
        this.precoaquisicao = precoaquisicao;
    }
}