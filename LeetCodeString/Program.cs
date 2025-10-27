using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        string s = "MCMXCIV";
        int result = ImprovedRomanToInt(s);

        Console.WriteLine($"result of string {s} is {result}");
    }
    // this code is fine but their are soo many if statements so the better will be
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
            if (s[i] == 'V')
            {
                sum += 5;
                Console.WriteLine($"{s[i]} = {5}");
            }
            if (s[i] == 'X')
            {
                sum += 10;
                Console.WriteLine($"{s[i]} = {10}");
            }
            if (s[i] == 'L')
            {
                sum += 50;
                Console.WriteLine($"{s[i]} = {50}");
            }
            if (s[i] == 'C')
            {
                sum += 100;
                Console.WriteLine($"{s[i]} = {100}");
            }
            if (s[i] == 'D')
            {
                sum += 500;
                Console.WriteLine($"{s[i]} = {500}");
            }
            if (s[i] == 'M')
            {
                sum += 1000;
                Console.WriteLine($"{s[i]} = {1000}");
            }
            if (s[i] == 'V' && i > 0 && s[i - 1] == 'I')
            {
                sum -= 2;
                Console.WriteLine($"Adjusting for IV: -2");
            }
            if (s[i] == 'X' && i > 0 && s[i - 1] == 'I')
            {
                sum -= 2;
                Console.WriteLine($"Adjusting for IX: -2");
            }
            if (s[i] == 'L' && i > 0 && s[i - 1] == 'X')
            {
                sum -= 20;
                Console.WriteLine($"Adjusting for XL: -20");
            }
            if (s[i] == 'C' && i > 0 && s[i - 1] == 'X')
            {
                sum -= 20;
                Console.WriteLine($"Adjusting for XC: -20");
            }
            if (s[i] == 'D' && i > 0 && s[i - 1] == 'C')
            {
                sum -= 200;
                Console.WriteLine($"Adjusting for CD: -200");
            }
            if (s[i] == 'M' && i > 0 && s[i - 1] == 'C')
            {
                sum -= 200;
                Console.WriteLine($"Adjusting for CM: -200");
            }

        }

            return sum;
    }

    public static int ImprovedRomanToInt(string s)
    {
        Dictionary<char, int> romanMap = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int sum = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int current = romanMap[s[i]];

            if (i + 1 < s.Length && romanMap[s[i + 1]] > current)
            {
                sum -= current;

            }
            else
            {
                sum += current;
            }
        }
        return sum;
    }
}