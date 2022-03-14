using ClassesGenericas.Domain;

namespace ClassesGenericas.Data
{
    public class ProdutoRepositorio
    {
        private List<Produto> _produtos { get; set; }

        public ProdutoRepositorio()
        {
            _produtos = new List<Produto>();
        }

        public void Adicionar(Produto produto)
        {
            _produtos.Add(produto);
        }

        public List<Produto> ObterTodos()
        {
            return _produtos;
        }
    }
}
