namespace _02.FinalizerAndIDisposable
{
	class IDisposableDemo
	{
		public static void Run()
		{
			using (StreamReader streamReader = new StreamReader("sample.txt"))
			{
				var str = streamReader.ReadToEnd();
			}

			Console.WriteLine("Hello World!");
		}
	}
}
