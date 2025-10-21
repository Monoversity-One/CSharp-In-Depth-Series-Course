namespace _10.Object_OrientedProgramming._99.Examples._06_ElectricalDevices
{
    public class Radio : ElectricalDevice
    {
        public Radio(bool isOn, string brand) : base(isOn, brand)
        {
        }

        //method to listen to the radio
        public void ListenRadio()
        {
            //first check if the radio is on
            if (IsOn)
            {
                Console.WriteLine("Listening to the Radio!");
            }
            else
            {
                Console.WriteLine("Radio is switched off, switch it of first.");
            }
        }
    }
}
