using System;

namespace CSharp_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Beginner
            //    // AvarageCalculation();
            //    //TriangleDrawing();    
            //    // DrawACircle();
            //    // CharacterReversePrinting();

            #endregion
            #region Middle 
            //AreaCalculation();
            //SumofIntegerBinaries();
           // consonant();
            #endregion
        }
        
        #region BeginnerLevel




        //private static void CharacterReversePrinting()
        //{
        //    string word = "merhaba";

        //    for (int i = word.Length - 1; i >= 0; i--)
        //    {
        //        Console.Write(word[i]);
        //    }
        //}

        //private static void DrawACircle()
        //{
        //    Console.WriteLine("Lütfen yarıçap giriniz..");
        //    int r = Convert.ToInt32(Console.ReadLine());

        //    DrawCircle(r, '.');
        //}

        //static void DrawCircle(int yaricap, char sembol)
        //    {
        //        int cap = yaricap * 2;
        //        int x, y;
        //        for (int i = 0; i <= cap; i++)

        //        {
        //            for (int j = 0; j <= cap; j++)
        //            {
        //                x = yaricap - i;
        //                y = yaricap - j;

        //                if (x * x + y * y == yaricap * yaricap) Console.Write(sembol);

        //                else Console.Write("  ");


        //            }

        //            Console.WriteLine();

        //        }

            



        //}

        //private static void TriangleDrawing()
        //{
        //    Console.Write("enter triangle size :");
        //    int size = Convert.ToInt32(Console.ReadLine());




        //    for (int i = 0; i < size + 1; i++)
        //    {
        //        for (int j = 0; j < i; j++)
        //        {
        //            Console.Write("*");
        //        }
        //        Console.WriteLine("");
        //    }
        //    Console.WriteLine("");
        //}

        //private static void AvarageCalculation()
        //{
        //    Console.WriteLine("Input in a Number");
        //    float number = Convert.ToUInt16(Console.Read());
        //    float num1 = 0;
        //    float num2 = 1;
        //    float num3 = 0;
        //    for (int i = 0; i < number; i++)
        //    {
        //        num3 = num1 + num2;
        //        num1 = num2;
        //        num2 = num3;
        //    }
        //    Console.WriteLine("Girdiğiniz Sayının Fibonacci Ortalaması : {0}", num3 / num1);
        //}
        
        
        
        #endregion
        #region MidLevel
                #region AreaCalculationn
        //  private static void AreaCalculation()
        //       {
        //           Console.Write("1-Circle\n2-Square \n3-Rectangle \n" +
        //                         "Select the geometric shape you want to process:");

        //           int choice = Convert.ToInt32(Console.ReadLine());

        //           switch (choice)
        //           {
        //               case 1:
        //                   Console.Write("input r : ");
        //                   int r = Convert.ToInt32(Console.ReadLine());
        //                   Circle(r);
        //                   break;
        //               case 2:
        //                   Console.Write("input edge : ");
        //                   int e = Convert.ToInt32(Console.ReadLine());
        //                   Square(e);
        //                   break;
        //               case 3:
        //                   Console.Write("input edge : ");
        //                   int a = Convert.ToInt32(Console.ReadLine());
        //                   int b = Convert.ToInt32(Console.ReadLine());
        //                   Rectangle(a, b);
        //                   break;
        //               default:
        //                   Console.WriteLine("Wrong Choice");

        //                   break;
        //           }
        //       }
        //                           #region AreaCalculation

        //private static void  Circle(int edge  )
        //       {
        //           const double pi = 3.1415926535897931;
        //           double islem = edge * edge * pi;
        //           Console.WriteLine("circle area: "+islem.ToString() );
        //       }
        //       private static void Square(int edge)
        //       {
        //           double square = edge * edge;
        //           Console.WriteLine("Square area: " + square.ToString() );
        //       }
        //       private static void Rectangle(int a , int b )
        //       {
        //           int islem = a * b;
        //           Console.WriteLine("Rectangle area: "+ islem.ToString()  );
        //       }

        //       #endregion

        #endregion
                #region SumofIntegerBinaries

        // private static void SumofIntegerBinaries()
        //{
        //    int n = 0;
        //    Console.WriteLine("input  n value");
        //    n = Convert.ToInt32(Console.ReadLine());
        //    int[] number = new int[n];
        //    for (int i = 0; i < n; i++)
        //    {

        //        Console.WriteLine(i + 1 + "- input value :  ");
        //        int number1 = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine(i + 1 + "- input value :  ");
        //        int number2 = Convert.ToInt32(Console.ReadLine());
        //        number[i] = number1 + number2;
        //    }

        //    foreach (var item in number)
        //    {
        //        Console.Write(item);
        //    }
        //}

        #endregion
                #region   consonant
        //private static void consonant()
        //{
        //    Console.WriteLine("Enter string expression");
        //    string text = Console.ReadLine();
        //    string consonant = "zyvtşsrpnrmlkhjgdçcb";
        //    int count = 0;
        //    for (int i = 1; i < text.Length; i++)
        //    {
        //        if (consonant.Contains(text[i - 1]) == consonant.Contains(text[i]))
        //        {
        //            count++;
        //        }
        //    }
        //    Console.WriteLine("Count: " + count.ToString());
        //}
        #endregion



        #endregion





    }





}
