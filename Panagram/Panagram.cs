using System;
using System.Linq;

public static class Panagram
{
    //this program check if string contains every letter in alphabet
    public static bool IsPangram(string str)
    {
        var wynik = str.Trim().ToLower().ToList();
        return wynik.Distinct().Count() >= 26 ? true : false;
    }
}