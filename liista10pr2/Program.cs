using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista10pr2
{
    internal class Program
    {
        public static void Exercicio1()
        {


            int[] vet2;
            float menorinv, maiorinv;

            menorinv = float.MaxValue;
            maiorinv = float.MinValue;


            Console.WriteLine("ENTRE COM O TAMANHO DOS VETORES:");
            int t = int.Parse(Console.ReadLine());

            vet2 = new int[t];
            Random rand = new Random();

            float soma = 0;

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);
                soma = soma + vet2[i];


                float total = vet2[i];
                if (total > maiorinv)
                {
                    maiorinv = total;
                }
                if (total > menorinv)
                {
                    menorinv = total;
                }

            }

            Console.WriteLine("A maior quantia investida é {0} no produto {1}", maiorinv);
            Console.WriteLine("A menor quantia investida é {0} no produto {1}", menorinv);

            Console.WriteLine("A MÉDIA ARITIMETICA É: " + soma / (float)t);

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("POSIÇÃO[{0}] = {1}", i, vet2[i]);
            }

        }
        public static void Exercicio2()
        {

            int[] vet2;
            Console.WriteLine("ENTRE COM O TAMANHO DOS VETORES:");
            int t = int.Parse(Console.ReadLine());

            vet2 = new int[t];
            Random rand = new Random();

            float soma = 0;

            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);
                soma = soma + vet2[i];
            }

            Console.WriteLine("A MÉDIA ARITIMETICA É: " + soma / (float)t);

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("POSIÇÃO[{0}] = {1}", i, vet2[i]);
            }

        }
        public static void Exercicio3()
        {

            Console.Write("Informe o tamanho do vetor (N): ");
            int n = int.Parse(Console.ReadLine());

            while (n <= 0)
            {
                Console.WriteLine("Valor de N inválido. Informe novamente.");
                Console.Write("Informe o tamanho do vetor (N): ");
                n = int.Parse(Console.ReadLine());
            }

            int[] vetor = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                vetor[i] = random.Next(100); // Gera números aleatórios de 0 a 99
            }

            int soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += vetor[i];
            }

            double media = (double)soma / n;

            Console.WriteLine("Números maiores ou iguais à média:");

            for (int i = 0; i < n; i++)
            {
                if (vetor[i] >= media)
                {
                    Console.WriteLine(vetor[i]);
                }
            }

        }
        public static void Exercicio4()
        {

            Console.Write("Informe a quantidade de nomes a serem inseridos: ");
            int n = int.Parse(Console.ReadLine());

            List<string> nomes = new List<string>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Informe o nome: ");
                string nome = Console.ReadLine();
                nomes.Add(nome);
            }

            Console.WriteLine("Nomes inseridos:");

            for (int i = nomes.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(nomes[i]);

            }

        }
        public static void Exercicio5()
        {

            float somapa = 0, somaimpa = 0;
            int[] vet2;
            Console.WriteLine("ENTRE COM O TAMANHO DOS VETORES:");
            int t = int.Parse(Console.ReadLine());

            vet2 = new int[t];
            Random rand = new Random();



            for (int i = 0; i < t; i++)
            {
                vet2[i] = rand.Next(10, 50);


                if (vet2[i] % 2 == 0)
                {

                }
                else
                {
                    somaimpa = somaimpa + vet2[i];
                }
            }

            Console.WriteLine(" A SOMA DOS NUMEROS PARES É: {0}, E A DOS NUMEROS IMPARES É: {1}", somapa, somaimpa);


            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("POSIÇÃO[{0}] = {1}", i, vet2[i]);
            }



        }

        static void Main(string[] args)
        {
            int MENU;

            do
            {

                Console.WriteLine("==========MENU==========");
                Console.WriteLine("1- EXERCÍCIO 1");
                Console.WriteLine("2- EXERCÍCIO 2");
                Console.WriteLine("3- EXERCÍCIO 3");
                Console.WriteLine("4- EXERCÍCIO 4");
                Console.WriteLine("5- EXERCÍCIO 5");
                Console.WriteLine("=======================");

                MENU = int.Parse(Console.ReadLine());

                switch (MENU)
                {

                    case 1:
                        Exercicio1();
                        break;

                    case 2:
                        Exercicio2();
                        break;

                    case 3:
                        Exercicio3();
                        break;

                    case 4:
                        Exercicio4();
                        break;

                    case 5:
                        Exercicio5();
                        break;

                    default:
                        Console.WriteLine("Número inválido");
                        break;



                }

                Console.ReadKey();

            } while (MENU != 0);
        }
    }
}
