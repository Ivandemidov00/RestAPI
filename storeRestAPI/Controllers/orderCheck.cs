using MassTransit;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Model;

namespace storeRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class orderCheck : ControllerBase
    {
        private readonly IBus _bus;
        public orderCheck(IBus bus)
        {
            _bus = bus;
        }
        [HttpPost]
        public async Task<IActionResult> CreateTicket(ordercheck ticket)
        {
            if (ticket != null)
            {     
                Uri uri = new Uri("rabbitmq://localhost/ticketQueue");
                var endPoint = await _bus.GetSendEndpoint(uri);
                await endPoint.Send(ticket);
                return Ok();
            }
            return BadRequest();
        }
    }
}
