namespace _09.InputOutputBasics
{
    public static class _04_PathApisDemo
    {
        public static void Demo()
        {
            var path = @"C:\\Projects\\CSharpFundamentals\\HelloWorld\\HelloWorld.sln";

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));

            var combined = Path.Combine("C:\\temp", "folder", "file.txt");
            Console.WriteLine("Combined: " + combined);
        }
    }
}
