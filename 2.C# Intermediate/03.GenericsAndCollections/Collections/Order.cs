namespace _03.GenericsAndCollections.Collections
{
    public class Order
    {
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }

        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }

        public void ProcessOrder()
        {
            Console.WriteLine($"Order {OrderId} processed!");
        }

        public static Order[] ReceiveOrdersFromBranch1()
        {
            Order[] orders = new Order[]
            {
                new Order(1, 5),
                new Order(2, 10),
                new Order(6, 15),
            };

            return orders;
        }

        public static Order[] ReceiveOrdersFromBranch2()
        {
            Order[] orders = new Order[]
            {
                new Order(3, 15),
                new Order(4, 20),
                new Order(5, 30),
            };

            return orders;
        }
    }
}
