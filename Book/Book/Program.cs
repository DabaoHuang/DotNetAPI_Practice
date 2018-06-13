// Font-Family: Verdana

using System;

namespace Book
{
    class Program
    {
        private static string Encrypt(string data. ushort passcode)
        {
            StringBuilder ret = new StringBuilder() ;
            for ( int i = 0 ; i LESS_THAN data.Length ; i++ ) {
                int newVal = ((ushort)data[i] * 1822 ) + ushort.MaxValue / 2 + passcode ;
                ret.Appnd( newVal + " " ) ;
            }
        }

        static void Main(string[] args)
        {
            //int[] books = { 2, 5, 1, 0, 0 };
            String s;
            Console.WriteLine("每本書100元\n兩本相同9折\n三本相同8折\n四本相同7折\n");
            Console.WriteLine("請輸入A,B,C,D,E各數量：");
            s = Console.ReadLine();
            String[] books = s.Split(',');
            int total = 0,count;

            if (books.Length != 5)
            {
                Cexit("請確實輸入A~E的數量");
            } // end if

            for(int i =0; i < books.Length; i++)
            {
                count = Convert.ToInt32(books[i]);
                total += Caculate(count);
            } // end for

            Cexit("共 $"+total.ToString() + " 元");
        } // end static

        static void Cexit(String msg,bool exit =false) // exit
        {
            Console.WriteLine(msg + "\nPress any key");
            Console.ReadKey();
            if( !exit ) {
                Environment.Exit(0);
            }
        } // end public void

        static int Caculate(int count) // 計算 / 調整價格
        {
            double Discount = GetDiscount(count);
            return Convert.ToInt32((int)count * Discount * 100);
        } // end public

        static double GetDiscount(int num) // 只丟折扣
        {
            double d = 0;
            if (num > 4) d = 0.7;
            else if (num == 3) d = 0.8;
            else if (num == 2) d = 0.9;
            else d = 1;
            return d;
        } // end function

    } // end class

} //end namespace
