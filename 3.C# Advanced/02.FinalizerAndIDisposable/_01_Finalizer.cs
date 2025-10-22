using System.Threading;
namespace _02.FinalizerAndIDisposable
{
	class SampleClass
	{
		~SampleClass()
		{
			FinalizerDemo.PrintThreadInfo("Finalizer", Thread.CurrentThread);
		}

        public int MyProperty { get; internal set; }
    }

	class FinalizerDemo
	{
		public static void Run()
		{
			PrintThreadInfo("Main", Thread.CurrentThread);

			var sampleInstance = new SampleClass();
			sampleInstance = null;
						
			GC.Collect();
			// Ensure finalizers have a chance to run before continuing (demo visibility).
			GC.WaitForPendingFinalizers();
			Console.ReadKey();
		}

		public static void PrintThreadInfo(string str, Thread thread)
		{
			Console.WriteLine($"{str} Priority: {thread.Priority}");
			Console.WriteLine($"{str} ManagedThreadId: {Thread.CurrentThread.ManagedThreadId}");
		}
	}
}
