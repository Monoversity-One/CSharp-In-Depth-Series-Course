namespace _10.Object_OrientedProgramming._99.Examples
{
    class CustomerManager
    {
        //public string Id;//field
        public int İD { get; set;}//property örneği. Özellik tanımlıcaksak bunu kullanırız field değil.**prop yazıp taba bas iki kere.
        //public int FirstName { get; set; }//elle yazılmış versiyonu.Get ve set in içine istediğin özelliği yazbilirsin.
        public void add() { Console.WriteLine("Customer added!"); }
    }
}
