using ClassesGenericas.Domain;

namespace ClassesGenericas.Data
{
    public class Repositorio<T> : IRepositorio<T> where T : Entity
    {
        private List<T> _lista { get; set; }

        public Repositorio()
        {
            _lista = new List<T>();
        }

        public void Adicionar(T entidade)
        {
            _lista.Add(entidade);
        }

        public List<T> ObterTodos()
        {
            return _lista;
        }
    }
}
