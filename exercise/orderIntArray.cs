/*
Tomando el array indicado en la plantilla, generar un array de igual longitud 
con los números ordenados.
Visualizar por consola el array con la secuencia ordenada 
 */

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-- Se establece la secuencia de números
            int[] secuenciaNumeros = { 5, 9, 16, 7, 2, 6, 20, 4, 32, 19 };

            //--- 1º se crea un array de la misma longitud que la secuencia de números
            int[] secuenciaNumerosOrdenados = new int [secuenciaNumeros.Length];
            //Console.WriteLine($"{secuenciaNumerosOrdenados.Length}");     10
                                                                     
            //--- 2º se ordena sobre el array creado el contenido del array secuenciaNumeros
            for (int i = 0; i < secuenciaNumerosOrdenados.Length; i++)
            {
                secuenciaNumerosOrdenados[i] = secuenciaNumeros[i];
            }

            for (int i = 0; i < secuenciaNumerosOrdenados.Length - 1; i++)
            {
                for (int x = i+1; x < secuenciaNumerosOrdenados.Length ; x++)
                {
                    if (secuenciaNumeros[x] < secuenciaNumerosOrdenados[i])
                    {
                        int temporal = secuenciaNumerosOrdenados[i];
                        secuenciaNumerosOrdenados[i] = secuenciaNumerosOrdenados[x];
                        secuenciaNumerosOrdenados[x] = temporal;
                    }
                }
            }

            //--- 3º se visualiza en consola el contenido del array con los números ordenados
            for (int z = 0; z < secuenciaNumerosOrdenados.Length - 1; z++)
            {
                Console.WriteLine($"{secuenciaNumerosOrdenados[z]}");
            }
            //-- Fin programa
        }
    }
}
