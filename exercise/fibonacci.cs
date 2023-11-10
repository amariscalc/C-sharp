using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PAC_Desarrollo_Entrega_1S2324
{
    public class Program
    {
        static void Main(string[] args)
        {
            //--- Declaracion de variables
            int numero = 0;
            int[] sec_fibo;


            //------------------------------------------------------------------------------------------ Ejecución libre del programa

            //-------------------------- Se valida que el número introducido sea correcto
            do
            {
                Console.Write("Inserta el número elementos de Fibonacci a calcular: ");
                numero = Int32.Parse(Console.ReadLine());

            } while (NumeroValido(numero) == false);

            //-------------------------- Se obtiene la secuencia Fibonacci
            sec_fibo = SecuenciaFibo(numero);

            //-------------------------- Se obtiene la secuencia Fibonacci invertida
            sec_fibo = SecuenciaReverse(sec_fibo);
          
            //-------------------------- Se obtiene la primera posición donde aparece el número que más veces está en el array
            Console.WriteLine(PosicionNumeroMasVisto(sec_fibo));

            //--- Fin de la ejecución del programa
            Console.ReadKey();
        }

        public static bool NumeroValido(int numero)
        {
            if (numero >= 3 && numero <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int[] SecuenciaFibo(int numero)
        {
            // Creación array cuya longitud se recibe por parámetro en la función
            int[] arrayFibo = new int[numero];
       
            /* Loop for para poblar el array, comprobamos si estamos en la primera,
               segunda o consecutivas vueltas. Asignamos valor fijo en las dos primeras posiciones y apartir de
               la tercera aplicamos la lógica de cálculo de la secuencia fibonacci. */
            for (int i = 0; i < arrayFibo.Length; i++) 
            { 
                if (i == 0)
                {
                    arrayFibo[i] = 0;
                }
                else if (i == 1)
                {
                    arrayFibo[i] = 1;
                }
                else
                {
                    arrayFibo[i] = arrayFibo[i-2]+ arrayFibo[i-1];
                }
            }
            return arrayFibo;
        }

        public static int[] SecuenciaReverse(int[] directo)
        {
            // Crear un nuevo array con la misma longitud que la original
            int[] reverso = new int[directo.Length];

            // Usar loop for para poblar el nuevo array con el orden inverso de los valores
            for (int i = 0; i < reverso.Length ; i++)
            {
                reverso[i] = directo[directo.Length-1-i];
            }
            return reverso;
        }

        public static string PosicionNumeroMasVisto(int[] arr_secuencia)
        {
            //--- Se inicializan variables
            int posicion = 0;
            int valor = 0;
            int recuento = 0;
            int recuento_numeros_unicos = 0;

            // Se comprueba cuantos elementos unicos hay en el array par
            for (int i = 0; i < arr_secuencia.Length ; i++)
            {
                bool num_unico = true;
                for (int j = 0;j < i; j++)
                {
                    if (arr_secuencia[i] == arr_secuencia[j])
                    {
                        num_unico = false;
                        break;
                    }
                }
                if (num_unico)
                {
                    recuento_numeros_unicos++;
                }
            }
            // Se crea un array bidimensional para contabilizar las veces que aparece un número
            // este array debe ser de tal longitud como numeros unicos hay en el array de entrada.
            int[,] arr_cont = new int[recuento_numeros_unicos, 2];

            // Recorrer el array original y comprobar si se ha añadido al array bidimensional, en caso negativo lo añadimos
            int fila = 0;
            for (int i = 0; i < arr_secuencia.Length; i++)
            {
                bool existe = false;
                for (int j = 0; j < fila; j++)
                {
                    if (arr_cont[j,0] == arr_secuencia[i])
                    {
                        existe = true;
                        arr_cont[j, 1]++;
                        break;
                    }
                }
                if (!existe)
                {
                    arr_cont[fila,0] = arr_secuencia[i];
                    arr_cont[fila,1] = 1;
                    fila++;
                }
            }
              
            for (int i = 0; i < fila; i++)
            {
                if (arr_cont[i, 1] > recuento)
                {
                    posicion = i;
                    valor = arr_cont[i,0];
                    recuento = arr_cont[i, 1];
                }
            }

            /* Siempre va a entrar en el if y lo único que va a cambiar es "posicion" ya que el único que se repite es
               el "1" y la posicion al ser un array de los valores ordenador de forma inversa va a variar, pero
               "valor" y "recuento" van a contener siempre el mismo valor final.*/
            if (recuento > 1)
            {
                return "El valor " + valor + " se repite " + recuento + " veces según la posicion " + posicion + " del array bidimensional.";
            }
            else
            {
                return "Todos los valores de la secuencia aparecen por igual.";
            }
        }
    }
}
