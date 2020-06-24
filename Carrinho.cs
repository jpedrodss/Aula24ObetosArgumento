using System.Collections.Generic;
using System;

namespace Aula24ObjetosArgumento
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto _produto){
            carrinho.Add(_produto);
        }

        public void Remover(Produto _produto){
            carrinho.Remove(_produto);
        }

        public void Ler(){
            foreach (Produto item in carrinho){
                System.Console.WriteLine($"{item.Nome}, R${item.Preco}.");
            }
        }
        
        public void Alterar(Produto _produtoAlterado, int _codigo){
            carrinho.Find(z => z.Codigo == _codigo).Nome = _produtoAlterado.Nome;
            carrinho.Find(z => z.Codigo == _codigo).Preco = _produtoAlterado.Preco;
        }

        public void MostrarTotal(){
            foreach (Produto item in carrinho){
                ValorTotal += item.Preco;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            
            System.Console.WriteLine($"\nValor total dos jogos no carrinho: R${ValorTotal}");

            Console.ResetColor();
        }
    }
}