using System;

namespace Atividade4._1
{
    //4.1- Escreva o código da função soma vista anteriormente

    internal class Program
    {
        static void Main(string[] args)
        {
            // Imagine que estes são os números que o usuário digitou.
            int[] numeros = { 1, 2, 3, };
            // Chamamos a função e mostramos o resultado na tela.
            Console.WriteLine($"O resultado da soma dos valores deste array é: {soma(numeros)}"); 

        }

        /// <summary>
        /// Esta função soma os números usando a recursividade.
        /// </summary>
        public static int soma(int[] arr, int i = 0) 
        {
            //Condição de parada
            if (i >= arr.Length) return 0;
            //Recursão, aqui é criado uma pilha (LIFO) de somas até chegar ao fim.
            return arr[i] + soma(arr, i + 1); 
        }
    }
}
