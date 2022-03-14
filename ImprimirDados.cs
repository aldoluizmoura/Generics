using ClassesGenericas.Domain;

namespace ClassesGenericas
{
    public static class ImprimirDados
    {
        public static void ImprimirItens<T>(this List<T> entidades) where T : Entity
        {
            if (entidades.Count == 0)
            {
                Console.WriteLine($"Lista de {typeof(T).Name} vázia");
            }

            foreach (var item in entidades)
            {
                Console.WriteLine(item);
            }
        }
    }
}
