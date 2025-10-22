namespace _01.RefAndSpan
{
	class SpanSample1Demo
	{
		public static void Run()
		{
			Span<byte> span = new Span<byte>(new byte[] { 2, 4, 4, 1 });
			var newSpan = span.Slice(1, 3);
			span[1] = 42;
		}
	}
}
