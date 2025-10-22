namespace _04.StructLayout
{
	struct Struct1
	{
		public byte b1;
		public double d1;
		public byte b2;
		public double d2;
		public byte b3;
	}

	struct Struct2
	{
		public double d1;
		public double d2;
		public byte b1;
		public byte b2;
		public byte b3;
	}

	class StructLayoutDemo
	{
		public static void Run()
		{
			// Requires 'unsafe' context; ensure project allows unsafe code when needed.
			unsafe
			{
				Console.WriteLine("Struct1: " + sizeof(Struct1));
				Console.WriteLine("Struct2: " + sizeof(Struct2));
			}
		}
	}
}
