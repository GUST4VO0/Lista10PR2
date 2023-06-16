using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista10PR2
{
    internal class Program
    {
        public static void Exercicio1()
        {
            Console.Write("Digite o tamanho do vetor ");
            int tama = int.Parse(Console.ReadLine());

            float[] num = new float[tama];

            for (int i = 0; i < tama; i++)
            {
                Console.Write("Digite a quantidade de numeros colocados no vetor  ");
                num[i] = float.Parse(Console.ReadLine());
            }

            float menor = num[0];

            float maior = num[0];

            float soma = num[0];

            for (int i = 1; i < tama; i++)
            {
                if (num[i] < menor)
                {
                    menor = num[i];
                }

                if (num[i] > maior)
                {

                    maior = num[i];

                }


                soma += num[i];
            }

            float media = soma / tama;

            Console.WriteLine("Seu menor número é: {menor}");



            Console.WriteLine("Seu maior número é: {maior}");



            Console.WriteLine("A média aritmética é: {media}");

        }

        public static void Exercicio2()
        {

            int tama1;

            do
            {
                Console.Write("digite o tamanho do vetor(é obrigatorio ser um número maior que 0) ");
                tama1 = int.Parse(Console.ReadLine());

            } while (tama1 <= 0);

            float[] nume = new float[tama1];

            for (int i = 0; i < tama1; i++)
            {
                Console.Write("Digite a quantidade de numeros colocados no vetor ");
                nume[i] = float.Parse(Console.ReadLine());
            }

            float soma = 0;

            for (int i = 0; i < tama1; i++)
            {
                soma += nume[i];
            }

            float media = soma / tama1;

            Console.WriteLine("Números maiores ou iguais à média:");

            for (int i = 0; i < tama1; i++)
            {
                if (nume[i] >= media)
                {
                    Console.WriteLine(nume[i]);
                }
            }
        }
        public static void Exercicio3()
        {
            int tama2;
            do
            {
                Console.Write("digite o tamanho do vetor(é obrigatorio ser um número maior que 0) ");
                tama2 = int.Parse(Console.ReadLine());


            } while (tama2 <= 0);

            float[] nume1 = new float[tama2];

            Random random = new Random();

            for (int i = 0; i < tama2; i++)
            {
                nume1[i] = (float)random.NextDouble();
            }

            float soma = 0;

            for (int i = 0; i < tama2; i++)
            {
                soma += nume1[i];
            }

            float media = soma / tama2;

            Console.WriteLine("Números maiores ou iguais à média:");

            for (int i = 0; i < tama2; i++)
            {
                if (nume1[i] >= media)
                {
                    Console.WriteLine(nume1[i]);
                }
            }
        }


        public static void Exercicio4()
        {
            int Nassinaturas;

            do
            {
                Console.Write("Digite o número de assinaturas: ");
                Nassinaturas = int.Parse(Console.ReadLine());


            } while (Nassinaturas <= 0);

            List<string> ass = new List<string>();

            for (int i = 0; i < Nassinaturas; i++)

            {
                Console.Write("Digite o nome das assinaturas : ");
                string nome = Console.ReadLine();
                ass.Add(nome);
            }

            Console.WriteLine("Assinaturas --- do último ao primeiro:");

            for (int i = ass.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(ass[i]);

            }
        }






        public static void Exercicio5()
        {
            int tama3;

            do
            {
                Console.Write("digite o tamanho do vetor(é obrigatorio ser um número maior que 0)");
                tama3 = int.Parse(Console.ReadLine());


            } while (tama3 <= 0);

            int[] vetor = new int[tama3];

            Random random = new Random();

            int pares = 0;
            int impares = 0;

            for (int i = 0; i < tama3; i++)

            {
                vetor[i] = random.Next(100);

                if (vetor[i] % 2 == 0)

                {
                    pares++;
                }
                else


                {
                    impares++;
                }
            }

            Console.WriteLine("Vetor produzido:");

            for (int i = 0; i < tama3; i++)
            {
                Console.Write(vetor[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine($"Quantidade de números ímpares: {impares}");

            Console.WriteLine($"Quantidade de números pares: {pares}");

        }



        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine(">>>>MENU<<<<");
                Console.WriteLine("Para sair digite 0");
                Console.WriteLine("Exercicio 1");
                Console.WriteLine("Exercicio 2");
                Console.WriteLine("Exercicio 3");
                Console.WriteLine("Exercicio 4");
                Console.WriteLine("Exercicio 5");
                Console.WriteLine(">>>>><<<<<<");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("tchau, obrigado");
                        break;
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
                }
            } while (opcao != 0);

        }

    }






}





