namespace EnumClass.Fee;
sealed class SeniorFee : IFee
{
    public string Label => "Senior";

    public Yen Yen => new Yen(50);

    public void Process()
    {
        Console.WriteLine("Senior process");
    }
}
