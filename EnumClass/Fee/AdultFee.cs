namespace EnumClass.Fee;
sealed class AdultFee : IFee
{
    public string Label => "Adult";

    public Yen Yen => new Yen(100);

    public void Process()
    {
        Console.WriteLine("Adult process");
    }
}
