// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



class Program
{   
     static void Main (string [] args)
     {
        
        int []array = new int[3];
        FillArray (array);
        PrintArray(array);
        Console.WriteLine();
    
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        
        if (array[i] % 2 == 0)
        count++;
        
        
        Console.WriteLine($"{count} чётные");
       
    static void FillArray(int[]array)
    {
        int length = array.Length;
        int index =0;
        while (index < length)
        {
            array [index] = new Random ().Next (100,999);
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