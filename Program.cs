namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, -3, -5, -7, 8, 9 };
            Console.WriteLine(args.Length);
            foreach (int j in arr)
            {
                Console.WriteLine(j);
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < 0)
                    {
                        arr[i] = -arr[i];
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }

}