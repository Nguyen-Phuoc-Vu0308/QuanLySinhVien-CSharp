using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so sinh vien cua lop hoc: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("So luong khong ton tai. Thoat chuong trinh");
            }
            else
            {
                double tongdiemtb = 0;
                double soluong = 0;
                double max = 0;

                string[] HoTen = new string[n];
                double[] DiemSo = new double[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Ho ten: ");
                    HoTen[i] = Console.ReadLine();
                    Console.Write("Diem: ");
                    DiemSo[i] = double.Parse(Console.ReadLine());
                    tongdiemtb = tongdiemtb + DiemSo[i];

                    if (DiemSo[i] > max)
                    {
                        max = DiemSo[i];
                    }

                    if (DiemSo[i] >= 5)
                    {
                        soluong++;
                    }
                    
                }

                Console.WriteLine("====//DANH SACH SINH VIEN\\====");

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Sinh vien: {i+1}: {HoTen[i]}  ||  Diem: {DiemSo[i]}");
                }

                Console.WriteLine("====//KET QUA HOC TAP\\====");

                Console.WriteLine("Diem trung binh ca lop: " + tongdiemtb / n);
                Console.WriteLine("Diem cao nhat lop: " + max);
                Console.WriteLine("So sinh vien dat 5d tro len: " + soluong);
            }
        }
    }
}
