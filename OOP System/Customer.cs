class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override string ToString() => $"ID: {Id}, Name: {Name}";
}
