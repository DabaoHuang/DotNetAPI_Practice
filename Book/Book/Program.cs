// Font-Family: Verdana

using System;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Program B = new Program();
            //int[] books = { 2, 5, 1, 0, 0 };
            String s;
            Console.WriteLine("每本書100元\n兩本相同9折\n三本相同8折\n四本相同7折\n");
            Console.WriteLine("請輸入A,B,C,D,E各數量：");
            s = Console.ReadLine();
            String[] books = s.Split(',');
            int total = 0,count;

            if (books.Length != 5)
            {
                B.Cexit("請確實輸入A~E的數量");
            } // end if

            for(int i =0; i < books.Length; i++)
            {
                count = Convert.ToInt32(books[i]);
                total += B.Caculate(count);
            } // end for

            B.Cexit("共 $"+total.ToString() + " 元");
        } // end static

        public void Cexit(String msg) // exit
        {
            Console.WriteLine(msg+"\nPress any key");
            Console.ReadKey();
            Environment.Exit(0);
        } // end public void

        public int Caculate(int count) // 計算 / 調整價格
        {
            Program B = new Program();
            double Discount = B.GetDiscount(count);
            return Convert.ToInt32((int)count * Discount * 100);
        } // end public

        public double GetDiscount(int num) // 只丟折扣
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
