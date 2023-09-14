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
            Console.Write("Nhập giá trị của n (n > 10): ");
            int n;

            if (int.TryParse(Console.ReadLine(), out n) && n > 10)
            {
                int sum = 0;

                for (int i = 11; i <= n; i++)
                {
                    sum += i * 11; // Thêm i * 11 vào tổng
                }

                Console.WriteLine("Tổng của dãy S = 11 + 22 + 33 + ... + " + n + " là: " + sum);
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số nguyên lớn hơn 10.");
            }
            Console.ReadLine();
        }
       
   
        
    }
    
}
