// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int INput(string nameSpace)
{
    System.Console.WriteLine(nameSpace);
    int per1 = Int32.Parse(Console.ReadLine());
    return per1;
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int k = INput("Введите число");
        array[i] = k;
    }
}

int CountPositiv(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int length = INput("Введите количество чисел");
int[] masiv = new int[length];
FillArray(masiv);
Console.Write(string.Join(",", masiv));
System.Console.WriteLine();
Console.WriteLine($"Количество положительных чисел = {CountPositiv(masiv)}");

