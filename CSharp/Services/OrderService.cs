using CSharp.Domain.Models;
using CSharp.Domain.Repositories;
using CSharp.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;

        public OrderService(IOrderRepository oRepository)
        {
            orderRepository = oRepository;
        }

        public async Task<IEnumerable<Order>> GetAllOrdersByCustomerId(int id)
        {
            return await orderRepository.GetAllOrdersByCustomerId(id);
        }

        public async Task<ActionResult<Order>> CreateOrder(Order order)
        {
            return await orderRepository.CreateOrder(order);
        }

        public async Task<ActionResult<Order>> GetOrderById(int id)
        {
            return await orderRepository.GetOrderById(id);
        }


    }
}
