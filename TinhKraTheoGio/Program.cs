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
            const decimal hourlyRate = 50.0m; // Giá thuê phòng karaoke mỗi giờ (VD: 50.0 đồng)

            // Hiển thị thông tin cho người dùng
            Console.WriteLine("Chào mừng bạn đến với hệ thống tính tiền karaoke!");

            // Nhập số giờ sử dụng phòng
            Console.Write("Nhập số giờ sử dụng phòng karaoke: ");
            string input = Console.ReadLine();

            // Xử lý lỗi nếu người dùng nhập không phải số
            if (!decimal.TryParse(input, out decimal hours) || hours < 0)
            {
                Console.WriteLine("Số giờ không hợp lệ. Vui lòng nhập một số dương.");
                return;
            }

            // Tính toán số tiền cần phải trả
            decimal totalAmount = hours * hourlyRate;

            // Hiển thị số tiền phải trả
            Console.WriteLine($"Số tiền cần phải trả cho {hours} giờ sử dụng phòng karaoke là: {totalAmount} đồng.");

            // Dừng lại để người dùng xem kết quả
            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
