using ClassesGenericas.Domain;

namespace ClassesGenericas.Data
{
    public interface IRepositorio<T> where T : Entity
    {
        void Adicionar(T entidade);
        List<T> ObterTodos();
    }
}
