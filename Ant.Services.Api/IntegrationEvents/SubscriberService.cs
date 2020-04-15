using DotNetCore.CAP;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ant.Services.Api.IntegrationEvents
{
    public class SubscriberService : ISubscriberService, ICapSubscribe
    {
        IMediator _mediator;
        public SubscriberService(IMediator mediator)
        {
            _mediator = mediator;
        }

        [NonAction]
        [CapSubscribe("OrderPaymentSucceeded")]
        public void OrderPaymentSucceeded(int @event)
        {
            //Do SomeThing
        }
        [NonAction]
        [CapSubscribe("OrderCreated")]
        public void OrderCreated(DateTime @event)
        {


            //Do SomeThing
        }
    }
}
