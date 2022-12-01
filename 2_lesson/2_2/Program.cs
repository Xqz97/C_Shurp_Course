// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

string Crat(int num1, int num2)
{
    if (num1 % num2 == 0)
    {
        return("кратно");
    }
    else
        return($"некратно, остаток от деления= {num1 % num2}");
}

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine(Crat(num1,num2));
