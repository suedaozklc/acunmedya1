using System;
using System.Text.RegularExpressions;

class Program
{
    // 1. Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme (if-else)
    static void CheckNumber()
    {
        Console.WriteLine("Bir sayı girin: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine("Pozitif");
        }
        else if (num < 0)
        {
            Console.WriteLine("Negatif");
        }
        else
        {
            Console.WriteLine("Sıfır");
        }
    }

    // 2. Gün İsmi Belirleme (switch-case)
    static void GetDayName()
    {
        Console.WriteLine("Bir gün numarası girin (1-7 arası): ");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Pazartesi");
                break;
            case 2:
                Console.WriteLine("Salı");
                break;
            case 3:
                Console.WriteLine("Çarşamba");
                break;
            case 4:
                Console.WriteLine("Perşembe");
                break;
            case 5:
                Console.WriteLine("Cuma");
                break;
            case 6:
                Console.WriteLine("Cumartesi");
                break;
            case 7:
                Console.WriteLine("Pazar");
                break;
            default:
                Console.WriteLine("Geçersiz gün numarası");
                break;
        }
    }

    // 3. Basit Hesap Makinesi (switch-case)
    static void Calculator()
    {
        Console.WriteLine("Birinci sayıyı girin: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("İkinci sayıyı girin: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("İşlem türünü girin (+, -, *, /): ");
        string operation = Console.ReadLine();

        double result;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Bölme hatası: sıfıra bölünemez.");
                    return;
                }
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Geçersiz işlem.");
                return;
        }

        Console.WriteLine("Sonuç: " + result);
    }

    // 4. Üç Sayının En Büyüğünü Bulma (if-else)
    static void FindLargest()
    {
        Console.WriteLine("Üç sayı girin:");
        Console.WriteLine("Birinci sayıyı girin: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("İkinci sayıyı girin: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Üçüncü sayıyı girin: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int largest = num1;

        if (num2 > largest)
        {
            largest = num2;
        }
        if (num3 > largest)
        {
            largest = num3;
        }

        Console.WriteLine("En büyük sayı: " + largest);
    }

    // 5. Şifre Güçlülüğünü Kontrol Etme (if-else)
    static void CheckPasswordStrength()
    {
        Console.WriteLine("Bir şifre girin: ");
        string password = Console.ReadLine();

        if (password.Length < 8)
        {
            Console.WriteLine("Şifre en az 8 karakter uzunluğunda olmalı.");
        }
        else if (!Regex.IsMatch(password, @"[@#$%]"))
        {
            Console.WriteLine("Şifre en az bir özel karakter içermeli (@, #, $, % gibi).");
        }
        else if (!Regex.IsMatch(password, @"[A-Z]"))
        {
            Console.WriteLine("Şifre en az bir büyük harf içermeli.");
        }
        else
        {
            Console.WriteLine("Şifre güçlü.");
        }
    }

    static void Main()
    {
        // Kullanıcıya seçenekler sunalım
        Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
        Console.WriteLine("1. Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme");
        Console.WriteLine("2. Gün İsmi Belirleme");
        Console.WriteLine("3. Hesap Makinesi");
        Console.WriteLine("4. Üç Sayının En Büyüğünü Bulma");
        Console.WriteLine("5. Şifre Güçlülüğünü Kontrol Etme");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CheckNumber();
                break;
            case 2:
                GetDayName();
                break;
            case 3:
                Calculator();
                break;
            case 4:
                FindLargest();
                break;
            case 5:
                CheckPasswordStrength();
                break;
            default:
                Console.WriteLine("Geçersiz seçim");
                break;
        }
    }
}
