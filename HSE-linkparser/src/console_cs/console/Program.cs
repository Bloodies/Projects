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

                string numb = "https://lms.hse.ru/view_file.php?file=" + intnum + "&action=download";                
                Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", numb);

                Console.WriteLine("ok " + intnum);
                intnum--;
                //Console.WriteLine("все? ");
                //string stop = Console.ReadLine();
                //if (stop == "stop") { Environment.Exit(0); }
                //else { Console.WriteLine("next "); Thread.Sleep(900); Ctrl + W} 

                //2648685-- 2575895++
                //2648000   2632140

                Thread.Sleep(1200);
            } while (true);
        }
    }
}