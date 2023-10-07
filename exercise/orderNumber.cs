/*
Crea un diagrama de flujo que cumpla con las siguientes especificaciones:

Se solicita por consola 3 números enteros. Se guardan sobre las variables A, B y C.
Se muestran por pantalla de forma ordenada de mayor a menor.

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
