using MediatR;
using OnlineStore.Core.Bases;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Core.Feautres.CustomerCQRS.Commands.ModelsCommands
{
    public class AddCustomerCommand : IRequest<Response<String>>
    {
        [Required]
        public string NameAr { get; set; }
        [Required]
        public string NameEn { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

    }
}
