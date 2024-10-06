using MediatR;
using OnlineStore.Core.Feautres.CustomerCQRS.Queries.ResponseQueries;
using OnlineStore.Core.Wrappers;
using OnlineStore.Data.Enums;

namespace OnlineStore.Core.Feautres.PatientCQRS.Queries.ModelsQueries
{
    public class GetListCustomerPaginatedQuery : IRequest<PaginatedResult<GetCustomerPaginatedListResopnse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public CustomerOrderingEnum OrderBy { get; set; }
        public string? Search { get; set; }
    }
}
