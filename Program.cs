// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]
class Program
{
    static void Main(string[] args)
    {
        int n = 123;
        int[] array = new int[n];
        int count = 0; 
        for (int i = 0; i < n; i++)
        {
            array[i] = new Random().Next();
            Console.Write(array[i] + " ");
            if (array[i] > 9 && array[i] < 100)
            {
                count = count + 1;
            }
        }
        Console.Write(count);        
    }
}

// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве
class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array1 = new int[n];
        for (int i = 0; i < n; i++)
        {
            array1[i] = new Random().Next();
            //Console.Write(array1[i] + " ");
        }
        int j = 1;
        int[] array2 = new int[n/2];
        for (int i = 0; i < n/2; i++)
        {
            array2[i] = array1[i] * array1[array1.Length-j];
            j++;
            Console.Write(array2[i] + " ");
        }
    }
}