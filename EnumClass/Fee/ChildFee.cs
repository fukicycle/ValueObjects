namespace EnumClass.Fee;
sealed class ChildFee : IFee
{
    public string Label => "Child";

    public Yen Yen => new Yen(50);

    public void Process()
    {
        Console.WriteLine("Child process");
    }
}
