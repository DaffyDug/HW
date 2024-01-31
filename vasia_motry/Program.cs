using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Threading.Channels;
class Program
{
    
    public static void Main(string[] args)
    {
        // Можно задавать любые значения ;)
        Sum([1,2,3,4]);

        MAXARR([90,1,2,3,4,10]);

        multiplicationARR([1, 2, 3, 4, 5]);

        averageARR([27,90]);
    }
    static int Sum(int[] arr)//Напишите МЕТОД, который ПРИНИМАЕТ в себя массив интов и ВОЗВРАЩАЕТ сумму всех элементов этого массива.
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine(sum);
        return sum;
    }
    static int MAXARR(int[] arr) //Напишите МЕТОД, который ПРИНИМАЕТ в себя массив интов и ВОЗВРАЩАЕТ минимальный элемент массива.
    {
        int max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        Console.WriteLine(max);
        return max;
    }
    static void multiplicationARR(int[] array)/*Напишите МЕТОД, который ПРИНИМАЕТ в себя массив интов и умножает
                                              каждый элемент массива на Метод не должен ничего возвращать.*/
    {
        int multiplication = 2;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] * multiplication;
            Console.Write(array[i]+" ");
            
        }
        Console.WriteLine(' ');

    }
    static void averageARR(int[] array) /*Напишите МЕТОД, который ПРИНИМАЕТ в себя массив интов и ВОЗВРАЩАЕТ среднее
                                        арифметическое всех элементов.*/
    {
        float average = 0;
        float averagearr=0;
        for(int i = 0;i<array.Length;i++)
        {
            average += array[i];
            averagearr=average / array.Length;
        }
        Console.WriteLine(averagearr);
    }
}