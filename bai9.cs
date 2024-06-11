using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.WriteLine("Chọn tác vụ:");
        Console.WriteLine("1. Đảo ngược chuỗi kí tự");
        Console.WriteLine("2. Đếm số lượng từ trong chuỗi");
        Console.Write("Nhập lựa chọn (1 hoặc 2): ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                ReverseString();
                break;
            case 2:
                CountWords();
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ.");
                break;
        }
    }

    static void ReverseString()
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.Write("Nhập chuỗi kí tự: ");
        string input = Console.ReadLine();

        string reversedString = ReverseStringHelper(input);

        Console.WriteLine("Chuỗi kí tự đảo ngược: " + reversedString);
    }

    static string ReverseStringHelper(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static void CountWords()
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.Write("Nhập chuỗi kí tự: ");
        string input = Console.ReadLine();

        int wordCount = CountWordsHelper(input);

        Console.WriteLine("Số lượng từ trong chuỗi: " + wordCount);
    }

    static int CountWordsHelper(string str)
    {
        string[] words = str.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}
