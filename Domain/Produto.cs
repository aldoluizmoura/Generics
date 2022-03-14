namespace ClassesGenericas.Domain
{
    public class Produto : Entity
    {
        public Produto(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }      
        public string Nome{ get; set; }
        public decimal Valor{ get; set; }

        public override string ToString()
        {
            return $"{Id} | {Nome} | {Valor}";
        }

        public override bool Equals(Object? obj)
        {
            var produto = obj as Produto;

            if (produto == null) return false;

            return produto.Id == Id;
        }

    }

}
