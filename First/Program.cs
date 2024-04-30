// Программа проверки квадрата

Console.Write("Could you write a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Could you write second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2)
{
    Console.WriteLine("Your first number is the square of second number");
}
else
{
    Console.WriteLine("Your first number is not the square of second number");
}
