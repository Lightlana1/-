// int time = 11;
// while(time < 22) // пока
// {
//     time++;
//     Console.WriteLine("Ещё рано. Время" + time);
// }
// Console.WriteLine("пора спать. время" + time);
// Console.WriteLine(time);
//Является ли первое число квадратом второго
// int a = 5;
// int b = 25;
// if (b / a == a)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }
//
//или так, так лучше
// Console.WriteLine("Введите число 1");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if(number1 == number2 * number2)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }


//название дня недели по номеру
Console.WriteLine("Введите номер 3 или 5 ");
int a = Convert.ToInt32(Console.ReadLine());
if(a == 3)
{
    Console.WriteLine("Среда");
}
else
{
    Console.WriteLine("Пятница");
}

