using Microsoft.AspNetCore.Mvc;
using OnlineStore.Api.Base;
using OnlineStore.Core.Feautres.OrderCQRS.Queries.Models;
using OnlineStore.Data.AppMetaData;

namespace OnlineStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : AppControllerBase
    {
        [HttpGet(Router.OrderRouting.GetByID)]
        public async Task<IActionResult> GetOrderById([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new GetOrderByIdQuery(id)));
        }
    }
}
