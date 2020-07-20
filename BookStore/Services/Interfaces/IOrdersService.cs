using BookStore.ModelDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services.Interfaces
{
    public interface IOrdersService
    {
        /// <summary>
        /// Creates new order
        /// </summary>
        /// <param name="createOrderDto"></param>
        
        CreateOrderResponse Create(CreateOrderDto createOrderDto);
    }
}
