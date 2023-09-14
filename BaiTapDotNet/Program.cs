using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chương trình quản lý tài chính bản thân");

            // Nhập số tiền còn trong tài khoản đầu tháng
            Console.Write("Nhập số tiền trong tài khoản đầu tháng: ");
            double soTienTrongTaiKhoan = double.Parse(Console.ReadLine());

            // Nhập và tính toán các giao dịch trong tháng
            double tongGiaoDich = 0;
            double giaoDich;
            do
            {
                Console.Write("Nhập giá trị giao dịch (nhập số âm để kết thúc): ");
                giaoDich = double.Parse(Console.ReadLine());

                if (giaoDich >= 0)
                {
                    tongGiaoDich += giaoDich;
                }
            } while (giaoDich >= 0);

            // Tính số tiền còn lại trong tài khoản
            double soTienConLai = soTienTrongTaiKhoan - tongGiaoDich;

            // Hiển thị số tiền còn lại
            Console.WriteLine("Số tiền còn lại trong tài khoản: " + soTienConLai);
            Console.ReadLine();
        }

    }
}
