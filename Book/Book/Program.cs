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
                if (count == 2)
                {
                    total += 180;
                }
                else if (count == 3)
                {
                    total += 240;
                }
                else if (count > 3)
                {
                    total += (count * 70);
                }
                else
                {
                    total += (count * 100);
                }  // end else if

            } // end for

            B.Cexit(total.ToString());
        } // end static

        public void Cexit(String msg)
        {
            Console.WriteLine(msg+"\nPress any key");
            Console.ReadKey();
            Environment.Exit(0);
        } // end public void

    } // end class

} //end namespace
