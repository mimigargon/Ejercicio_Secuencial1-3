using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Secuencial1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] array3 = new int[10];

            Random randomNum = new Random();
            for(int i = 0; i < array1.Length; i++)
            {
                array1[i] = randomNum.Next(19);
                array2[i] = randomNum.Next(49);
                array3[i] = array1[i] * array2[i];
                
                Console.WriteLine($"Here comes the array: {array3[i]}");
            }

        }
    }
}
