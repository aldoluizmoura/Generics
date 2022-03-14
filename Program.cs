using ClassesGenericas;
using ClassesGenericas.Data;
using ClassesGenericas.Domain;
using Microsoft.Extensions.DependencyInjection;

var provider = ConfigurarInjecaoDependecia();

var produtoRepositorio = provider.GetRequiredService<IRepositorio<Produto>>();
var categoriaRepositorio = provider.GetRequiredService<IRepositorio<Categoria>>();

produtoRepositorio.Adicionar(new Produto("TV", 1000));
produtoRepositorio.Adicionar(new Produto("DVD", 500));

produtoRepositorio.Adicionar(new Produto("Bola", 70));
produtoRepositorio.Adicionar(new Produto("Luva", 125));

categoriaRepositorio.Adicionar(new Categoria("Eletronicos"));
categoriaRepositorio.Adicionar(new Categoria("Esportes"));

produtoRepositorio.ObterTodos().ImprimirItens();
categoriaRepositorio.ObterTodos().ImprimirItens();

var primeiroProduto = produtoRepositorio.ObterTodos()[0];
var primeiraCategoria = categoriaRepositorio.ObterTodos()[0];

Console.WriteLine(primeiroProduto);
Console.WriteLine(primeiraCategoria);

ServiceProvider ConfigurarInjecaoDependecia()
{
    var serviceCollection = new ServiceCollection();

    serviceCollection.AddScoped(typeof(IRepositorio<>), typeof(Repositorio<>));

    return serviceCollection.BuildServiceProvider();
}