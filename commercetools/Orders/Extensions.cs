﻿using myCT.Common;

namespace myCT.Orders
{
    /// <summary>
    /// Extensions
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Creates an instance of the OrderManager.
        /// </summary>
        /// <returns>OrderManager</returns>
        public static OrderManager Orders(this IClient client)
        {
            return new OrderManager(client);
        }
    }
}
