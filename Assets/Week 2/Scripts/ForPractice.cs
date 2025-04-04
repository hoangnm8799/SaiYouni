using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForPractise : MonoBehaviour
{
    private void Start()
    {
        BaiTap1();
        BaiTap2();
        BaiTap3();
        BaiTap4();
        BaiTap5();
        BaiTap6();
        BaiTap7();
        BaiTap8();
        BaiTap9();
        BaiTap10();
        BaiTap11();
        BaiTap12();
        BaiTap13();
        BaiTap14();
        BaiTap15();
        BaiTap16();
        BaiTap17();
        BaiTap18();
        BaiTap19();
        BaiTap20();
    }

    // Bài Tập 1: In Các Số Từ 1 Đến 100
    void BaiTap1()
    {
        for (int i = 1; i <= 100; i++)
        {
            Debug.Log(i);
        }
    }


    // Bài Tập 2: Tính Tổng Các Số Từ 1 Đến 50
    void BaiTap2()
    {
        int sum = 0;
        for (int i = 1; i <= 50; i++)
        {
            sum += i;
        }
        Debug.Log("Tổng các số từ 1 đến 50 là: " + sum);
    }


    // Bài Tập 3: In Các Số Chẵn Từ 1 Đến 100
    void BaiTap3()
    {
        for (int i = 2; i <= 100; i += 2)
        {
            Debug.Log(i);
        }
    }

    // Bài Tập 4: Tính Tích Các Số Từ 1 Đến 10
    void BaiTap4()
    {
        int result = 1;
        for (int i = 1; i <= 10; i++)
        {
            result *= i;
        }
        Debug.Log("Tích các số từ 1 đến 10 là: " + result);
    }


    // Bài Tập 5: Tìm Số Lớn Nhất Trong Một Mảng
    void BaiTap5()
    {
        int[] numbers = { 5, 12, 8, 21, 3 };
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        Debug.Log("Số lớn nhất trong mảng là: " + max);
    }


    // Bài Tập 6: Tính Tổng Các Số Lẻ Từ 1 Đến 100
    void BaiTap6()
    {
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 != 0)  // Kiểm tra số lẻ
            {
                sum += i;
            }
        }
        Debug.Log("Tổng các số lẻ từ 1 đến 100 là: " + sum);
    }


    // Bài Tập 7: Đảo Ngược Chuỗi
    void BaiTap7()
    {
        string input = "Hello, World!";
        string reversed = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }
        Debug.Log("Chuỗi đảo ngược là: " + reversed);
    }


    // Bài Tập 8: In Ra Bảng Cửu Chương
    void BaiTap8()
    {
        int number = 5;  // Ví dụ bảng cửu chương của số 5
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log(number + " x " + i + " = " + (number * i));
        }
    }


    // Bài Tập 9: Đếm Các Số Nguyên Dương Trong Mảng
    void BaiTap9()
    {
        int[] numbers = { -5, 12, 8, -21, 3 };
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)  // Kiểm tra số nguyên dương
            {
                count++;
            }
        }
        Debug.Log("Số lượng số nguyên dương trong mảng là: " + count);
    }


    // Bài Tập 10: In Tam Giác Số
    void BaiTap10()
    {
        int n = 5;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Debug.Log(j);
            }
        }
    }


    // Bài Tập 11: Tìm Phần Tử Nhỏ Nhất Trong Mảng
    void BaiTap11()
    {
        int[] numbers = { 5, 12, 8, 21, 3 }; 
        int min = numbers[0]; 
        for (int i = 1; i < numbers.Length; i++) 
        {
            if (numbers[i] < min) 
            {
                min = numbers[i];
            }
        }
        Debug.Log("Phần tử nhỏ nhất trong mảng là: " + min);
    }


    // Bài Tập 12: In Dãy Fibonacci
    void BaiTap12()
    {
        int n = 10; // số lượng phần tử trong dãy Fibonacci
        int a = 0, b = 1;
        Debug.Log(a); 
        Debug.Log(b);
        for (int i = 3; i <= n; i++)
        {
            int next = a + b;
            Debug.Log(next);
            a = b;
            b = next;
        }
    }


    // Bài Tập 13: Tính Giai Thừa Của Một Số
    void BaiTap13()
    {
        int n = 5;
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        Debug.Log("Giai thừa của " + n + " là: " + result);
    }


    // Bài Tập 14: In Ra Các Số Nguyên Từ n Đến 1
    void BaiTap14()
    {
        int n = 10;
        for (int i = n; i >= 1; i--)
        {
            Debug.Log(i);
        }
    }


    // Bài Tập 15: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap15()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Debug.Log("Tổng các phần tử trong mảng là: " + sum);
    }


    // Bài Tập 16: Kiểm Tra Số Nguyên Tố
    void BaiTap16()
    {
        int number = 29;
        bool isPrime = true;

        for (int i = 2; i <= Mathf.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        Debug.Log(isPrime ? "Số nguyên tố" : "Không phải số nguyên tố");
    }

    // Bài Tập 17: In Ra Dãy Số Chia Hết Cho 3
    void BaiTap17()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Debug.Log(i);
            }
        }
    }

    // Bài Tập 18: Tìm Tổng Các Số Chẵn Trong Mảng
    void BaiTap18()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                sum += array[i];
            }
        }

        Debug.Log("Tổng các số chẵn: " + sum);
    }

    // Bài Tập 19: Tính Trung Bình Cộng Của Mảng
    void BaiTap19()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        float average = sum / (float)array.Length;
        Debug.Log("Trung bình cộng: " + average);
    }

    // Bài Tập 20: Đếm Số Ký Tự Hoa Trong Chuỗi
    void BaiTap20()
    {
        string str = "Hello World!";
        int count = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsUpper(str[i]))
            {
                count++;
            }
        }

        Debug.Log("Số ký tự hoa: " + count);
    }

}
