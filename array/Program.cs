using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        
       static void SecondArrayWithIF(string[] array1, string[] array2)
        {
            int count = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i].Length <= 3)
                {
                    array2[count] = array1[i];
                    count++;
                }
            }
        }
       static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        
        
        static void Main(string[] args)
        {
            string[] array1 = new string[5] { "victoria", "Alex",  "Arina", "Sam", "Vlad" };
            string[] array2 = new string[array1.Length];
            SecondArrayWithIF(array1, array2);
            PrintArray(array2);
        }
    }
}
