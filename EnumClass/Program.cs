using EnumClass;

var adult = FeeType.Adult;
if (adult == FeeType.Adult)
{
    Console.WriteLine("adult");
}

Console.WriteLine(adult.Yen.DisplayValue);
adult.Process();