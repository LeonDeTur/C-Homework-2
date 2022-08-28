Console.WriteLine("Введите номер дня недели (от 1 до 7).");
int numA = Convert.ToInt32(Console.ReadLine());

if (numA < 1 || numA > 7)
{
    Console.WriteLine("Такого дня недели нет");
} 
else
{
    if (numA < 6)
    {
        Console.WriteLine("Введённый день недели не является выходным");
    }
    else
    {
        Console.WriteLine("Введённый день выходной");
    }
}