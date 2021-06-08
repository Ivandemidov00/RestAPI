using MassTransit;
using Model;
using storeWarehouse.Context;
using storeWarehouse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storeWarehouse.Consumers
{
    public class orderConsumer : IConsumer<ordercheck>
    {
        private readonly Contextorder contextorder;
        private order order =null;


        //public orderConsumer(Contextorder contextorder)
        //{
        //    this.contextorder = contextorder;
        //}
        public  async Task Consume(ConsumeContext<ordercheck> context)
        {
              var data =  context.Message;
            //await context.RespondAsync<ordercheck>({ order = data});
           
            //Validate the Ticket Data
            //Store to Database
            //Notify the user via Email / SMS
            //}
        }
    }
}

