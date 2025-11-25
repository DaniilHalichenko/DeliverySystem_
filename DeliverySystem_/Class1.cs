using System.Diagnostics;

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

        public void ChangeStatus(OrderStatus newStatus)
        {
            Status = newStatus;
        }

        public void ApplyDiscount(decimal percent)
        {
            if (percent < 0) return;

            var discountAmount = Price * (percent / 100m);
            Price -= discountAmount;

            if (Price < 0)
                Price = 0;
        }

        public bool IsDelivered()
        {
            return Status == OrderStatus.Delivered;
        }
        
    }
}
