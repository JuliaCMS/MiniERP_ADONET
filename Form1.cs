using System.Data;
using System.Windows.Forms;

namespace MiniERPAdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.tipo = comboBoxTipo.Text;
            produto.tamanho = comboBoxTamanho.Text;
            produto.cor = comboBoxCor.Text;
            produto.preco = decimal.Parse(textBoxPreco.Text);
            produto.quantidadeEstoque = int.Parse(textBoxQuantidade.Text);
            produto.fornecedor = int.Parse(textBoxCNPJVinculo.Text);

            if (produto.gravarProduto())
            {
                MessageBox.Show("Produto(s) adicionado(s) com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar produto(s)!");
            }
        }

        private void buttonMostrarFornecedores_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string sql = "select * from fornecedores";
            DataTable dt = new DataTable();
            dt = db.executarConsultaGenerica(sql);
            dataGridViewFornecedores.DataSource = dt;
        }

        private void buttonAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.nome = textBoxNomeFornecedor.Text;
            fornecedor.cnpj = textBoxCNPJVinculo.Text;
            fornecedor.endereco = textBoxEndFornecedor.Text;
            fornecedor.telefone = textBoxTelFornecedor.Text;

            if (fornecedor.gravarFornecedor())
            {
                MessageBox.Show("Fornecedor adicionado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar fornecedor!");
            }
        }
    }
}