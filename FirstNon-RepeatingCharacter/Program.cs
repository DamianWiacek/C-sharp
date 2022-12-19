using System.Linq;

public class Kata
{
    public static string FirstNonRepeatingLetter(string s)
    {
        string wynik = "";
        foreach (var item in s)
        {
            if (s.Count(f => f.ToString().ToLower() == item.ToString().ToLower()) == 1)
            {
                wynik = item.ToString();
                break;
            }
        }
        return wynik;
    }
}