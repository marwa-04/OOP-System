class Payment
{
    public decimal Amount;

    public Payment(decimal amount)
    {
        Amount = amount;
    }

    public void ProcessPayment()
    {
        Console.WriteLine($"Payment of {Amount} processed.");
    }
}
