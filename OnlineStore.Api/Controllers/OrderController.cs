/*using Microsoft.AspNetCore.Mvc;
using OnlineStore.Api.Base;
using OnlineStore.Core.Feautres.OrderCQRS.Queries.Models;

namespace OnlineStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : AppControllerBase
    {
        public async Task<IActionResult> GetOrderById([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new GetOrderByIdQuery(id)));
        }
    }
}
*/