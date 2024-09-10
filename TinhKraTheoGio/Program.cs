using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhKraTheoGio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Định nghĩa giá thuê phòng per hour
            const decimal hourlyRate = 50.0m; // Giá thuê phòng karaoke mỗi giờ (VD: 50.0 đồng)..

            // Hiển thị thông tin cho người dùng,
            Console.WriteLine("He thong tin tien karaoke!");

            // Nhập số giờ sử dụng phòng
            Console.Write("Vui long nhap so gio su dung phong karaoke: ");
            string input = Console.ReadLine();

            // Xử lý lỗi nếu người dùng nhập không phải số.
            if (!decimal.TryParse(input, out decimal hours) || hours < 0)
            {
                Console.WriteLine("So gio khong hop le. Vui long nhap so duong.");
                return;
            }

            // Tính toán số tiền cần phải trả
            decimal totalAmount = hours * hourlyRate;

            // Hiển thị số tiền phải trả
            Console.WriteLine($"So tien phai tra cho {hours} gio su dung phong karaoke la: {totalAmount} dong.");

            // Dừng lại để người dùng xem kết quả
            Console.WriteLine("Nhan mot phim bat ki de thoat...");
            Console.ReadKey();
        }
    }
}
