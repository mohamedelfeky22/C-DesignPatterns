﻿using Strategy_Pattern_First_Look.Business.Models;

namespace Strategy_Pattern_First_Look.Business.Strategies.SalesTax
{
    public class SwedenSalesTaxStrategy : ISalesTaxStrategy
    {
        public decimal GetTaxFor(Order order)
        {
            var destination = order.ShippingDetails.DestinationCountry.ToLowerInvariant();
            var totalPrice = order.TotalPrice;

            if (destination == order.ShippingDetails.OriginCountry.ToLowerInvariant())
            {
                return totalPrice * 0.25m;
            }

            return 0;
        }
    }
}
