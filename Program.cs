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
                int[] trainArray = new int[n];
                for (int x = 0; x < trainArray.Length; x++)
                {
                    trainArray[m] = rnd.Next(0, 37);
                    Console.WriteLine(trainArray[m]);
                }
                int sum = 0;
                foreach (int value in trainArray)
                {
                    sum = sum + value;
                }
                Console.WriteLine("Сумма элементов массива: " + sum); // GJXTVEEEEEEEEEEE!!!!!!!!!!!!!!!!!!!!!!
                int cmp1 =0;
                for (int c = 0; c < sum; c++)
                {
                    int complect =0;
                    complect = sum - 8;
                    Console.WriteLine(c);
                    c = cmp1;
                }
                decimal rulon = 0;
                cmp1 = Convert.ToDecimal(cmp1);
                rulon = Math.Ceiling(cmp1 / 100);
                Console.WriteLine("Количество рулонов: " + rulon);
            }
        }
    }
}