namespace _10.Reflection
{
    class _07_GUID
    {
        void ThisIsMain()
        {
            //Guid : Creating uniq identifiers

            Guid guid = Guid.NewGuid();
            Console.WriteLine(guid);

            guid = Guid.NewGuid();
            Console.WriteLine(guid);
        }
    }
}
