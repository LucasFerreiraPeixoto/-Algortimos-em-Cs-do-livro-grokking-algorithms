using System;
using System.Collections.Generic;

namespace Atividade4._2
{
   //4.3- Encontre o valor mais alto da lista
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criamos uma lista dinâmica em vez de um array fixo.
            List<int> listaNumeros = new List<int> { 10, 20, 30 };
            // Chamamos a função e mostramos o resultado na tela.
            Console.WriteLine($"O valor mais alto desta lista é: {buscarMaior(listaNumeros)}");
        }

        /// <summary>
        /// Esta função percorre a lista de forma recursiva para determinar qual o maior elemento contido nela.
        /// </summary>
        public static int buscarMaior(List<int> lista, int i = 0, int maiorAteAgora = int.MinValue) //<-- Usamos o MinValue para pegar o menor valor inteiro possível.
        {
            //Condição de parada onde retorna qual o maior valor da lista
            if (i >= lista.Count){return maiorAteAgora;};

            //Comparação entre o valor atual e o maior valor até agora.
            if (lista[i] > maiorAteAgora)
            {
                maiorAteAgora = lista[i];
            }

            //Recursão, aqui é criado uma pilha (LIFO) para se realizar as comparações.
            return buscarMaior(lista, i +1, maiorAteAgora);
        }
    }
}
