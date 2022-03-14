using ClassesGenericas;
using ClassesGenericas.Data;
using ClassesGenericas.Domain;

var produtoRepositorio = new ProdutoRepositorio();
var categoriaRepositorio = new CategoriaRepositorio();

produtoRepositorio.Adicionar(new Produto("TV", 1000));
produtoRepositorio.Adicionar(new Produto("DVD", 500));

produtoRepositorio.Adicionar(new Produto("Bola", 70));
produtoRepositorio.Adicionar(new Produto("Luva", 125));

categoriaRepositorio.Adicionar(new Categoria("Eletronicos"));
categoriaRepositorio.Adicionar(new Categoria("Esportes"));

ImprimirDados.ImprimirProdutos(produtoRepositorio.ObterTodos());
ImprimirDados.ImprimirCategorias(categoriaRepositorio.ObterTodos());
