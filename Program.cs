using System;
using System.Collections.Generic;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variaveis 
            string pedido1, removerItem, itemRemovido;
            string mostrarCarrinho;
            int Confirmacao, tempo;

            Random random = new Random();
            
            // Criando a lista
            List<string> pedidos = new List<string>();

            Console.WriteLine("Bem-vindo ao Programa de entregas");

            // loop para começar o programa
            while(true)
            {
                Console.WriteLine(@"Digite sua opção abaixo: 
1 - Adicionar pedido
2 - Ver carrinho
3 - Remover item
4 - Sair");
                Confirmacao = int.Parse(Console.ReadLine());

                // confirmando se digitou 1 
                if(Confirmacao == 1)
                {
                    Console.WriteLine("Digite o seu pedido: ");
                    pedido1 = Console.ReadLine().ToLower().Trim();
                    pedidos.Add(pedido1);

                    tempo = random.Next(10, 60);
                    Console.WriteLine($"Tempo estimado do pedido {pedido1}: {tempo} minutos");
                }
                else if(Confirmacao == 2)
                {
                    foreach(string item in pedidos)
                    {
                        Console.WriteLine(item);
                    } 
                
                }
                // removendo itens 
                else if(Confirmacao == 3)
                {
                    Console.WriteLine("Digite o item para ser removido: ");
                    itemRemovido = (Console.ReadLine()?? "").ToLower().Trim();
                    if(!pedidos.Contains(itemRemovido))
                     {
                        Console.WriteLine("Esse item nao pode ser removido porque ele nao existe na lista");
                    }
                    else
                    {
                        pedidos.Remove(itemRemovido);
                        Console.WriteLine("Item removido com sucesso!");
                    }
                }
                
                // saindo do programa
                else if(Confirmacao == 4)
                {
                    Console.WriteLine("Saindo do sistema...");
                    break;
                }
                else
                {
                    Console.WriteLine("Opação inválida!");
                }
            }
        }
    }
}