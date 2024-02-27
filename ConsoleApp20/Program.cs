using System;

class Program
{
    static void Main()
    {

        #region Task 1 Void
        //Console.WriteLine("1ci deyer daxil edin:");
        //double num1 = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("2 ci deyer daxil edin");
        //double num2 = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Operatoru daxil edin (+, -, *, /):");
        //char operation = Convert.ToChar(Console.ReadLine());

        //Calculate(num1, num2, operation);

        #endregion


        #region Task 2 Void

        //string text = "Hello, world!";
        //char targetChar = 'o';

        //int count = CountCharacters(text, targetChar);
        //Console.WriteLine($"Verilen Simvol'{targetChar}' Simvolarin Sayi: {count}");

        #endregion

        #region Task 3 Void

        //string text = "Salam PB 301";

        //int wordCount = CountWords(text);
        //Console.WriteLine($"Metindeki Kelime sayi: {wordCount}");


        #endregion

        #region Task 4 Void
        //int VerilMishEded = 12345;
        //int cem = ReqemlerinCemi(VerilMishEded);
        //Console.WriteLine(cem);
        #endregion

        #region Task 6 void


        //int[] array = { -1,-2,-3,-4,-5};

        //ConvertNegativesToPositives(ref array);

        //Console.WriteLine("Cavab: " + string.Join(", ", array));
        #endregion

        #region Task 5

        //Console.WriteLine("Verilmsh Deyer");
        //int a= Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Quvvete yukselecek deyer");
        //int b= Convert.ToInt32(Console.ReadLine());

        //double c= Math.Pow(a,b);
        //Console.WriteLine("Cem "+c);


        //int c = a ** b;

        //for (int i = 0; i <=32; i++) {

        //    Console.WriteLine(Math.Pow(a,i));
        //}

        #endregion


        #region Task 7
        string ad = "salam ";
        Ters(ad);
        #endregion

    }





    #region Task 1 
    //static void Calculate(double num1, double num2, char operation)
    //{
    //    double result = 0;

    //    switch (operation)
    //    {
    //        case '+':
    //            result = num1 + num2;
    //            break;
    //        case '-':
    //            result = num1 - num2;
    //            break;
    //        case '*':
    //            result = num1 * num2;
    //            break;
    //        case '/':
    //            if (num2 != 0)
    //                result = num1 / num2;
    //            else
    //                Console.WriteLine("2 ci reqem 0 ola bilmez");
    //            break;
    //        default:
    //            Console.WriteLine("Duzgun deyer daxil edin");
    //            return;
    //    }

    //    Console.WriteLine("Cavab:  " + result);
    //}
    #endregion

    #region Task 2

    //static int CountCharacters(string text, char targetChar)
    //{
    //    int count = 0;

    //    foreach (char c in text)
    //    {
    //        if (c == targetChar)
    //            count++;
    //    }

    //    return count;
    //}

    #endregion

    #region Task 3
    //static int CountWords(string text)
    //{

    //    return text.Split(' ').Length;

    //}

    #endregion

    #region Task 4

    //static int ReqemlerinCemi (int sayi)
    //{

    //    int cem = 0;
    //    while (sayi>0)
    //    {
    //        cem += sayi % 10;
    //        sayi /= 10;
    //    }
    //    return cem;
    //}

    #endregion

    #region Task 6


    //static void ConvertNegativesToPositives(ref int[] array)
    //{
    //    for (int i = 0; i < array.Length; i++)
    //    {
    //        if (array[i] < 0)
    //        {
    //            array[i] *= -1;
    //        }
    //    }
    //}

    #endregion

    #region Task 7
    static void Ters(string word)
    {
        for (int i = word.Length - 1; i >= 0; i--)
        {
            if (char.IsLetter(word[i]))

            {
                Console.Write(word[i]);
            }
        }
        #endregion
    }
}
