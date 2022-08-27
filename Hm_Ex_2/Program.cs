Console.WriteLine("Введите трёхзначное число");

int numA = Convert.ToInt32(Console.ReadLine());
int result = 0;

if (numA > 999 || numA < 99)
{
    Console.WriteLine("Число не трёхзначное");
}
else
{
    numA = (int)numA / 10;
    result = numA % 10;

    Console.WriteLine("Второе число: " + result);
}
