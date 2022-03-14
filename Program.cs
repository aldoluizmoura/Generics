using ClassesGenericas;
using ClassesGenericas.Data;
using ClassesGenericas.Domain;

var produtoRepositorio = new Repositorio<Produto>();
var categoriaRepositorio = new Repositorio<Categoria>();

produtoRepositorio.Adicionar(new Produto("TV", 1000));
produtoRepositorio.Adicionar(new Produto("DVD", 500));

produtoRepositorio.Adicionar(new Produto("Bola", 70));
produtoRepositorio.Adicionar(new Produto("Luva", 125));

categoriaRepositorio.Adicionar(new Categoria("Eletronicos"));
categoriaRepositorio.Adicionar(new Categoria("Esportes"));

ImprimirDados.ImprimirItens(produtoRepositorio.ObterTodos());
ImprimirDados.ImprimirItens(categoriaRepositorio.ObterTodos());

var primeiroProduto = produtoRepositorio.ObterTodos()[0];
var primeiraCategoria = categoriaRepositorio.ObterTodos()[0];

Console.WriteLine(primeiroProduto);
Console.WriteLine(primeiraCategoria);
