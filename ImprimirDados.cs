using ClassesGenericas.Domain;

namespace ClassesGenericas
{
    public static class ImprimirDados
    {
        public static void ImprimirItens(List<object> objetos)
        {
            if (objetos.Count == 0)
            {
                Console.WriteLine($"Lista de {objetos.GetType().Name} vázia");
            }

            foreach (var item in objetos)
            {
                Console.WriteLine(item);
            }
        }
    }
}
