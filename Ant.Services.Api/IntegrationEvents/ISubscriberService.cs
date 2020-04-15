using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ant.Services.Api.IntegrationEvents
{
    public interface ISubscriberService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="event"></param>
        void OrderPaymentSucceeded(int @event);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="event"></param>
        void OrderCreated(DateTime @event);
    }
}
