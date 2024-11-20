namespace EnumClass;
sealed record Yen(int Value)
{
    public string DisplayValue => Value.ToString() + "yen";
}