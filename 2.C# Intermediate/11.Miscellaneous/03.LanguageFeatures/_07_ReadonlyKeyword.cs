namespace _11.Miscellaneous._03.LanguageFeatures
{
    class _07_ReadonlyKeyword
    {
        void ThisIsMain()
        {

        }
    }
    class ReadonlyClassEx
    {
        //Readonly fields can't be used in assigning values , and
        //set in properties
        readonly string animalName;
        public string AnimalName
        {
            get => animalName;
            //Error
            //set => animalName = value;
        }
        public ReadonlyClassEx(string name)
        {
            animalName = name;
        }

    }
}
