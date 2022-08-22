// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

class Program
{
    public static void Main (string[]args)
    {
        int [] array =  {3,7,22,2,78};
        PrintArray(array);
        Console.WriteLine(" ");
        Console.WriteLine("Вывод Max и Min значения массива");
        int min = array[0];
        int max = array[0];
        
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i]< min)
                min = array[i];
            if (array[i]> max)
                max = array[i];    
        }
        Console.WriteLine ($"Min: {min}");
        Console.WriteLine ($"Max: {max}");
        Console.WriteLine("Вывод разницы Max и Min значения");
        Console.Write($"max - min = {max - min}");

        static void PrintArray (int[]array)
        {
        int count = array.Length;
        int position = 0;
        while (position <count)
        {
            Console.Write(array[position]+" ");
            position ++;
        }
        
        }
    }
}
