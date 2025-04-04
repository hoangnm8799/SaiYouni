using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatementPractise : MonoBehaviour
{
    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra số dương, âm, hoặc bằng 0
        BaiTap2(); // Kiểm tra số chẵn hay lẻ
        BaiTap3(); // Kiểm tra điều kiện thi đỗ
        BaiTap4(); // Tìm số lớn nhất trong hai số
        BaiTap5(); // Kiểm tra điều kiện mua hàng
        BaiTap6(); // Kiểm tra năm nhuận
        BaiTap7(); // Tính giá vé xem phim
        BaiTap8(); // Kiểm tra học sinh xuất sắc
        BaiTap9(); // So sánh ba số
        BaiTap10(); // Tính tiền lương
        BaiTap11(); // Kiểm tra điều kiện vào câu lạc bộ
        BaiTap12(); // Phân loại học sinh
        BaiTap13(); // Tính tiền điện
        BaiTap14(); // Kiểm tra điều kiện thăng chức
        BaiTap15(); // Kiểm tra điều kiện miễn phí vận chuyển
        BaiTap16(); // Tính thuế thu nhập cá nhân
        BaiTap17(); // Tính điểm trung bình của môn học
        BaiTap18(); // Kiểm tra điều kiện nhập hàng
        BaiTap19(); // Tìm số lớn hơn 10
        BaiTap20(); // Kiểm tra điều kiện đăng ký khóa học
    }

    // Bài Tập 1: Kiểm Tra Số Dương, Âm Hoặc Bằng 0
    void BaiTap1()
    {
        int number = 0; // Nhập số từ bàn phím
        if (number > 0)
        {
            Debug.Log("Số dương");
        }
        else if (number < 0)
        {
            Debug.Log("Số âm");
        }
        else
        {
            Debug.Log("Bằng 0");
        }
    }

    // Bài Tập 2: Kiểm Tra Số Chẵn Hay Lẻ
    void BaiTap2()
    {
        int number = 5; // Nhập số từ bàn phím
        if (number % 2 == 0)
        {
            Debug.Log("Số chẵn");
        }
        else
        {
            Debug.Log("Số lẻ");
        }
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Thi Đỗ
    void BaiTap3()
    {
        float averageScore = 4.5f; // Nhập điểm trung bình từ bàn phím
        if (averageScore >= 5.0f)
        {
            Debug.Log("Học sinh đỗ");
        }
        else
        {
            Debug.Log("Học sinh trượt");
        }
    }

    // Bài Tập 4: Tìm Số Lớn Nhất Trong Hai Số
    void BaiTap4()
    {
        int number1 = 7, number2 = 10; // Nhập hai số từ bàn phím
        if (number1 > number2)
        {
            Debug.Log("Số lớn nhất là: " + number1);
        }
        else
        {
            Debug.Log("Số lớn nhất là: " + number2);
        }
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap5()
    {
        float money = 150000f, productPrice = 100000f; // Nhập số tiền và giá sản phẩm
        if (money >= productPrice)
        {
            Debug.Log("Có đủ tiền để mua hàng");
        }
        else
        {
            Debug.Log("Không đủ tiền để mua hàng");
        }
    }

    // Bài Tập 6: Kiểm Tra Năm Nhuận
    void BaiTap6()
    {
        int year = 2024; // Nhập năm
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Debug.Log("Năm nhuận");
        }
        else
        {
            Debug.Log("Không phải năm nhuận");
        }
    }

    // Bài Tập 7: Tính Giá Vé Xem Phim
    void BaiTap7()
    {
        int age = 17; // Nhập tuổi của người mua vé
        if (age < 18)
        {
            Debug.Log("Giá vé: 50,000 đồng");
        }
        else
        {
            Debug.Log("Giá vé: 100,000 đồng");
        }
    }

    // Bài Tập 8: Kiểm Tra Học Sinh Xuất Sắc
    void BaiTap8()
    {
        float averageScore = 9.5f; // Nhập điểm trung bình của học sinh
        if (averageScore >= 9.0f)
        {
            Debug.Log("Học sinh xuất sắc");
        }
        else
        {
            Debug.Log("Không phải học sinh xuất sắc");
        }
    }

    // Bài Tập 9: So Sánh Ba Số
    void BaiTap9()
    {
        int num1 = 3, num2 = 7, num3 = 5; // Nhập ba số từ bàn phím
        int max = num1;
        if (num2 > max) max = num2;
        if (num3 > max) max = num3;
        Debug.Log("Số lớn nhất là: " + max);
    }

    // Bài Tập 10: Tính Tiền Lương
    void BaiTap10()
    {
        int hoursWorked = 45; // Nhập số giờ làm việc
        float hourlyRate = 100000f; // Nhập mức lương cố định
        if (hoursWorked > 40)
        {
            float overtimeRate = 150000f; // Mức lương giờ làm thêm
            float totalPay = (40 * hourlyRate) + ((hoursWorked - 40) * overtimeRate);
            Debug.Log("Lương: " + totalPay);
        }
        else
        {
            float totalPay = hoursWorked * hourlyRate;
            Debug.Log("Lương: " + totalPay);
        }
    }

    // Bài Tập 11: Kiểm Tra Điều Kiện Vào Câu Lạc Bộ
    void BaiTap11()
    {
        int age = 20; // Nhập tuổi
        bool hasMembership = true; // Kiểm tra thẻ thành viên
        if (age >= 18 && hasMembership)
        {
            Debug.Log("Được vào câu lạc bộ");
        }
        else
        {
            Debug.Log("Không được vào câu lạc bộ");
        }
    }

    // Bài Tập 12: Phân Loại Học Sinh
    void BaiTap12()
    {
        float averageScore = 6.5f; // Nhập điểm trung bình
        if (averageScore >= 9.0f)
        {
            Debug.Log("Học sinh xuất sắc");
        }
        else if (averageScore >= 7.0f)
        {
            Debug.Log("Học sinh khá");
        }
        else if (averageScore >= 5.0f)
        {
            Debug.Log("Học sinh trung bình");
        }
        else
        {
            Debug.Log("Học sinh yếu");
        }
    }

    // Bài Tập 13: Tính Tiền Điện
    void BaiTap13()
    {
        int electricityUsage = 120; // Nhập số điện tiêu thụ
        float bill = 0f;
        if (electricityUsage <= 100)
        {
            bill = electricityUsage * 1500f;
        }
        else
        {
            bill = (100 * 1500f) + ((electricityUsage - 100) * 2000f);
        }
        Debug.Log("Tiền điện: " + bill + " đồng");
    }

    // Bài Tập 14: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap14()
    {
        int yearsWorked = 6; // Nhập số năm làm việc
        string performanceRating = "Tốt"; // Nhập đánh giá công việc
        if (yearsWorked > 5 && performanceRating == "Tốt")
        {
            Debug.Log("Đủ điều kiện thăng chức");
        }
        else
        {
            Debug.Log("Không đủ điều kiện thăng chức");
        }
    }

    // Bài Tập 15: Kiểm Tra Điều Kiện Miễn Phí Vận Chuyển
    void BaiTap15()
    {
        float orderValue = 600000f; // Nhập giá trị đơn hàng
        if (orderValue >= 500000f)
        {
            Debug.Log("Miễn phí vận chuyển");
        }
        else
        {
            Debug.Log("Không miễn phí vận chuyển");
        }
    }

    // Bài Tập 16: Tính Thuế Thu Nhập Cá Nhân
    void BaiTap16()
    {
        float income = 12000000f; // Nhập thu nhập
        float tax = 0f;
        if (income <= 5000000)
        {
            tax = income * 0.05f;
        }
        else if (income <= 10000000)
        {
            tax = income * 0.1f;
        }
        else
        {
            tax = income * 0.2f;
        }
        Debug.Log("Thuế thu nhập cá nhân: " + tax);
    }

    // Bài Tập 17: Tính Điểm Trung Bình Của Môn Học
    void BaiTap17()
    {
        float exam1 = 6.5f, exam2 = 8.0f, exam3 = 7.5f; // Nhập điểm các bài kiểm tra
        float averageScore = (exam1 + exam2 + exam3) / 3f;
        if (averageScore >= 5.0f)
        {
            Debug.Log("Học sinh đạt yêu cầu");
        }
        else
        {
            Debug.Log("Học sinh không đạt yêu cầu");
        }
    }

    // Bài Tập 18: Kiểm Tra Điều Kiện Nhập Hàng
    void BaiTap18()
    {
        int goods = 40;
        int currentStock = 50; // Nhập số lượng hàng hiện có
        int maxStock = 100; // Kiểm tra số lượng hàng tối đa có thể nhập
        if (currentStock < 100 && goods + currentStock < maxStock)
        {
            Debug.Log("Có thể nhập hàng thêm");
        }
        else
        {
            Debug.Log("Không thể nhập hàng thêm");
        }
    }

    // Bài Tập 19: Tìm Số Lớn Hơn 10
    void BaiTap19()
    {
        int number = 12; // Nhập số
        if (number > 10)
        {
            Debug.Log("Số lớn hơn 10");
        }
        else
        {
            Debug.Log("Số không lớn hơn 10");
        }
    }

    // Bài Tập 20: Kiểm Tra Điều Kiện Đăng Ký Khóa Học
    void BaiTap20()
    {
        bool isIntroLetter = false;
        bool isCompletedBasic = true;
        float finalScore = 8.0f; // Nhập điểm tổng kết
        if (finalScore >= 7f && isCompletedBasic && isIntroLetter)
        {
            Debug.Log("Đủ điều kiện đăng ký khóa học nâng cao");
        }
        else
        {
            Debug.Log("Không đủ điều kiện đăng ký khóa học nâng cao");
        }
    }
}
