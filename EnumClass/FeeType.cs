using EnumClass.Fee;

namespace EnumClass;
sealed class FeeType
{
    public static readonly FeeType Adult = new FeeType(new AdultFee());
    public static readonly FeeType Senior = new FeeType(new SeniorFee());
    public static readonly FeeType Child = new FeeType(new ChildFee());

    private readonly IFee _fee;
    private FeeType(IFee fee)
    {
        _fee = fee;
        Yen = _fee.Yen;
    }

    public Yen Yen { get; }
    public void Process() => _fee.Process();
}