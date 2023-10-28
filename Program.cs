using System.Net.Security;

internal class Program
{
    private static void Main(string[] args)
    {
        int [] ar;
       
        Console.Write("Enter The array:");
         string a=Console.ReadLine();
        int[] output;
        Console.WriteLine("The array is:" + a);
        


    
           {
            int[] array = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original array:");
            PrintArray(array);

            ReverseArray(array);

            Console.WriteLine("\nReversed array:");
            PrintArray(array);
        }

        static void ReverseArray(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length / 2; i++)
            {
                // Swap the elements at index i and (length - 1 - i)
                int temp = arr[i];
                arr[i] = arr[length - 1 - i];
                arr[length - 1 - i] = temp;
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (var element in arr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("i Didnt Write this program");
       }
    



}
}