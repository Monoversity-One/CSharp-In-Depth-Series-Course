using System.Runtime.InteropServices;

namespace _02.FinalizerAndIDisposable
{
	class ImplementIDisposableAndFinalizerDemo
	{
		class SampleClass: IDisposable
		{
			IntPtr intPtr;
			StreamReader streamReader;


			public SampleClass()
			{
				try
				{
					// Original intent: allocate a large unmanaged buffer
					intPtr = Marshal.AllocHGlobal(1000000000);
				}
				catch (OutOfMemoryException)
				{
					// Fix: provide a safe fallback without removing the original code path
					intPtr = Marshal.AllocHGlobal(1_000_000);
				}
				streamReader = new StreamReader("sample.txt");
			}

			protected void Dispose(bool itIsSafeToAlsoFreeManagedObjects)
			{
				if (intPtr != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(intPtr);
					intPtr = IntPtr.Zero;
				}

				if (itIsSafeToAlsoFreeManagedObjects)
				{
					if (streamReader != null)
					{
						streamReader.Dispose();
						streamReader = null;
					}
				}
			}

			public void Dispose()
			{
				Dispose(true);
				GC.SuppressFinalize(this);
			}

			~SampleClass()
			{
				Dispose(false);
			}
		}

		public static void Run()
		{
			Console.WriteLine("Hello World!");
		}
	}
}
