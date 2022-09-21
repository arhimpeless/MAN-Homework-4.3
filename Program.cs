namespace Задание_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 0;
            int n;
            Random rnd = new Random();
            while (true)
            {
                Console.WriteLine("Существует поезд с количеством вагонов N. ");
                Console.Write("Введите N: ");
                n = int.Parse(Console.ReadLine());
                //Console.WriteLine(n);
                //Console.ReadKey();

                int[] trainArray = new int[n];
                for (int x = 0; x < trainArray.Length; x++)
                {
                    trainArray[x] = rnd.Next(0, 37);
                    Console.WriteLine(trainArray[x]);
                }
                //Console.ReadKey();
                int sum = 0;
                foreach (int value in trainArray)
                {
                    sum = sum + value;
                }
                //Console.WriteLine(sum);
                //Console.ReadKey();
                Console.WriteLine("Сумма элементов массива: " + sum);
                Console.ReadKey();
                int summCmpl = sum * 8;
                int count = 0;
                for (int c = 0; 0 < summCmpl; c++)
                {
                    int x = 0;
                    summCmpl - 100;
                    c = count;
                }
                Console.WriteLine(count);
                //decimal rulon = 0;
                //cmp1 = Convert.ToDecimal(cmp1);
                //rulon = Math.Ceiling(cmp1 / 100);
                //Console.WriteLine("Количество рулонов: " + rulon);
            }
        }
    }
}