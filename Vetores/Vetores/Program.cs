using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)


        {
            //Exercicio 2 - Implemente uma função que receba um array de inteiros e retorne o segundo maior valor contido neste parâmetro de entrada
            int[] vet = new int[] { 5,8,4,9,10,33 };
            Console.WriteLine("Meu vetor é:{0} {1} {2} {3} {4} {5}", vet[0], vet[1], vet[2], vet[3], vet[4], vet[5]);

            //Ordenar do menor para o maior
            for (int i=0; i<vet.Length; i++)
            {
                for(int j=0; j<vet.Length-1-i; j++)
                {
                    if (vet[j] > vet[j + 1]) 
                    {
                        int aux = vet[j + 1];
                        vet[j + 1] = vet[j];
                        vet[j] = aux;
                    }
                }
            }
            //Escreve meu vetor ordenado
            for (int i = 0; i < vet.Length; i++)
                Console.WriteLine(vet[i]);

            //Retorna o segundo maior valor
            Console.WriteLine("O segundo maior valor é:" +vet[vet.Length-2]);

           




        }
        

    }
}
