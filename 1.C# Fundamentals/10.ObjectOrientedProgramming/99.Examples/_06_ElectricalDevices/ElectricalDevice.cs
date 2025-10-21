namespace _10.Object_OrientedProgramming._99.Examples._06_ElectricalDevices
{
    public class ElectricalDevice
    {
        //boolean to determine the state of the device
        public bool IsOn { get; set; }

        //string for the brand name of the device
        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        //switch on the device
        public void SwitchOn()
        {
            IsOn = true;
        }

        //switch off the device
        public void SwitchOff()
        {
            IsOn = false;
        }
    }
}
