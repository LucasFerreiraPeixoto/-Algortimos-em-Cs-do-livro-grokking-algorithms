using System;
using System.Collections.Generic;

namespace Atividade4._2
{
    //4.2- Escreva uma função recursiva para que conte o número de itens uma lista.

    internal class Program
    {
        static void Main(string[] args)
        {
            //Criamos uma lista dinâmica em vez de um array fixo.
            List<int> listaNumeros = new List<int> { 10, 20, 30 };
            // Chamamos a função e mostramos o resultado na tela.
            Console.WriteLine($"O número de valores desta lista é: {contar(listaNumeros)}");
        }

        /// <summary>
        /// Esta função percorre a lista de forma recursiva para contar quantos elementos ela possui.
        /// </summary>
        public static int contar(List<int> lista,int i = 0,int alto = 0)
        {
         //Condição de parada
         if (i >= lista.Count){return 0;}

         //Recursão, aqui é criado uma pilha (LIFO) para somar e retornar a quantidade de itens na lista.
         return 1 + contar(lista, i + 1);
        }
    }
}
