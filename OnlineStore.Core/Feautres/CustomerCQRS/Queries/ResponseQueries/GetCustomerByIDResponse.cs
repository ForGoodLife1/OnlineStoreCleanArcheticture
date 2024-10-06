namespace OnlineStore.Core.Feautres.CustomerCQRS.Queries.ResponseQueries
{
    public class GetCustomerByIDResponse
    {
        public int CustomerId { get; set; }

        public string Name { get; set; } = null!;


        public string Address { get; set; } = null!;

        public decimal TotalAmount { get; set; }

    }

}
