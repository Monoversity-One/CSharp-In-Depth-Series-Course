using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace _03.ExceptionHandlingAndErrorLogging
{
	public class ExceptionPerformanceBenchmark
	{
		public static void Run()
		{
			// Runs the annotated [Benchmark] methods in this class via BenchmarkDotNet.
			var summary = BenchmarkRunner.Run<ExceptionPerformanceBenchmark>();
		}

		[Benchmark]
		public void ExceptionsWithCatchBlock()
		{
			for (int i = 0; i < 100; i++)
			{
				try
				{
					CatchBlockImpl();
				}
				catch
				{

				}
			}
		}

		public void CatchBlockImpl()
		{
			try
			{
				MWithException();
			}
			catch (Exception e)
			{
				Debug.WriteLine($"Exception catch {e.Message}");
				throw;
			}
		}

		[Benchmark]
		public void ExceptionsWithFilter()
		{
			for (int i = 0; i < 100; i++)
			{
				try
				{
					FilterImpl();
				}
				catch
				{

				}
			}
		}

		public void FilterImpl()
		{
			try
			{
				MWithException();
			}
			catch (Exception e) when (Log(e)) { }

			bool Log(Exception e)
			{
				Debug.WriteLine($"Exception filter {e.Message}");
				return false;
			}
		}

		static void MWithException() => throw new Exception("Bamm");
	}
}
