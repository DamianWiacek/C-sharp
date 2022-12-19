
public class Kata
{

    public static string UInt32ToIP(uint ip)
    {
        string temp = "";
        string result = "";
        for (int i = 31; i >= 0; i--)
        {
            if (ip >= Math.Pow(2, i))
            {
                ip -= (uint)Math.Pow(2, i);
                temp += 1;
            }
            else
            {
                temp += 0;
            }
        }
        for (int i = 0; i < 32; i += 8)
        {
            result += Convert.ToInt32(temp.Substring(i, 8), 2).ToString() + ".";
        }
        return result.Substring(0, result.Length - 1);
    }

    public static void Main(string[] args)
    {


        Console.WriteLine(Kata.UInt32ToIP(2149583361));
    }
}