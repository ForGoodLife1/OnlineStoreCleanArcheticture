
using MediatR;
using OnlineStore.Core.Bases;
using OnlineStore.Core.Feautres.PatientCQRS.Queries.ResponseQueries;

namespace OnlineStore.Core.Feautres.PatientCQRS.Queries.ModelsQueries
{
    public class GetListCustomerQuery : IRequest<Response<List<GetListCustomerResponse>>>
    {
    }
}
