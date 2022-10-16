Console.WriteLine("Введите два числа ");

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("max = {0}, min = {1}", num1, num2);
}
else 
    if (num1 == num2)
{
    Console.WriteLine("Введенные числа равны");
}
else
Console.WriteLine("max = {1}, min = {0}", num1, num2);