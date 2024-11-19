using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapbuoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Thien", Age = 16 },
            new Student { Id = 2, Name = "Hieu", Age = 18 },
            new Student { Id = 3, Name = "Hai", Age = 20 },
            new Student { Id = 4, Name = "Duy", Age = 15 },
            new Student { Id = 5, Name = "Anh", Age = 17 }
           
        };

            // a. In danh sách toàn bộ học sinh
            Console.WriteLine("Danh sach toan bo hoc sinh:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            // b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18
            Console.WriteLine("\nHoc sinh co tuoi tu 15 den 18:");
            var age15To18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var student in age15To18)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
            Console.WriteLine("\nHoc sinh co ten bat dau bang chu 'A':");
            var nameStartsWithA = students.Where(s => s.Name.StartsWith("A"));
            foreach (var student in nameStartsWithA)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            // d. Tính tổng tuổi của tất cả các học sinh trong danh sách
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"\nTong tuoi cua tat ca cac hoc sinh: {totalAge}");

            // e. Tìm và in ra học sinh có tuổi lớn nhất
            int maxAge = students.Max(s => s.Age);
            var oldestStudent = students.First(s => s.Age == maxAge);
            Console.WriteLine($"\nHoc sinh co tuoi lon nhat: ID: {oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");

            // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp
            Console.WriteLine("\nDanh sach hoc sinh sau khi sap xep theo tuoi tang dan:");
            var sortedByAge = students.OrderBy(s => s.Age);
            foreach (var student in sortedByAge)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
        }
    }
}
