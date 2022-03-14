namespace ClassesGenericas.Domain
{
    public class Categoria
    {
        public Categoria(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"{Id} | {Nome}";
        }

        public override bool Equals(Object? obj)
        {
            var categoria = obj as Categoria;

            if (categoria == null) return false;

            return categoria.Id == Id;

        }
    }
}
