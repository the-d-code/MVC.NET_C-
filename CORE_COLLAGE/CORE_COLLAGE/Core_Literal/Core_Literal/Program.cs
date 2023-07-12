using System;

namespace Core_Literal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryLiterals();
            DigitSeprators();
            BooleanLiterals();
            IntegerLiterals();
            RealLiterals();
        }

        private static void BinaryLiterals()
        {
            Console.WriteLine(nameof(BinaryLiterals));
            byte b1 = 0b00001111;
            byte b2 = 0b10101010;
            ushort s1 = 0b1111000011110000;

            Console.WriteLine($"{b1:x}");
            Console.WriteLine(b1);
            Console.WriteLine($"{b2:x}");
            Console.WriteLine(b2);
            Console.WriteLine($"{s1:x}");
            Console.WriteLine(s1);
        }

        private static void DigitSeprators()
        {
            Console.WriteLine(nameof(DigitSeprators));
            ushort s1 = 0b1011_1100_1011_0011;
            ushort s2 = 0b1_111_000_111_000_111;
            int x1 = 0x44aa_abcd;
            Console.WriteLine($"{s1},{s2},{x1}");
        }

        private static void BooleanLiterals()
        {
            bool flag1 = true;
            bool flag2 = false;
            Console.WriteLine(flag1);
            Console.WriteLine(flag2);
            Console.WriteLine();
        }

        private static void IntegerLiterals()
        {
            Console.WriteLine(nameof(IntegerLiterals));
            int n1 = 1;
            int n2 = 0XA;
            int n3 = 3;
            int n4 = 4;
            int n5 = 5;
            int n6 = 6;
            int n7 = 7;
            int n8 = 8;
            int n9 = 9;
            int n10 = 10;
            Console.WriteLine($"{n1}{n2}{n3}{n4}{n5}{n6}{n7}{n8}{n9}{n10}");

        }

        private static void RealLiterals()
        {
            Console.WriteLine(nameof(RealLiterals));
            float f1 = 1.1F;
            double d1 = 3.4;
            double d2 = 5.66;
            Console.WriteLine($"{f1},{d1},{d2}");
        }
    }
}
