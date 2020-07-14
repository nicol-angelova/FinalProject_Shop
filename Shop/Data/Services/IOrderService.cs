﻿namespace Shop.Data.Services
{
    using Shop.Data.Models;
    using System.Collections.Generic;

    public interface IOrderService
    {
        IEnumerable<Order> GetAll();

        Order GetById(int id);

        void Edit(Order order);
    }
}