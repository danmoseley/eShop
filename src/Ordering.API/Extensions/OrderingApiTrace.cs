﻿namespace eShop.Ordering.API.Extensions;

internal static partial class OrderingApiTrace
{
    [LoggerMessage(EventId = 1, EventName = "OrderStatusUpdated", Level = LogLevel.Trace, Message = "Order with Id: {OrderId} has been successfully updated to status {Status}")]
    public static partial void LogOrderStatusUpdated(ILogger logger, int orderId, OrderStatus status);

    [LoggerMessage(EventId = 3, EventName = "BuyerAndPaymentValidatedOrUpdated", Level = LogLevel.Trace, Message = "Buyer {BuyerId} and related payment method were validated or updated for order Id: {OrderId}.")]
    public static partial void LogOrderBuyerAndPaymentValidatedOrUpdated(ILogger logger, int buyerId, int orderId);
}
