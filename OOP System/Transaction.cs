class Transaction
{
    public Order Order { get; set; }
    public Payment Payment { get; set; }

    public static Transaction operator +(Transaction t, Payment payment)
    {
        t.Payment = payment;
        return t;
    }

    public override string ToString()
    {
        return $"Transaction for Order {Order.OrderNumber}: Paid {Payment.Amount:C} on {Payment.PaymentDate}";
    }
}
