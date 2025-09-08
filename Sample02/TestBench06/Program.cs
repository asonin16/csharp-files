namespace TestBench06;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(IsInternationalPhone("89602223423")); // false
        Console.WriteLine(IsInternationalPhone("+79602223423")); // true

        Console.WriteLine(IsCorrectPassword("qwerty")); // false
        Console.WriteLine(IsCorrectPassword("qwerty1234")); // true

        Console.WriteLine(IsGoodApartment(91, "Queens Street")); // false
        Console.WriteLine(IsGoodApartment(78, "Queens Street")); // false
        Console.WriteLine(IsGoodApartment(70, "Main Street")); // false

        Console.WriteLine(IsGoodApartment(120, "Queens Street")); // true
        Console.WriteLine(IsGoodApartment(120, "Main Street")); // true
        Console.WriteLine(IsGoodApartment(80, "Main Street")); // true

        Console.WriteLine(IsLannisterSoldier("red", "lion")); // true
        Console.WriteLine(IsLannisterSoldier("blue", null));  // false

        Console.WriteLine(IsNotLannisterSoldier("red", "lion")); // false
        Console.WriteLine(IsNotLannisterSoldier("blue", null));  // true

        Console.WriteLine(IsNeutralSoldier("yellow", "black")); // true
        Console.WriteLine(IsNeutralSoldier("red", "black"));    // false
        Console.WriteLine(IsNeutralSoldier("red", "red"));      // false
    }

    public static bool IsInternationalPhone(string phone)
    {
        return phone[..1] == "+";
        // return phone[0] == '+';
    }

    // Пароль длиннее 8 символов **И** пароль короче 20 символов.
    public static bool IsCorrectPassword(string password)
    {
        var length = password.Length;
        return length > 8 && length < 20;
    }

    public static bool IsGoodApartment(int area, string street)
    {
        return area >= 100 || (area >= 80 && "Main Street" == street);
    }

    public static bool IsLannisterSoldier(string color, string? shield)
    {
        return (color == "red" && shield == null) || shield == "lion";
    }

    public static bool IsNotLannisterSoldier(string color, string? shield)
    {
        return (color != "red" || shield != null) && shield != "lion";
    }

    public static bool IsNeutralSoldier(string armor, string shield)
    {
        return armor != "red" && shield == "black";
    }
}
