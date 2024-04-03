internal class Program
{
    private static void Main(string[] args)
    {
        // decimal price = 123.45m;
        // int discount = 50;
        // Console.WriteLine($"Price: {price:C} (Save {discount:C})");




        // int invoiceNumber = 1201;
        // decimal productShares = 25.4568m;
        // decimal subtotal = 2750.00m;
        // decimal taxPercentage = .15825m;
        // decimal total = 3185.19m;

        // Console.WriteLine($"Invoice Number: {invoiceNumber}");       //Invoice Number: 1201                     
        // Console.WriteLine($"   Shares: {productShares:N3} Product"); //Shares: 25.457 Product   小数点后3位数
        // Console.WriteLine($"     Sub Total: {subtotal:C}");          // Sub Total: ¥2,750.00    C=Currency
        // Console.WriteLine($"           Tax: {taxPercentage:P2}");    //Tax: 15.83%               P=Percentage 小数点后2位数
        // Console.WriteLine($"     Total Billed: {total:C}");          //Total Billed: ¥3,185.19


        // string input = "Pad this";
        // Console.WriteLine(input.PadLeft(12));              //向左添加4个空格,因为“Pad this 有8个字符长度”
        // Console.WriteLine(input.PadRight(12));             //向右添加4个空格
        // Console.WriteLine(input.PadLeft(12, '-'));         //向左添加4个---- 
        // Console.WriteLine(input.PadRight(12, '-'));        //向右移动4个---- 


        string customerName = "Ms. Barros";

        string currentProduct = "Magic Yield";
        int currentShares = 2975000;
        decimal currentReturn = 0.1275m;
        decimal currentProfit = 55000000.0m;

        string newProduct = "Glorious Future";
        decimal newReturn = 0.13125m;
        decimal newProfit = 63000000.0m;

        Console.WriteLine($"Dear {customerName},");
        Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
        Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
        Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

        Console.WriteLine("Here's a quick comparison:\n");

        string comparisonMessage = "";

        comparisonMessage = currentProduct.PadRight(20);
        comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
        comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

        comparisonMessage += "\n";
        comparisonMessage += newProduct.PadRight(20);
        comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
        comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

        Console.WriteLine(comparisonMessage);
    }
}