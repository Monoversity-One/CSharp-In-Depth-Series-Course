using _03.GenericsAndCollections.Generics;

namespace _03.GenericsAndCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using generics with List<T>
            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Blue");

            Console.WriteLine("List Example:");
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine();



            // Using generics with Dictionary<TKey, TValue>
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "John Doe");
            students.Add(2, "Jane Smith");
            students.Add(3, "Mike Johnson");

            Console.WriteLine("Dictionary Example:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            }
            Console.WriteLine();



            // Using generics with Queue<T>
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Item 1");
            queue.Enqueue("Item 2");
            queue.Enqueue("Item 3");

            Console.WriteLine("Queue Example:");
            while (queue.Count > 0)
            {
                string item = queue.Dequeue();
                Console.WriteLine($"Dequeued item: {item}");
            }
            Console.WriteLine();



            // Using generics with HashSet<T>
            HashSet<int> numbers1 = new HashSet<int>();
            numbers1.Add(1);
            numbers1.Add(2);
            numbers1.Add(3);
            numbers1.Add(1); // Adding duplicate

            Console.WriteLine("HashSet Example:");
            foreach (var numb in numbers1)
            {
                Console.WriteLine(numb);
            }
            Console.WriteLine();



            var numbers = new GenericList<int>();
            numbers.Add(10);  //Add takes an int

            var books = new GenericList<Book>();
            books.Add(new Book()); //Add take a book

            var account = new GenericDictionnary<int, string>();

            /*---------------------------------*/
            var number = new _03.GenericsAndCollections.Generics.Nullable<int>(5);
            Console.WriteLine("Has Value ?: " + number.HasValue);
            Console.WriteLine("Value : " + number.GetValueOrDefault());


            var num = new _03.GenericsAndCollections.Generics.Nullable<int>();
            Console.WriteLine("Has Value ?: " + num.HasValue);
            Console.WriteLine("Value : " + num.GetValueOrDefault());

            Console.ReadLine();

            //Nullable is part of the .Net

        }
    }
}
