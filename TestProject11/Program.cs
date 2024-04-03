internal class Program
{
    private static void Main(string[] args)
    {
        // string message = "Find what is (inside the parentheses)";

        // int openingPosition = message.IndexOf('(');
        // int closingPosition = message.IndexOf(')');

        // Console.WriteLine(openingPosition); //13
        // Console.WriteLine(closePosition);   //36
        //In this case, the index of the ( character is 13. Remember, these values are zero-based, 
        //so it's the 14th character in the string. The index of the ) character is 36.

        // int length = closingPosition - openingPosition;
        // Console.WriteLine(message.Substring(openingPosition, length)); //(inside the parentheses

        // openingPosition += 1;
        // int length = closingPosition - openingPosition;
        // Console.WriteLine(message.Substring(openingPosition, length)); //inside the parentheses



        //// hardcoded
        // string message = "What is the value <span>between the tags</span>?";

        // int openingPosition = message.IndexOf("<span>");
        // int closingPosition = message.IndexOf("</span>");

        // openingPosition += 6; // +6 because <span> has 6 characters length
        // int length = closingPosition - openingPosition;
        // Console.WriteLine(message.Substring(openingPosition, length)); //between the tags


        // //better coding
        // string message = "What is the value <span>between the tags</span>?";
        // const string openSpan = "<span>";
        // const string closeSpan = "</span>";
        // int openingPosition = message.IndexOf(openSpan);
        // int closingPosition = message.IndexOf(closeSpan);
        // Console.WriteLine(openingPosition); //18 
        // Console.WriteLine(closingPosition); //40 

        // openingPosition += openSpan.Length;
        // int length = closingPosition - openingPosition;
        // Console.WriteLine(message.Substring(openingPosition, length)); //between the tags


        // string message = "(What if) there are (more than) one (set of parentheses)?";
        // while (true)
        // {
        //     int openingPosition = message.IndexOf('(');
        //     if (openingPosition == -1) break;    //IndexOf() returns -1 if it can't find a match.

        //     openingPosition += 1;
        //     int closingPosition = message.IndexOf(')');
        //     int length = closingPosition - openingPosition;
        //     Console.WriteLine(message.Substring(openingPosition, length)); //What if       more than      set of parentheses

        //     // Note the overload of the Substring to return only the remaining 
        //     // unprocessed message:
        //     message = message.Substring(closingPosition + 1);
        // }




        // string message = "Help (find) the {opening symbols}";
        // Console.WriteLine($"Searching THIS Message: {message}"); //Searching THIS Message: Help (find) the {opening symbols}
        // char[] openSymbols = { '[', '{', '(' };
        // int startPosition = 5;
        // int openingPosition = message.IndexOfAny(openSymbols);
        // Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}"); //Found WITHOUT using startPosition: (find) the {opening symbols}

        // openingPosition = message.IndexOfAny(openSymbols, startPosition);
        // Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}"); //Found WITH using startPosition 5:  (find) the {opening symbols}



        string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
        // The IndexOfAny() helper method requires a char array of characters. 
        // You want to look for:
        char[] openSymbols = { '[', '{', '(' };
        // You'll use a slightly different technique for iterating through 
        // the characters in the string. This time, use the closing 
        // position of the previous iteration as the starting index for the 
        //next open symbol. So, you need to initialize the closingPosition 
        // variable to zero:
        int closingPosition = 0;
        while (true)
        {
            int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

            if (openingPosition == -1) break;

            string currentSymbol = message.Substring(openingPosition, 1);

            // Now  find the matching closing symbol
            char matchingSymbol = ' ';

            switch (currentSymbol)
            {
                case "[":
                    matchingSymbol = ']';
                    break;
                case "{":
                    matchingSymbol = '}';
                    break;
                case "(":
                    matchingSymbol = ')';
                    break;
            }

            // To find the closingPosition, use an overload of the IndexOf method to specify 
            // that the search for the matchingSymbol should start at the openingPosition in the string. 

            openingPosition += 1;
            closingPosition = message.IndexOf(matchingSymbol, openingPosition);

            // Finally, use the techniques you've already learned to display the sub-string:

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));
        }


        //LastIndexOf() returns the last position of a character or string inside of another string.
        //IndexOfAny() returns the first position of an array of char that occurs inside of another string.
    }
}