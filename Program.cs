using System;

namespace Aula24ObjetosArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();

            Produto    p1 = new Produto(1, "Dark Souls Remastered", 129.90f);
            Produto    p2 = new Produto(2, "Dark Souls II", 89.90f);
            Produto    p3 = new Produto(3, "Dark Souls III", 140.90f);
            Produto    p4 = new Produto(4, "Sekiro: Shadows Die Twice", 130.90f);

            cart.Adicionar(p1);
            cart.Adicionar(p2);
            cart.Adicionar(p3);
            cart.Adicionar(p4);

            cart.Remover(p1);

            Produto p5 = new Produto(4, "Dark Souls I", 89.9f);
            cart.Alterar(p5, 4);

            cart.Ler();

            cart.MostrarTotal();

        }
    }
}
