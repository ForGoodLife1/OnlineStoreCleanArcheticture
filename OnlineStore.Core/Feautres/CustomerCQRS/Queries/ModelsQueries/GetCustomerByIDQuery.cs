using MediatR;
using OnlineStore.Core.Bases;
using OnlineStore.Core.Feautres.CustomerCQRS.Queries.ResponseQueries;

namespace OnlineStore.Core.Feautres.CustomerCQRS.Queries.ModelsQueries
{
    public class GetCustomerByIDQuery : IRequest<Response<GetCustomerByIDResponse>>
    {
        public int ID { get; set; }
        public GetCustomerByIDQuery(int id)
        {
            ID=id;
        }
    }
}
