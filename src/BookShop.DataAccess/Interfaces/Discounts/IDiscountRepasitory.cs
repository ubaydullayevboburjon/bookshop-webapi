﻿using BookShop.DataAccess.Common.Interfaces;
using BookShop.Domain.Entities.Discounts;

namespace BookShop.DataAccess.Interfaces.Discounts;

public interface IDiscountRepasitory:IRepasitory<Discount, Discount> ,IGetAll<Discount>
{
}
