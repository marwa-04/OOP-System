class Transaction
{
    public Order Order;
    public Payment Payment;

    public Transaction(Order order, Payment payment)
    {
        Order = order;
        Payment = payment;
    }

    public void ShowTransaction()
    {
        Console.WriteLine($"Transaction: Order {Order.OrderNumber}, Paid {Payment.Amount}");
    }
}
