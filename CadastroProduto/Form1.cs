namespace CadastroProduto
{
    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tx_cod.Clear();
            tx_descricao.Clear();
            tx_venda.Clear();
            tx_lucro.Clear();
            tx_preco.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

                Produto produto = new Produto();

                produto.codigo = Convert.ToInt32(tx_cod.Text);
                produto.precoaquisicao = Convert.ToDouble(tx_preco.Text);
                produto.lucro = Convert.ToDouble(tx_lucro.Text);
                produto.valordevenda = Convert.ToDouble(tx_venda.Text);
                produto.descricao = tx_descricao.Text;

                produtos.Add(produto);

            /*foreach(Produto s  in produtos)
            {
                MessageBox.Show($"Valor venda: {produto.valordevenda}\nDescricao: {produto.descricao}");
            }*/
        }
    }
}