Console.WriteLine("Введите три числа ");

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int max1 = 0, max2 = 0;

if (num1 == num2 && num2 ==num3)
{
     Console.WriteLine("No max");
}
else {
if (num1 > num2)
    {
    max1 = num1;
    }
else max1 = num2;
if (num2 > num3)
    {
    max2 = num2;
    }
else max2 = num3;
if (max1 > max2)
    {
    Console.WriteLine("max = " + max1);
    }
else 
    Console.WriteLine("max = " + max2);
}
