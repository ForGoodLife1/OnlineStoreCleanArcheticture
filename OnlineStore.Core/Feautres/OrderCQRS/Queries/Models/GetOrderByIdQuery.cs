using MediatR;
using OnlineStore.Core.Bases;
using OnlineStore.Core.Feautres.OrderCQRS.Queries.Responses;

namespace OnlineStore.Core.Feautres.OrderCQRS.Queries.Models
{
    public class GetOrderByIdQuery : IRequest<Response<GetOrderByIdResponse>>
    {
        public GetOrderByIdQuery(int id)
        {
            Id=id;
        }

        public int Id { get; set; }

    }
}
