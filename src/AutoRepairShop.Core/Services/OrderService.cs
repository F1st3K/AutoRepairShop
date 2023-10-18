﻿using AutoRepairShop.Core.dtos;
using AutoRepairShop.Core.Entities;
using AutoRepairShop.Core.Repositories;
using System;

namespace AutoRepairShop.Core.Services
{
    public class OrderService<TOrderRepository, TOrderProductRepository>
        where TOrderRepository : IRepository<Order>
        where TOrderProductRepository : IRepository<OrderProduct>
    {
        private TOrderRepository _orderRepository;
        private TOrderProductRepository _orderProductRepository;

        public OrderService(TOrderRepository orderRepository, TOrderProductRepository orderProductRepository)
        {
            _orderProductRepository = orderProductRepository;
            _orderRepository = orderRepository;
        }

        public void CreateOrder(OrderDto dto)
        {
            var orderId = _orderRepository.Add(new Order 
            { 
                Id = 0,
                Date = DateTime.Now.ToString(),
                Code = Guid.NewGuid().ToString().Substring(0, 6),
                Status = "1",
                Price = dto.Price,
                UserInfoId = dto.UserInfoId
            });

            foreach (var orderProduct in dto.Products)
            {
                _orderProductRepository.Add(new OrderProduct
                {
                    OrderId = orderId,
                    ProductId = orderProduct.ProductId
                });
            }
        }
    }
}
