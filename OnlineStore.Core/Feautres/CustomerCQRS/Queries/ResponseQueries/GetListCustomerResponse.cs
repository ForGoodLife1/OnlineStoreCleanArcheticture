namespace OnlineStore.Core.Feautres.PatientCQRS.Queries.ResponseQueries
{
    public class GetListCustomerResponse
    {
        public int CustomerId { get; set; }

        public string Name { get; set; } = null!;


        public string Address { get; set; } = null!;

        public decimal TotalAmount { get; set; }

    }
}
