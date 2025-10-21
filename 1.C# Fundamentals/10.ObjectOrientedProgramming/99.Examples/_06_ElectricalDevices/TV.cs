namespace _10.Object_OrientedProgramming._99.Examples._06_ElectricalDevices
{
    public class TV: ElectricalDevice
    {
        public TV(bool isOn, string brand) : base(isOn, brand)
        {
        }

        //method to listen to watch TV
        public void WatchTV()
        {
            //first check if the TV is on
            if (IsOn)
            {
                Console.WriteLine("Watching TV!");
            }
            else
            {
                Console.WriteLine("TV is switched off, switch it of first.");
            }
        }
    }
}
