namespace EnumClass.Fee;
interface IFee
{
    string Label { get; }
    Yen Yen { get; }
    void Process();
}
