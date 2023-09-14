using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanTuLonT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập dãy số, cách nhau bằng dấu cách: ");
            string input = Console.ReadLine();

            // Chuyển đổi chuỗi nhập vào thành mảng các số nguyên
            string[] numbersStr = input.Split(' ');
            int[] numbers = new int[numbersStr.Length];

            for (int i = 0; i < numbersStr.Length; i++)
            {
                if (int.TryParse(numbersStr[i], out int num))
                {
                    numbers[i] = num;
                }
                else
                {
                    Console.WriteLine("Lỗi: Vui lòng nhập các số nguyên hợp lệ.");
                    return;
                }
            }

            if (numbers.Length < 2)
            {
                Console.WriteLine("Dãy số phải có ít nhất 2 phần tử.");
                return;
            }

            int max1 = int.MinValue; // Giá trị lớn nhất
            int max2 = int.MinValue; // Giá trị lớn thứ hai

            foreach (int num in numbers)
            {
                if (num > max1)
                {
                    max2 = max1; // Cập nhật giá trị lớn thứ hai
                    max1 = num; // Cập nhật giá trị lớn nhất
                }
                else if (num > max2 && num != max1)
                {
                    max2 = num; // Cập nhật giá trị lớn thứ hai
                }
            }

            if (max2 == int.MinValue)
            {
                Console.WriteLine("Không có phần tử lớn thứ hai trong dãy số.");
            }
            else
            {
                Console.WriteLine("Phần tử lớn thứ hai trong dãy số là: " + max2);
            }
            Console.ReadLine();
        }
    }
    
}
