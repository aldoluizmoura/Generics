namespace ClassesGenericas.Data
{
    public class ObjectRepositorio
    {
        private List<object> _objetos { get; set; }

        public ObjectRepositorio()
        {
            _objetos = new List<object>();
        }

        public void Adicionar(object categoria)
        {
            _objetos.Add(categoria);
        }

        public List<object> ObterTodos()
        {
            return _objetos;
        }
    }
}
