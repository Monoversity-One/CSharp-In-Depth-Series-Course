using System.Runtime.InteropServices;

namespace _04.StructLayout
{
	class StructLayoutAttributeDemo
	{
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		struct Struct1
		{
			public byte b1;
			public double d1;
			public byte b2;
			public double d2;
			public byte b3;
		}

		class C { }

		[StructLayout(LayoutKind.Explicit)]
		// LayoutKind.Explicit overlays fields at the same offset (union-like behavior).
		struct Union
		{
			[FieldOffset(0)]
			public byte b;
			[FieldOffset(0)]
			public int i;
			[FieldOffset(0)]
			public bool boolean;
		}

		public static void Run()
		{
			Union u = new Union();
			u.i = 42;
			Console.WriteLine(u.boolean);
			u.boolean = false;
			int b = u.i;

			unsafe
			{
				Console.WriteLine("Union: " + sizeof(Union));
			}
		}
	}
}
