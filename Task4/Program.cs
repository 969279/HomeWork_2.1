Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

int num1 = 0;

while (num1 < number - 1)
{
    num1 = num1 + 2;
    Console.Write(num1 + ", ");
}
