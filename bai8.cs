using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Chọn chức năng:");
            Console.WriteLine("1. Hiển thị bảng mã ASCII");
            Console.WriteLine("2. Hiển thị bảng mã UTF-8 của trang mã 65001");
            Console.WriteLine("3. Phát tiếng beep khi nhấn phím space");
            Console.WriteLine("4. Đếm số lần xuất hiện của mỗi kí tự trong chuỗi");
            Console.WriteLine("5. Thoát");
            Console.Write("Lựa chọn của bạn: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayAsciiTable();
                    break;
                case "2":
                    DisplayUtf8Table();
                    break;
                case "3":
                    BeepOnSpace();
                    break;
                case "4":
                    CountCharacterOccurrences();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }
        }
    }

    static void DisplayAsciiTable()
    {
        Console.WriteLine("ASCII Table");
        Console.WriteLine("-----------");
        for (int i = 0; i < 128; i++)
        {
            Console.WriteLine($"{i}: {(char)i}");
        }
    }

    static void DisplayUtf8Table()
    {
        Console.WriteLine("UTF-8 Table (Code Page 65001)");
        Console.WriteLine("------------------------------");
        for (int i = 0; i <= 0xFF; i++)
        {
            Console.WriteLine($"{i}: {(char)i}");
        }
    }

    static void BeepOnSpace()
    {
        Console.WriteLine("Nhấn phím Space để phát tiếng beep. Nhấn phím Esc để thoát.");
        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Spacebar)
            {
                Console.Beep();
            }
            else if (keyInfo.Key == ConsoleKey.Escape)
            {
                break;
            }
        }
    }

    static void CountCharacterOccurrences()
    {
        Console.Write("Nhập vào một chuỗi kí tự: ");
        string input = Console.ReadLine();
        var charCount = new System.Collections.Generic.Dictionary<char, int>();

        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c] += 1;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        Console.WriteLine("Kết quả đếm số lần xuất hiện của mỗi kí tự:");
        foreach (var item in charCount)
        {
            Console.WriteLine($"'{item.Key}': {item.Value}");
        }
    }
}
