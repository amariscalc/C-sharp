int days = 0;
int years = 0;
int months = 0;
int weeks = 0;
int days_rest = 0;
bool daysValidate = false;

do
{
    try
    {
        Console.Write("Please, enter the days: ");
        days = Int32.Parse(Console.ReadLine());
        daysValidate = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("Incorrect input");
        daysValidate = false;
    }
} while (daysValidate == false);

// Divido numero entre 365 días para obtener los años
years = days / 365;
days_rest = days % 365;
Console.WriteLine($"Years: {years}");

// El numero restante de días lo divido por 30 para obtener los meses
months = days_rest / 30;
days_rest = days_rest % 30;
Console.WriteLine($"Months: {months}");

// El número restante de días lo divido entre 7 y obtengo las semanas
weeks = days_rest / 7;
Console.WriteLine($"Weeks: {weeks}");
// El resto son los días sueltos
days_rest = days_rest % 7;
Console.WriteLine($"Days: {days_rest}");
