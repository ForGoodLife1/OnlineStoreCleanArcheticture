using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using OnlineStore.Core.Bases;
using OnlineStore.Core.Feautres.OrderCQRS.Queries.Models;
using OnlineStore.Core.Feautres.OrderCQRS.Queries.Responses;
using OnlineStore.Core.Resources;
using OnlineStore.Service.Abstracts;

namespace OnlineStore.Core.Feautres.OrderCQRS.Queries.Handlers
{
    public class OrderQueryHandler : ResponseHandler, IRequestHandler<GetOrderByIdQuery, Response<GetOrderByIdResponse>>
    {
        private readonly IOrderService _orderService;
        // private readonly IOrderItemService _orderItemService;
        private readonly IStringLocalizer<SharedResources> _stringLocalizer;
        private readonly IMapper _mapper;

        public OrderQueryHandler(IOrderService orderService,
                                 /*IOrderItemService orderItemService*//*,*/
                                 IStringLocalizer<SharedResources> stringLocalizer, IMapper mapper) : base(stringLocalizer)
        {
            _orderService=orderService;
            /*_orderItemService=orderItemService;*/
            _stringLocalizer=stringLocalizer;
            _mapper=mapper;
        }

        public async Task<Response<GetOrderByIdResponse>> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            //service Get By Id include St sub ins
            var response = _orderService.GetOrderByIdAsync(request.Id);
            //check Is Not exist
            if (response==null) return NotFound<GetOrderByIdResponse>(_stringLocalizer[SharedResourcesKeys.NotFound]);
            //mapping 
            var mapper = _mapper.Map<GetOrderByIdResponse>(response);
            //pagination
            /*Expression<Func<OrderItem, OrderItemResponse>> expression = e => new OrderItemResponse(e.OrderId, e.Localize(e.NameAr, e.NameEn));
            var studentQuerable = _orderItemService.GetStudentsByDepartmentIDQuerable(request.Id);
            var PaginatedList = await studentQuerable.Select(expression).ToPaginatedListAsync(request.StudentPageNumber, request.StudentPageSize);
            mapper.StudentList = PaginatedList;

            // Log.Information($"Get Department By Id {request.Id}!");
            //return response
            return Success(mapper);*/
            return Success(mapper);
        }
    }
}
