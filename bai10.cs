using System;
using System.Text;

struct Student
{
    public string Name;
    public double Score;
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //
        Console.Write("Nhập số lượng sinh viên: ");
        int n = int.Parse(Console.ReadLine());

        Student[] students = new Student[n];

        // Nhập thông tin của sinh viên
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập thông tin của sinh viên {i + 1}:");
            Console.Write("Tên: ");
            students[i].Name = Console.ReadLine();
            Console.Write("Điểm: ");
            students[i].Score = double.Parse(Console.ReadLine());
        }

        // Hiển thị thông tin của từng sinh viên
        Console.WriteLine("\nThông tin của từng sinh viên:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Sinh viên {i + 1}: {students[i].Name} - Điểm: {students[i].Score}");
        }

        // Tính điểm trung bình của cả lớp
        double totalScore = 0;
        foreach (var student in students)
        {
            totalScore += student.Score;
        }
        double averageScore = totalScore / n;

        Console.WriteLine($"\nĐiểm trung bình của cả lớp: {averageScore:F2}");
    }
}