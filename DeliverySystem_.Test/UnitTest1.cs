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
    }
}