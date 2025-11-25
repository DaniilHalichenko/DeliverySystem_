namespace DeliverySystem_.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Constructor_NewOrder_CreatesPendingOrder()
        {
            var order = new Order(100);

            Assert.Equal(OrderStatus.Pending, order.Status);
        }

        [Fact]
        public void ChangeStatus_ValidStatus_UpdatesStatus()
        {
            var order = new Order(100);

            order.ChangeStatus(OrderStatus.Shipped);

            Assert.Equal(OrderStatus.Shipped, order.Status);
        }

        [Fact]
        public void ApplyDiscount_PercentageDiscount_LowersPrice()
        {
            var order = new Order(200);

            order.ApplyDiscount(10);

            Assert.Equal(180, order.Price);
        }

        [Fact]
        public void ApplyDiscount_DiscountGreaterThan100_SetsPriceToZero()
        {
            var order = new Order(100);

            order.ApplyDiscount(150);

            Assert.Equal(0, order.Price);
        }
    }
}