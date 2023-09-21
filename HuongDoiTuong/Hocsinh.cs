using System;

namespace HuongDoiTuong
{
    internal class hocsinh
    {
        // Khai báo thuộc tính
        private int Mahs;
        private string tenhs;
        private int namsinh;
        private string diachi;
        private double diemToan;
        private double diemVan;
        private double diemAnh;

        // Khai báo hàm khởi tạo đối tượng (Constructor)
        public hocsinh()
        {

        }
        
        // Xây dựng hàm khởi tạo đối tượng
        public hocsinh(int ma, string ten, int ns, string diaChi, double toan, double van, double anh)
        {
            Mahs = ma;
            tenhs = ten;
            namsinh = ns;
            diachi = diaChi;
            diemToan = toan;
            diemVan = van;
            diemAnh = anh;
        }

        public void NhapHS()
        {
            Console.Write("Nhap ma HS: ");
            Mahs = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ten sinh vien: ");
            tenhs = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            namsinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap dia chi: ");
            diachi = Console.ReadLine();
            Console.Write("Nhap diem toan: ");
            diemToan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem van: ");
            diemVan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem anh: ");
            diemAnh = Convert.ToDouble(Console.ReadLine());
        }

        // Viết hàm tính điểm trung bình
        public double TinhDTB()
        {
            double DTB = Math.Round((diemAnh + diemToan + diemVan) / 3, 1);
            return DTB;
        }

        public void XuatHS()
        {
            Console.WriteLine("Thong tin sinh vien la: ");
            Console.WriteLine($"Ma HS: {Mahs}");
            Console.WriteLine($"Ten HS: {tenhs}");
            Console.WriteLine($"Nam Sinh: {namsinh}");
            Console.WriteLine($"Dia chi: {diachi}");
            Console.WriteLine($"Diem Trung Binh: {TinhDTB()}");
        }
    }
}
