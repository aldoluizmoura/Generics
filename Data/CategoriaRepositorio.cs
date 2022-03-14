using ClassesGenericas.Domain;

namespace ClassesGenericas.Data
{
    public class CategoriaRepositorio
    {
        private List<Categoria> _categorias { get; set; }

        public CategoriaRepositorio()
        {
            _categorias = new List<Categoria>();
        }

        public void Adicionar(Categoria categoria)
        {
            _categorias.Add(categoria);
        }

        public List<Categoria> ObterTodos()
        {
            return _categorias;
        }
    }
}
