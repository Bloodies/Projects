using System;
using System.Diagnostics;
using System.Threading;

namespace console
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("число ");
            string num = Console.ReadLine();
            int intnum = Convert.ToInt32(num);
            Console.WriteLine("inputted");
            do
            {
                //Console.WriteLine("https://lms.hse.ru/view_file.php?file=" + intnum + "&action=download");
                //Console.WriteLine(numb);

                string numb = "https://lms.hse.ru/ap_list_works_file.php?a_id=" + intnum;
                Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", numb);

                Console.WriteLine("ok " + intnum);
                intnum--;

                //160655    21.03 15:00
                //160875 ++
                //160581 --
                Thread.Sleep(800);
            } while (true);
        }
        //static void Main()
        //{
        //    Console.WriteLine("число ");
        //    string num = Console.ReadLine();
        //    int intnum = Convert.ToInt32(num);
        //    Console.WriteLine("inputted");
        //    do
        //    {
        //        //Console.WriteLine("https://lms.hse.ru/view_file.php?file=" + intnum + "&action=download");
        //        //Console.WriteLine(numb);

        //        string numb = "https://lms.hse.ru/view_file.php?file=" + intnum + "&action=download";
        //        Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", numb);

        //        Console.WriteLine("ok " + intnum);
        //        intnum--;
        //        //Console.WriteLine("все? ");
        //        //string stop = Console.ReadLine();
        //        //if (stop == "stop") { Environment.Exit(0); }
        //        //else { Console.WriteLine("next "); Thread.Sleep(900); Ctrl + W} 

        //        //2807702    21.02 15:00
        //        //2808700 ++
        //        //2800000 --

        //        //2846913    18.03 14:00
        //        //2846913 ++
        //        //2844000 --

        //        //2851559    21.03 15:00
        //        //2807702 ++
        //        //2846361 --
        //        Thread.Sleep(800);
        //    } while (true);
        //}
    }
}