using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace _01.RefAndSpan
{
	[MemoryDiagnoser]
	public class StringParsingWithSpanBenchmark
	{
		public static void Run()
		{
			var summary = BenchmarkRunner.Run<StringParsingWithSpanBenchmark>();
		}


		[Benchmark]
		public static void ParseWithString()
		{
			var str = "This is a great course! You should give it a 5 star rating!";

			for (int i = 0; i < 100; i++)
			{
				Parse(str);
			}
		}

		[Benchmark]
		public static void ParseWithSpan()
		{
			var str = "This is a great course! You should give it a 5 star rating!";
			var charArray = str.ToCharArray();
			var span = new ReadOnlySpan<char>(charArray);
			for (int i = 0; i < 100; i++)
			{
				Parse(span);
			}

		}

		public static void Parse(String str)
		{
			var ratingStr = str.Substring(45, 1);
			if (Int32.TryParse(ratingStr, out int ratingInt))
			{
				Debug.WriteLine(ratingInt);
			}
		}

		public static void Parse(ReadOnlySpan<char> span)
		{
			var ratingSpan = span.Slice(45, 1);
			if (Int32.TryParse(ratingSpan, out int ratingInt))
			{
				Debug.WriteLine(ratingInt);
			}
		}
	}
}
