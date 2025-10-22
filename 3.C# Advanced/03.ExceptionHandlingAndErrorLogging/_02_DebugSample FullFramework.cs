using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace _03.ExceptionHandlingAndErrorLogging
{

	class GetCallStack
	{
		public static void M(Object o)
		{
			// .NET 6: Thread.Suspend/Resume and cross-thread stack capture are unsupported/unsafe.
			// Capture the current thread's stack trace instead for this demo.
			var s = new StackTrace(true);
			Console.WriteLine("======StackTrace=====");
			Console.WriteLine(s.ToString());
			Console.WriteLine("");
		}
	}

	class DebugSampleFullFrameworkDemo
	{
		public static void Run()
		{
			var stateTimer = new Timer(GetCallStack.M, null, 1000, 0);
			A();
			Console.ReadKey();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static void A()
		{
			B_WithExceptionHandler();
		}

		static void B_WithFilter()
		{
			try
			{
				C();
			}
			catch (Exception e) when (Log(e)) { }
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static void B_WithExceptionHandler()
		{
			try
			{
				C();
			}
			catch (Exception e)
			{
				Log(e);
				throw;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static void C()
		{
			var dateTime = DateTime.UtcNow;
			throw new Exception("Bamm");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static bool Log(Exception e)
		{
			Console.WriteLine($"Exception: {e.Message}");
			//Thread.Sleep(50000000);
			return false;
		}
	}
}
