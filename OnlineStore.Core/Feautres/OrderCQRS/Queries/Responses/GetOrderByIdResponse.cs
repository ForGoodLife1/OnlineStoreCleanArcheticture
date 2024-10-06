namespace OnlineStore.Core.Feautres.OrderCQRS.Queries.Responses
{
    public class GetOrderByIdResponse
    {
        public DateTime OrderDate { get; set; }

        public decimal TotalAmount { get; set; }

        public short Status { get; set; }

        public List<OrderItemResponse>? OrderItemList { get; set; }

    }
    public class OrderItemResponse
    {
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal TotalItemsPrice { get; set; }
        public OrderItemResponse(int orderId, int productId, int quantity, decimal price, decimal totalItemsPrice)
        {
            OrderId=orderId;
            ProductId=productId;
            Quantity=quantity;
            Price=price;
            TotalItemsPrice=totalItemsPrice;
        }
    }

}

