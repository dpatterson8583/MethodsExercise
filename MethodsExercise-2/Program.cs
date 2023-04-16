using System.ComponentModel;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var name = Console.ReadLine();

            var result = Add(10, 20, 5);
            Console.WriteLine(result);

            var res2 = Subtract(20, 5, 5);
            Console.WriteLine(res2);

            var res3 = Multiply(1, 2, 3, 4);
            Console.WriteLine(res3);

            var res4 = Divide(12, 5);
            Console.WriteLine(res4);

            var res5 = Modulus(23, 5);
            Console.WriteLine(res5);

            Console.ReadLine();
        }

        public static int Add(params int[] list)
        {
            int res=0;

            for(int i=0; i<list.Length; i++)
            {
                res = res + list[i];
            }
            return res;
        }

        public static int Subtract(params int[] list)
        {
            //First number is the total to be subtracted from initially.
            int res = list[0];

            for (int i = 1; i < list.Length; i++)
            {
                res = res - list[i];
            }
            return res;
        }

        public static int Multiply(params int[] list)
        {
            int res = 1;

            for (int i = 0; i < list.Length; i++)
            {
                res = res * list[i];
            }
            return res;
        }

        public static double Divide(params int[] list)
        {
            int res = list[0];

            for (int i = 1  ; i < list.Length; i++)
            {
                res = res / list[i];
            }
            return res;
        }

        public static int Modulus(params int[] list)
        {
            int res = list[0];

            for (int i = 1; i < list.Length; i++)
            {
                res = res % list[i];
            }
            return res;
        }
    }
}