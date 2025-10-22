using System.Diagnostics;

namespace _02.FinalizerAndIDisposable
{
	class SampleClass2
	{
		public int MyProperty { get; set; }
		~SampleClass2()
		{
			try
			{
				long sum = 0;
				Random rnd = new Random();
				int __iterations = 0;
				while (true)
				{
					sum += rnd.Next(-2, 2);
					// safety: keep finalizer bounded to avoid hanging the finalizer thread
					if (++__iterations > 100000) break;
				}
			}
			catch
			{
				// swallow to avoid bringing down the finalizer thread in demo
			}
		}
	}

	class FinalizerGCDemo
	{
		public static void Run()
		{
			var rnd = new Random();
			int __iterations = 0;
			while (true)
			{
				var sampleInstance = new SampleClass() { MyProperty = rnd.Next() };
				Debug.WriteLine((object?)sampleInstance.MyProperty);
				GC.SuppressFinalize(sampleInstance);
				GC.ReRegisterForFinalize(sampleInstance);
				// safety: avoid hanging the app forever
				if (++__iterations > 10000)
				{
					GC.Collect();
					GC.WaitForPendingFinalizers();
					break;
				}
			}

			Console.ReadKey();
		}
	}
}
