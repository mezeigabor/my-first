using System;
using System.Linq.Expressions;
using Core.Entities.OrderAggregator;

namespace Core.Specifications
{
    public class OrderByPaymentIntentIdSpecification : BaseSpecification<Order>
    {
        public OrderByPaymentIntentIdSpecification(string paymentIntentId) 
            : base(o => o.PamynetIntentId == paymentIntentId)
        {
        }
    }
}