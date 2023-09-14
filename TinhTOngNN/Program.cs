using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTOngNN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập giá trị của n lớn hơn 10 ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int sum = 0;

                for (int i = 1; i <= n; i++)
                {
                    int term = int.Parse($"{i}{i}"); // Tạo số dạng nn
                    sum += term;
                }
                Console.WriteLine($"Tổng của dãy S từ 11 đến {n}{n} là: {sum}");
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ.");
            }
            Console.ReadLine();
        }
       
   
        
    }
    
}
