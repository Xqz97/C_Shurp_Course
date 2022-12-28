/*  Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
    сколько чисел больше 0 ввёл пользователь.
    0, 7, 8, -2, -2 -> 2
    -1, -7, 567, 89, 223-> 3
*/

int count = 0;
for (; ;)
{
    string a;
    a = Console.ReadLine();
    if (a == string.Empty)
        {
            Console.WriteLine($"Количество чисел больше 0: {count}");
            break;
        }
    else if (int.Parse(a) > 0)
        {
            count++;
        }
}

