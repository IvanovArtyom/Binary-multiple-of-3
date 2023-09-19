using System.Text.RegularExpressions;

public class BinaryRegex
{
    public static void Main()
    {
        // Test
        Regex regex = MultipleOf3();
        var t = regex.IsMatch("10101");
        // ...should return true
    }

    public static Regex MultipleOf3()
    {
        return new Regex(@"\A(0|(1(01*(00)*0)*1)*)*\Z");
    }
}