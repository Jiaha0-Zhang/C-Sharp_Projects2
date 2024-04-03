internal class Program
{
    private static void Main(string[] args)
    {
        // int first = 2;
        // string second = "4";
        // string result = first + second;
        // Console.WriteLine(result);

        // int myInt = 3;
        // Console.WriteLine($"int: {myInt}");

        // decimal myDecimal = myInt;
        // Console.WriteLine($"decimal: {myDecimal}");

        // string first = "5";
        // string second = "7";
        // int sum = int.Parse(first) + int.Parse(second);
        // Console.WriteLine(sum);

        // string value1 = "5";
        // string value2 = "7";
        // int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
        // Console.WriteLine(result);

        // int value = (int)1.5m; // casting truncates 向下取整
        // Console.WriteLine(value);
        // int value2 = Convert.ToInt32(1.5m); // converting rounds up 四舍五入
        // Console.WriteLine(value2);

        //string value = "102";
        // string value = "bad";
        // int result = 0;
        // if (int.TryParse(value, out result))
        // {
        //     Console.WriteLine($"Measurement: {result}");
        // }
        // else
        // {
        //     Console.WriteLine("Unable to report the measurement.");
        // }
        // Console.WriteLine($"Measurement (w/ offset): {50 + result}");


        // string[] values = { "12.3", "45", "ABC", "11", "DEF" };

        // decimal total = 0m;
        // string message = "";

        // foreach (var value in values)
        // {
        //     decimal number; // stores the TryParse "out" value
        //     if (decimal.TryParse(value, out number))
        //     {
        //         total += number; //能解析转换的到这里
        //     }
        //     else
        //     {
        //         message += value; //不能解析的到这里
        //     }
        // }

        // Console.WriteLine($"Message: {message}");
        // Console.WriteLine($"Total: {total}");



        int value1 = 12;
        decimal value2 = 6.2m;
        float value3 = 4.3f;

        // The Convert class is best for converting the fractional decimal numbers into whole integer numbers
        // Convert.ToInt32() rounds up the way you would expect.
        int result1 = Convert.ToInt32(value1 / value2);
        Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

        decimal result2 = value2 / (decimal)value3;
        Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

        float result3 = value3 / value1;
        Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

    }
}