internal class Program
{
    private static void Main(string[] args)
    {
        string data = "12345John Smith          5000  3  ";
        string updatedData = data.Remove(5, 20); //从第五个字符开始删除接下来的20个字符
        Console.WriteLine(updatedData); //123455000  3  

        string message = "This--is--ex-amp-le--da-ta";
        message = message.Replace("--", " "); //将--替换为空格
        message = message.Replace("-", ""); //将-替换为空字符
        Console.WriteLine(message);   //This is example data
    }
}