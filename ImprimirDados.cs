using ClassesGenericas.Domain;

namespace ClassesGenericas
{
    public static class ImprimirDados
    {
        public static void ImprimirProdutos(List<Produto> produtos)
        {
            if (produtos.Count == 0)
            {
                Console.WriteLine("Lista de Produtos vázia");
            }

            foreach (var item in produtos)
            {
                Console.WriteLine(item);
            }
        }

        public static void ImprimirCategorias(List<Categoria> categorias)
        {
            if (categorias.Count == 0)
            {
                Console.WriteLine("Lista de Categorias vázia");
            }

            foreach (var item in categorias)
            {
                Console.WriteLine(item);
            }
        }
    }
}
