using NumeroMega.Entities;
using System;

namespace NumeroMega
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VerificarNumero numero = new VerificarNumero();
            bool escolheuSair = false;

            while (!escolheuSair)
            {
                //basta marcar de 6 a 20 números dos 60 disponíveis
                Console.WriteLine("Mega da Virada - Boa sorte!");
                Console.WriteLine("1- JOGAR\n2- SAIR");

                try
                {
                    Console.Write("Informe a opção: ");
                    int opcaoEscolhida = int.Parse(Console.ReadLine());

                    if (opcaoEscolhida > 0 && opcaoEscolhida < 3)
                    {
                        switch (opcaoEscolhida)
                        {
                            case 1:
                                Console.Write("Informe quantos números irá jogar: ");
                                int qtdNumeros = int.Parse(Console.ReadLine());

                                if (qtdNumeros > 5 && qtdNumeros < 21)
                                {
                                    numero.GerarNumero(qtdNumeros);
                                    Console.WriteLine("\nPressione ENTER para continuar.");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Informe um valor correto!");
                                    Console.WriteLine("Obs: Forneça de 6 a 20 números.");
                                    Console.WriteLine("\nPressione ENTER para continuar.");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                break;
                            case 2:
                                escolheuSair = true;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n[OPÇÃO INVÁLIDA!]");
                        Console.WriteLine("\nPressione ENTER para continuar.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("\nUm erro ocorreu: " + e.Message);
                    Console.WriteLine("\nPressione ENTER para continuar.");
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    Console.WriteLine("\nPressione ENTER para continuar.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
