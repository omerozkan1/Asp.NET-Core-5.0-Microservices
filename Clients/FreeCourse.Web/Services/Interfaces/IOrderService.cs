using FreeCourse.Web.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Interfaces
{
    public interface IOrderService
    {
        /// <summary>
        /// Senkron iletişim. Direkt olarak microservice' e istek yapılacak.
        /// </summary>
        /// <param name="checkOutInfoInput"></param>
        /// <returns></returns>
        Task<OrderCreatedViewModel> CreateOrder(CheckOutInfoInput checkOutInfoInput);

        /// <summary>
        /// Asenkron iletişim. Sipariş bilgileri rabbitmq ya gönderilir.
        /// </summary>
        /// <param name="checkOutInfoInput"></param>
        /// <returns></returns>
        Task<OrderSuspendViewModel> SuspendOrder(CheckOutInfoInput checkOutInfoInput);

        Task<List<OrderViewModel>> GetOrder();
    }
}
