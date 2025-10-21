namespace _06.ArraysAndCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            Console.WriteLine("Arrays:");
            // Single-dimensional array
            int[] numbers = { 1, 2, 3, 4, 5 };



            // Accessing elements
            Console.WriteLine("Element at index 0: " + numbers[0]);
            Console.WriteLine("Element at index 2: " + numbers[2]);



            // Iterating through array
            Console.WriteLine("Iterating through array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Element at index " + i + ": " + numbers[i]);
            }



            // Multidimensional array
            int[,] matrix = new int[3, 2]
            {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 }
            };



            Console.WriteLine("\nMultidimensional array:");
            // Accessing elements
            Console.WriteLine("Element at row 1, column 0: " + matrix[1, 0]);



            // Iterating through multidimensional array
            Console.WriteLine("Iterating through multidimensional array:");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }



            // Collections (List example)
            Console.WriteLine("\nCollections (List):");
            // Using System.Collections.Generic
            var names = new System.Collections.Generic.List<string>();
            names.Add("Alice");
            names.Add("Bob");
            names.Add("Charlie");

            // Iterating through list
            Console.WriteLine("Iterating through list:");
            foreach (var name in names)
            {
                Console.WriteLine("Name: " + name);
            }

        }
    }
}
