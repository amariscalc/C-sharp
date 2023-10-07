/*
Crea un diagrama de flujo que cumpla con las siguientes especificaciones:

Se solicita por consola 3 números enteros. Se guardan sobre las variables A, B y C.
Se determina cuál de los 3 números es el mayor
Se muestra en salida el mayor de los 3 valores (no es necesario determinar qué variable tiene el mayor de los valores)
*/
double A = 0, B = 0, C = 0;

Console.Write("Enter the first number: ");
A = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second number: ");
B = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the third number: ");
C = Convert.ToDouble(Console.ReadLine());

if (A >= B)
{
    if (A >= C)
    {
        if (B >= C)
        {
            Console.WriteLine ($"{A}, {B}, {C}");
        }
        else
        {
            Console.WriteLine ($"{A}, {C}, {B}");
        }
    }
    else
    {
            Console.WriteLine ($"{C}, {A}, {B}");
    }
}
else
{
    if (B >= C)
    {
        if (A >= C)
        {
            Console.WriteLine ($"{B}, {A}, {C}");
        }
        else
        {
            Console.WriteLine ($"{B}, {C}, {A}");
        }
    }
    else
    {
        Console.WriteLine ($"{C}, {B}, {A}");
    }
}
