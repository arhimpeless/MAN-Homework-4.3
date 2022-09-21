namespace Задание_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                int sumBilet = 0;
                foreach (int value in trainArray)
                {
                    sumBilet = sumBilet + value;
                }
                //Console.WriteLine(sum);
                //Console.ReadKey();
                Console.WriteLine("Количество всех билетов: " + sumBilet + "\n");
                //Console.ReadKey();
                int summCmpl = sumBilet * 8;
                Console.WriteLine("Общий метраж ткани: " + summCmpl);
                double rulon = 0;
                //summCmpl = Convert.ToDecimal(summCmpl);
                //rulon = Math.Ceiling(summCmpl/ 100);
                rulon = summCmpl / 100.0;
                Console.WriteLine("Количество рулонов: " + rulon);
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}