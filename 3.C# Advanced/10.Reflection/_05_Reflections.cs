using System.Reflection;

namespace _10.Reflection
{
    class _05_Reflections
    {
        void ThisIsMain()
        {
            MemberInfo info = typeof(AnotherClass);

            object[] attributes = info.GetCustomAttributes(true);

            foreach (var item in attributes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
