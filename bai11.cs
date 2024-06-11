using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        string fileName, content;

        // Nhập tên file và nội dung
        Console.Write("Nhập tên file (bao gồm đuôi .txt): ");
        fileName = Console.ReadLine();
        Console.Write("Nhập nội dung: ");
        content = Console.ReadLine();

        // Ghi nội dung vào file
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(content);
            }
            Console.WriteLine("Đã ghi nội dung vào file thành công.");
        }
        catch (IOException e)
        {
            Console.WriteLine($"Lỗi khi ghi file: {e.Message}");
        }

        // Đọc nội dung từ file
        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string readContent = reader.ReadToEnd();
                Console.WriteLine("Nội dung file:");
                Console.WriteLine(readContent);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"Lỗi khi đọc file: {e.Message}");
        }
    }
}