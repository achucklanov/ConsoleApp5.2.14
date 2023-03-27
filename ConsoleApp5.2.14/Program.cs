namespace ConsoleApp5._2._14  // на основе задания 5.2.8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int len = 3;
            var array = GetArrayFromConsole(ref len);
            var sortedarray = SortArray(array);

            for (int i = 0; i < sortedarray.Length; i++)
            {
                Console.WriteLine(sortedarray[i]);
            }
            
            Console.ReadKey();

        }

        static int[] GetArrayFromConsole(ref int len)
        {
            len = 6;
            var result = new int [len];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        static int[] SortArray(int[] result)
        {

            int temp = 0;

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;
        }
    }
}