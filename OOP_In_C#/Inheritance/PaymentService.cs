public class PaymentService
{
    public virtual string ProcessPayment()
    {
        return "Processing normal payment";
    }
}

public class CreditCardPaymentService : PaymentService
{
    public override string ProcessPayment()
    {
        return "Processing credit card payment";
    }
}
