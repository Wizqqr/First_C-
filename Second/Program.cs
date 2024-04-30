// программа -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// Console.WriteLine("Type some number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int count = -num;

// while(count <= num)
// {
//     Console.Write(count + " ");
//     count ++;
//     count += 1;
// }


Console.WriteLine("Type some number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 0)
{
    int count = -num;
    
    while (count <= num)
    {
        Console.Write(count + " ");
        count++;
    }
}
else
{
    Console.WriteLine("Ошибка ввода");
}







