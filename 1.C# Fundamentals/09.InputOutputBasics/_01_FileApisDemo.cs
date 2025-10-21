namespace _09.InputOutputBasics
{
    public static class _01_FileApisDemo
    {
        public static void Demo()
        {
            var path = @"C:\\temp\\example.txt";

            Console.WriteLine("Exists? " + File.Exists(path));
            Console.WriteLine("Directory? " + Directory.Exists(Path.GetDirectoryName(path)!));

            // Non-destructive examples of common APIs
            Console.WriteLine("Change extension: " + Path.ChangeExtension(path, ".log"));
            Console.WriteLine("Combine: " + Path.Combine(Path.GetDirectoryName(path)!, "sub", "file.txt"));

            // Using FileInfo and DirectoryInfo for metadata (do not perform write/delete)
            var fi = new FileInfo(path);
            Console.WriteLine($"Name={fi.Name}, Dir={fi.DirectoryName}, Exists={fi.Exists}");

            var di = new DirectoryInfo(Path.GetDirectoryName(path)!);
            Console.WriteLine($"DirName={di.FullName}, Exists={di.Exists}");
        }
    }
}
