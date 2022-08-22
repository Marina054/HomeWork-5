// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

class Program
{   
     static void Main (string [] args)
     {
        
        int []array = new int [4];
        FillArray (array);
        PrintArray(array);
        Console.WriteLine();
    
        int count = 0;
       
        for (int i = 0; i < array.Length; i++)
        
        if (array[i] % 2! == 1)
        count++;
        
        Console.WriteLine($"{count} не чётные");

        int sum =0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2! == 1)
            {
                sum += array[i];
            }

        }
        Console.WriteLine ($"Сумма не четных чисел: {sum}");

    static void FillArray(int[]array)
    {
        int length = array.Length;
        int index =0;
        while (index < length)
        {
            array [index] = new Random ().Next (10,100);
            index ++;
        }
    }    
        
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