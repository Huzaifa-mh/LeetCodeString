internal class Program
{
    private static void Main(string[] args)
    {
        string s = "VIII";
        int result = RomanToInt(s);

        Console.WriteLine($"result of string {s} is {result}");
    }
    public static int RomanToInt(string s)
    {
        int sum = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'I')
            {
                sum += 1;
                Console.WriteLine($"{s[i]} = {1}");
            }
            else if (s[i] == 'V')
            {
                sum += 5;
                Console.WriteLine($"{s[i]} = {5}");
            }
            else if (s[i] == 'X')
            {
                sum += 10;
                Console.WriteLine($"{s[i]} = {10}");
            }
            else if (s[i] == 'L')
            {
                sum += 50;
                Console.WriteLine($"{s[i]} = {50}");
            }
            else if (s[i] == 'C')
            {
                sum += 100;
                Console.WriteLine($"{s[i]} = {100}");
            }
            else if (s[i] == 'D')
            {
                sum += 500;
                Console.WriteLine($"{s[i]} = {500}");
            }
            else if (s[i] == 'M')
            {
                sum += 1000;
                Console.WriteLine($"{s[i]} = {1000}");
            }
        }

        return sum;
    }
}