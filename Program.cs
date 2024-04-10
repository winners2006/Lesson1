using System.Collections;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
			//Дан массив и число. Найдите три числа в массиве сумма которых равна искомому числу.
            //Подсказка: если взять первое число в массиве, можно ли найти в оставшейся его части два числа равных по сумме первому.
            //
            int[] array = { 1, 2, 3, 10, 12, 53, 6, 25, 9, 11, 7, 5 };

            int nam = 34;

            var s = new HashSet<int>();

            foreach (int i in array)
            {
                var x = nam - i;
                if (s.Contains(x))
                    Console.WriteLine($"{x} + {i} = {x+i}");
                else 
                    s.Add(i);
            }
		}
	}
}