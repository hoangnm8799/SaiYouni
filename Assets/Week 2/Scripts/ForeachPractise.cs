using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class ForeachPractise : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // In tất cả các phần tử trong mảng
        BaiTap2(); // Tính tổng các phần tử trong mảng
        BaiTap3(); // Tìm phần tử lớn nhất trong mảng
        BaiTap4(); // Đếm số lượng số chẵn trong mảng
        BaiTap5(); // In tất cả các chuỗi trong danh sách
        BaiTap6(); // Tìm chuỗi dài nhất trong danh sách
        BaiTap7(); // Tính tổng các số lẻ trong mảng
        BaiTap8(); // In các số chẵn trong mảng
        BaiTap9(); // Kiểm tra sự tồn tại của một phần tử trong mảng
        BaiTap10(); // Đếm số phần tử âm trong mảng
        BaiTap11(); // In các số lớn hơn 10 trong mảng
        BaiTap12(); // Tìm chuỗi có độ dài ngắn nhất trong danh sách
        BaiTap13(); // Nhân đôi tất cả các phần tử trong mảng
        BaiTap14(); // Tìm số lớn thứ hai trong mảng
        BaiTap15(); // Tìm chuỗi bắt đầu bằng chữ cái A
        BaiTap16(); // Kiểm tra danh sách có chứa chuỗi "Hello" không
        BaiTap17(); // In tất cả các phần tử âm trong mảng
        BaiTap18(); // Đếm số lần xuất hiện của một phần tử trong mảng
        BaiTap19(); // Tạo danh sách mới từ các phần tử lớn hơn 10
        BaiTap20(); // In các chuỗi có độ dài lớn hơn 5 ký tự
    }

    static int[] RandomIntArray(int size, int minValue, int maxValue)
    {
        int[] numbers = new int[size];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Random.Range(minValue, maxValue);
        }

        return new int[size];
    }

    static List<string> RandomStringArray(int arraySize, int stringLength) {

        List<string> strings = new();
        for (int i = 0; i < arraySize; i++)
        {

            strings.Add(RandomString(stringLength));
        }

        return strings;
    }

    static string RandomString(int length) {
        StringBuilder stringBuilder = new StringBuilder();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        for (int i = 0; i < length; i++)
        {
            stringBuilder.Append(chars[Random.Range(0, chars.Length)]);
        }
        return stringBuilder.ToString();
    }

    // Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng
    void BaiTap1()
    {
        // Tạo một mảng số nguyên
        int[] numbers = RandomIntArray(10, 1, 100);
        // Sử dụng foreach để in tất cả các phần tử trong mảng
        foreach (int i in numbers) {
            Debug.Log(i);
        }
    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
        // Tạo một mảng số nguyên
        int[] numbers = RandomIntArray(10, 1, 100);
        int sum = 0;
        // Sử dụng foreach để tính tổng tất cả các phần tử trong mảng
        foreach (int i in numbers)
        {
            sum += i;
        }
        Debug.Log(sum);
    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        // Tạo một mảng số nguyên
        int[] numbers = RandomIntArray(10,1,100);
        int max = 0;
        // Sử dụng foreach để tìm phần tử lớn nhất trong mảng
        foreach (int i in numbers)
        {
           if (i > max) {  max = i; }
        }
        Debug.Log(max);
    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        // Tạo một mảng số nguyên
        int[] numbers = RandomIntArray(10,1,100);
        int count = 0;
        // Sử dụng foreach để đếm số lượng phần tử chẵn trong mảng
        foreach(int i in numbers)
        {
            if(i%2==0) {  count++; }
        }
        Debug.Log(count);
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        // Tạo một danh sách các chuỗi
        List<string> strings = RandomStringArray(10, Random.Range(1,11));
        // Sử dụng foreach để in tất cả các chuỗi trong danh sách
        foreach(string s in strings) { Debug.Log(s); }
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        // Tạo một danh sách các chuỗi
        List<string> strings = RandomStringArray(10, 5);
        // Sử dụng foreach để tìm chuỗi dài nhất trong danh sách
        string maxLengthString = strings.FirstOrDefault();
        foreach(string s in strings)
        {
            if(s.Length > maxLengthString.Length) { maxLengthString = s; };
        }
    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        // Tạo một mảng số nguyên
        int[] numbers = RandomIntArray(10, 1,100);
        int sum = 0;
        // Sử dụng foreach để tính tổng tất cả các số lẻ trong mảng
        foreach (int i in numbers)
        {
            if (i % 2 != 0)
            {
                sum += i;
            }
        }
        Debug.Log(sum);
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        // Tạo một mảng số nguyên
        int[] numbers = RandomIntArray(10, 1, 100);
        // Sử dụng foreach để in tất cả các số chẵn trong mảng
        foreach (int i in numbers)
        {
           if ((i % 2) == 0)
            {
                Debug.Log(i);
            }
        }
    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9()
    {
        // Tạo một mảng số nguyên và một phần tử cần kiểm tra
        int[] numbers = RandomIntArray(10, 1, 100);
        int checkInt = Random.Range(1, 100);
        bool flag = false;
        // Sử dụng foreach để kiểm tra xem phần tử đó có tồn tại trong mảng không
        foreach(int i in numbers)
        {
            if(i == checkInt) { flag = true; break; }
        }
        Debug.Log(flag);
    }

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    void BaiTap10()
    {
        // Tạo một mảng số nguyên
        int[] numbers = RandomIntArray(10, -100, 100);
        int count = 0;
        // Sử dụng foreach để đếm số lượng các phần tử âm trong mảng
        foreach(int i in numbers)
        {
            if(i<0) { count++; }
        }
        Debug.Log(count);
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        // Tạo một mảng số nguyên
        int[] numbers = RandomIntArray(10, -100, 100);
        // Sử dụng foreach để in các số lớn hơn 10 trong mảng
        foreach(int i in numbers)
        {
            if(i>10)
            {
                Debug.Log(i);
            }
        }
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12()
    {
        // Tạo một danh sách các chuỗi
        List<string> strings = RandomStringArray(10, Random.Range(1, 10));
        string minLengthString = strings.FirstOrDefault();
        // Sử dụng foreach để tìm chuỗi có độ dài ngắn nhất trong danh sách
        foreach(string s in strings)
        {
            if (s.Length < minLengthString.Length)
            {
                minLengthString = s;
            }
        }
        Debug.Log(minLengthString);
    }

    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    void BaiTap13()
    {
        // Tạo một mảng số nguyên
        int[] numbers = RandomIntArray(10, -100, 100);
        // Sử dụng foreach để nhân đôi tất cả các phần tử trong mảng
        // Không dùng foreach được vì biến trong foreach không thay đổi giá trị được
        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] *= 2;
        }

        foreach(int i in numbers) { Debug.Log(i); }
    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        // Tạo một mảng số nguyên
        int[] numbers = RandomIntArray(10, -100, 100);
        int maxNum = numbers.FirstOrDefault();
        int secNum = 0;
        // Sử dụng foreach để tìm phần tử lớn thứ hai trong mảng
        foreach (int i in numbers)
        {
            if(i > maxNum)
            {
                maxNum = i;
            }
            if(maxNum > i && i > secNum)
            {
                secNum = i;
            }
        }
        Debug.Log(secNum);
    }

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {
        // Tạo một danh sách các chuỗi
        List<string> strings = RandomStringArray(10, Random.Range(1, 10));
        // Sử dụng foreach để tìm và in các chuỗi bắt đầu bằng chữ cái 'A'
        foreach(string s in strings)
        {
            if (s.StartsWith("A"))
            {
                Debug.Log(s);
            }
        }
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16()
    {
        // Tạo một danh sách các chuỗi
        List<string> strings = RandomStringArray(10, Random.Range(1, 10));

        // Sử dụng foreach để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không
        foreach (string s in strings)
        {
            if (s.Contains("Hello"))
            {
                Debug.Log(s);
            }
        }
    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        // Tạo một mảng số nguyên
        int[] numbers = RandomIntArray(10,-100,100);
        // Sử dụng foreach để in ra tất cả các phần tử âm trong mảng
        foreach (int i in numbers)
        {
            if (i < 0)
            {
                Debug.Log(i);
            }
        }
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18()
    {
        // Tạo một mảng số nguyên và một phần tử cụ thể
        int[] numbers = RandomIntArray(100, -100, 100);
        int num = Random.Range(-100, 100);
        int count = 0;
        // Sử dụng foreach để đếm số lần xuất hiện của phần tử cụ thể đó trong mảng
        foreach (int i in numbers)
        {
            if (i == num)
            {
                count++;
            }
        }
        Debug.Log(count);
    }

    // Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    void BaiTap19()
    {
        // Tạo một mảng số nguyên
        int[] numbers = RandomIntArray(100, -100, 100);
        List<int> newArray = new();
        // Sử dụng foreach để tạo một danh sách mới chứa các phần tử có giá trị lớn hơn 10
        foreach (int i in numbers)
        {
            if (i > 10)
            {
                newArray.Add(i);
            }
        }
        newArray.ForEach(i =>  { Debug.Log(i); });
    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        // Tạo một danh sách các chuỗi
        List<string> strings = RandomStringArray(10, Random.Range(1, 10));
        // Sử dụng foreach để in các chuỗi có độ dài lớn hơn 5 ký tự

        foreach (string s in strings)
        {
            if (s.Length > 5)
            {
                Debug.Log(s);
            }
        }
    }

}
