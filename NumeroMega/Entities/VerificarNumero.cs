using System;
using System.Collections.Generic;

namespace NumeroMega.Entities
{
    internal class VerificarNumero
    {
        public List<int> GerarNumero(int numeroTotal)
        {
            var aleatorio = new Random();
            List<int> listaNumeros = new List<int>();
            int numero;

            for (int i = 1; i <= numeroTotal; i++)
            {
                do
                {
                    numero = aleatorio.Next(1, 61);
                } while (listaNumeros.Contains(numero));
                listaNumeros.Add(numero);
                Console.WriteLine(numero);
            }
            return listaNumeros;
        }
    }
}