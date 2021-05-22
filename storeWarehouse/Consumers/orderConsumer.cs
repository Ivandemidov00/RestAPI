using MassTransit;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storeWarehouse.Consumers
{
    public class orderConsumer : IConsumer<ordercheck>
    {
        public async Task Consume(ConsumeContext<ordercheck> context)
        {
            var data = context.Message;
            
            //Validate the Ticket Data
            //Store to Database
            //Notify the user via Email / SMS
        }
    }
}
