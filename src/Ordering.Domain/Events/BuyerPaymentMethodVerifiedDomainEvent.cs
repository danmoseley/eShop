namespace eShop.Ordering.Domain.Events;

public class BuyerAndPaymentMethodVerifiedDomainEvent
    : INotification
{
    public Buyer Buyer { get; private set; }
    public int OrderId { get; private set; }

    public BuyerAndPaymentMethodVerifiedDomainEvent(Buyer buyer, int orderId)
    {
        Buyer = buyer;
        OrderId = orderId;
    }
}
