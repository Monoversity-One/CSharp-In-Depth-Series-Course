namespace _04.DelegatesAndEvents
{
    // Delegate declaration
    public delegate void EventHandler(object sender, EventArgs e);



    // Publisher class with event
    public class Button
    {
        // Event declaration
        public event EventHandler Click;

        // Method to simulate button click
        public void SimulateClick()
        {
            Console.WriteLine("Button clicked!");
            OnClick(EventArgs.Empty);
        }

        // Method to raise the event
        protected virtual void OnClick(EventArgs e)
        {
            Click?.Invoke(this, e); // Invoke the event
        }
    }



    // Subscriber classes
    public class Display1
    {
        public void Subscribe(Button button)
        {
            // Subscribe to the button's Click event
            button.Click += HandleClick;
        }

        // Event handler method
        private void HandleClick(object sender, EventArgs e)
        {
            Console.WriteLine("Display1 received button click event.");
        }
    }



    public class Display2
    {
        public void Subscribe(Button button)
        {
            // Subscribe to the button's Click event
            button.Click += HandleClick;
        }

        // Event handler method
        private void HandleClick(object sender, EventArgs e)
        {
            Console.WriteLine("Display2 received button click event.");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating instances
            Button button = new Button();
            Display1 display1 = new Display1();
            Display2 display2 = new Display2();



            // Subscribers subscribe to the button's Click event
            display1.Subscribe(button);
            display2.Subscribe(button);



            // Simulate button click
            button.SimulateClick();



            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
