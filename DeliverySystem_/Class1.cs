namespace DeliverySystem_
{
    public class Class1
    {
        public enum OrderStatus
        {
            Pending,
            Shipped,
            Delivered
        }

        public class Order
        {
            public decimal Price { get; private set; }
            public OrderStatus Status { get; private set; }

            public Order(decimal price)
            {
                Price = price;
                Status = OrderStatus.Pending;
            }
        }
    }
}
