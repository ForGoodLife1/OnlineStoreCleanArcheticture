using MediatR;
using OnlineStore.Core.Bases;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Core.Feautres.CustomerCQRS.Commands.ModelsCommands
{
    public class EditCustomerCommand : IRequest<Response<String>>
    {
        public int Id { get; set; }
        [Required]
        public string NameAr { get; set; }
        [Required]
        public string NameEn { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

    }
}
