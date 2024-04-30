// 456 => 10
// 4 + 6 = 10

Console.WriteLine("Введите трехзначное число: ");
int num = Conver.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    int firstDigit = num / 100; // 456 / 10 = 4.56
    int lastDigit = num % 10; // 456 % 10 = 450 + 6
    int result = firstDigit + lastDigit;

    Console.WriteLine($"Sum of the first and the last number of your number = " + result);
}
else
{
    Console.WriteLine("error")
}