int days=0;
int years=0;
int months=0;
int weeks = 0;
int days_rest=0;
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
}while (daysValidate == false);

// Divido numero entre 365 días para obtener los años
years = days / 365;
// Al número total de días le resto los días usados para calcular los años
days_rest = days - (years * 365);
Console.WriteLine($"Years: {years}");
// El numero restante de días lo divido por 30 para obtener los meses
months = days_rest / 30;
// Al resto de dias le resto los días usados en definir los meses
days_rest = days_rest - (months * 30);
Console.WriteLine($"Months: {months}");
// El número restante de días lo divido entre 7 y obtengo las semanas
weeks = days_rest / 7;
Console.WriteLine($"Weeks: {weeks}");
// El resto son los días sueltos
days_rest = days_rest - (weeks * 7);
Console.WriteLine($"Days: {days_rest}");
