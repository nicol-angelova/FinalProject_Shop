﻿using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.Services
{
    public class OrderService : IOrderService
    {
        public void Add(string orderName, string brand)
        {
            using var db = new ApplicationDbContext();
            db.Orders.Add(new Order { Item = orderName, Brand = brand });
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            using var db = new ApplicationDbContext();
            var order = GetById(id);
            db.Orders.Remove(order);
            db.SaveChanges();

        }

        public void Edit(Order order)
        {
            using var db = new ApplicationDbContext();

            var orderToEdit = db.Orders.FirstOrDefault(x => x.Id == order.Id);
            if (orderToEdit != null)
            {
                orderToEdit.Item = order.Item;
                orderToEdit.Brand = order.Brand;
                db.SaveChanges();
            }
        }

        public IEnumerable<Order> GetAll()
        {
            using var db = new ApplicationDbContext();
            return db.Orders.ToList();
        }

        public Order GetById(int id)
        {
            using var db = new ApplicationDbContext();
            return db.Orders.FirstOrDefault(x => x.Id == id);
        }

       
    }
}
