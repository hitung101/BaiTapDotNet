using HuongDoiTuong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuongDoiTuong
{
   internal class Class1
    {
        static void Main(string[] args)
        {
            //khoi tao doi tuong lop hoc sinh 
            hocsinh Hocsinh = new hocsinh();
         
            //nhap thong tin sv
            Console.WriteLine("Nhap thong tin hoc sinh ");
            Hocsinh.NhapHS();
            //
            //hien thi doi tuong hoc sinh
            Console.WriteLine("Hien thi thong tin hs theo contructor 1");
            Hocsinh.XuatHS();
            Console.WriteLine("Hien thi thong tin hs theo contructor 2, co doi tuong tryten vao");
            Hocsinh.XuatHS();


            Console.Read();
        }

    }
}
