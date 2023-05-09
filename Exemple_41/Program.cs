// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int SummPositivDigits(int[] array)
{
    int sum =0;
    for(int i =0; i< array.Length; i++)
    {
        if(array[i] > 0) sum++;
    }
    return sum;
}

int[] FillArray(int size)
{
    int[] array = new int[size];
    for(int i =0; i<size; i++)
    {
        array[i] = EnterData("Введите данные массива");
    }
    return array;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return(Convert.ToInt32(Console.ReadLine()));
}

int size = EnterData("Введите размер массива: ");
int[] array = FillArray(size);
Console.Write($"[{String.Join(", ", array)}] элементов массива больше 0 -> ");
Console.WriteLine(SummPositivDigits(array));



  
