Console.WriteLine("Введите число с тремя цифрами или больше");
int numA = Convert.ToInt32(Console.ReadLine());

while (numA > 999)
{
    numA = numA/10;
}

if (numA < 100)
{
    Console.WriteLine("Введённое число двузначное или меньше");
}
else
{
    numA = numA % 10;
    Console.WriteLine("Третья цифра: " + numA);
}
