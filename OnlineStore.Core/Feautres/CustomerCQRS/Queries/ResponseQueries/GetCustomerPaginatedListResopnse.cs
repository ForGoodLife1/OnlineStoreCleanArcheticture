namespace OnlineStore.Core.Feautres.CustomerCQRS.Queries.ResponseQueries
{
    public class GetCustomerPaginatedListResopnse
    {
        public GetCustomerPaginatedListResopnse(int customerId, string name, string address, decimal totalAmount)
        {
            CustomerId=customerId;
            Name=name;
            Address=address;
            TotalAmount=totalAmount;
        }

        public int CustomerId { get; set; }

        public string Name { get; set; } = null!;


        public string Address { get; set; } = null!;

        public decimal TotalAmount { get; set; }
    }
}
