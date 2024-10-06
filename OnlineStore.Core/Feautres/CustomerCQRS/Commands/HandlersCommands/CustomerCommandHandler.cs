
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using OnlineStore.Core.Bases;
using OnlineStore.Core.Feautres.CustomerCQRS.Commands.ModelsCommands;
using OnlineStore.Core.Resources;
using OnlineStore.Data.Entities;
using OnlineStore.Service.Abstracts;

namespace OnlineStore.Core.Feautres.CustomerCQRS.Commands.HandlersCommands
{
    public class CustomerCommandHandler : ResponseHandler
                                       , IRequestHandler<AddCustomerCommand, Response<String>>
                                       , IRequestHandler<DeleteCustomerCommand, Response<String>>
                                       , IRequestHandler<EditCustomerCommand, Response<String>>
    {
        #region Fields
        private readonly ICustomerService _CustomerService;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;
        #endregion
        #region Constructors
        public CustomerCommandHandler(ICustomerService CustomerService,
                                      IMapper mapper,
                                     IStringLocalizer<SharedResources> localizer) : base(localizer)
        {
            _CustomerService = CustomerService;
            _mapper = mapper;
            _localizer = localizer;
        }
        #endregion
        public async Task<Response<string>> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and Customer
            var customermapper = _mapper.Map<Customer>(request);
            //add
            var result = await _CustomerService.AddAsync(customermapper);
            //return response
            if (result == "Success") return Created("");
            else return BadRequest<string>();
        }

        public async Task<Response<string>> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _CustomerService.GetByIDAsync(request.Id);
            if (customer==null) return NotFound<string>();
            var result = await _CustomerService.DeleteAsync(customer);
            if (result=="Success") return Deleted<string>();
            else return BadRequest<string>();
        }

        public async Task<Response<string>> Handle(EditCustomerCommand request, CancellationToken cancellationToken)
        {
            //Check if the Id is Exist Or not
            var student = await _CustomerService.GetByIDAsync(request.Id);
            //return NotFound
            if (student == null) return NotFound<string>();
            //mapping Between request and student
            var studentmapper = _mapper.Map(request, student);
            //Call service that make Edit
            var result = await _CustomerService.EditAsync(studentmapper);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Updated]);
            else return BadRequest<string>();
        }
    }
}
