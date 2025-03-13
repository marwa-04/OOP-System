class Payment
{
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }

    public virtual void ProcessPayment()
    {
        Console.WriteLine($"Processing payment of {Amount:C} on {PaymentDate}");
    }
}

class CreditPayment : Payment
{
    public string CardNumber { get; set; }
}

class CashPayment : Payment { }

class CheckPayment : Payment
{
    public string CheckNumber { get; set; }
}
