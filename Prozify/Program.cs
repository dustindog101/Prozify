using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Prozify
{
    class Program
    {

        /*
        ██████╗.██████╗..██████╗.███████╗██╗███████╗██╗...██╗
        ██╔══██╗██╔══██╗██╔═══██╗╚══███╔╝██║██╔════╝╚██╗.██╔╝
        ██████╔╝██████╔╝██║...██║..███╔╝.██║█████╗...╚████╔╝.
        ██╔═══╝.██╔══██╗██║...██║.███╔╝..██║██╔══╝....╚██╔╝..
        ██║.....██║..██║╚██████╔╝███████╗██║██║........██║...
        ╚═╝.....╚═╝..╚═╝.╚═════╝.╚══════╝╚═╝╚═╝........╚═╝...
        .....................................................
        */
        // A simple program that downloads proxies from https://proxyscrape.com and saves to file using a unique ID to make sure file can always be present
        //created by hrc retro!
        public static string titleSpacing = "                               ";
               public static void Main(string[] args)
                {
            Console.Title = "Prozify   -   Made by ReTrO#1435";
            
            title(ConsoleColor.Magenta);
            Credits();
            core();
            Console.ReadKey();
                }
        public static void core()
        {

            // A simple program that downloads proxies from https://proxyscrape.com and saves to file using a unique ID to make sure file can always be present
            //created by hrc retro!
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" What type of proxies do you want \n 1). Https \n 2). Socks4 \n 3). Socks5");
            string inp = Console.ReadLine();
            switch (inp)
            {
                case "1":
                    Console.WriteLine(https());
                    
                    Console.WriteLine(writetofile(https(), "https Proxies ", false)); 
                    break;
                case "2":
                    Console.WriteLine(socks4());
                    Console.WriteLine(writetofile(socks4(), "Socks5 Proxies ", false));
                    //socks4();
                    break;
                case "3":
                    Console.WriteLine(socks5());
                    Console.WriteLine(writetofile(socks5(), "Socks5 Proxies ", false));
                    //socks5();
                    break;
                default:
                    Console.WriteLine("Unable to read input());");
                    break;
            }
        }
        public static string writetofile(object inp, string FileLocation, bool raw)
        {
            // A simple program that downloads proxies from https://proxyscrape.com and saves to file using a unique ID to make sure file can always be present
            //created by hrc retro!
            Random rnd = new Random();
            string filename = FileLocation + " " + rnd.Next(1000, 99999) + DateTime.Now.ToString("ss") + " " + DateTime.Now.ToString("hh;mm") + ".txt";
            
            StreamWriter Writer = new StreamWriter(filename);
            Writer.WriteLine(inp);
            if (raw == true)
            {

            }
            else
            {
                Writer.WriteLine("\n Prozy");
            }
            Writer.Flush();
            Writer.Close();
            GC.Collect();
            Console.ForegroundColor = ConsoleColor.Green;
            return "Written to file! " + filename;
        }
        #region Proxy download

        
        public static string https()
        {
            // A simple program that downloads proxies from https://proxyscrape.com and saves to file using a unique ID to make sure file can always be present
            //created by hrc retro!
            // https://api.proxyscrape.com/?request=displayproxies&proxytype=http&timeout=10000&country=all&ssl=all&anonymity=all

            WebClient wc = new WebClient();
           string abc = wc.DownloadString("https://api.proxyscrape.com/?request=displayproxies&proxytype=http&timeout=10000&country=all&ssl=all&anonymity=all");
            return "    https proxies " + DateTime.Now.ToString("hhhh:mmmm") +"\n" +abc;
        }
        public static string socks4()
        {
            // https://api.proxyscrape.com/?request=displayproxies&proxytype=socks4&timeout=10000&country=all

            WebClient wc = new WebClient();
            string abc = wc.DownloadString("https://api.proxyscrape.com/?request=displayproxies&proxytype=socks4&timeout=10000&country=all");
            
            return "    Socks4 proxies " + DateTime.Now.ToString("hhhh:mmmm") + "\n" + abc;

        }
        public static string socks5()
        {
            // https://api.proxyscrape.com/?request=displayproxies&proxytype=socks5&timeout=10000&country=all

            WebClient wc = new WebClient();
            string abc = wc.DownloadString("https://api.proxyscrape.com/?request=displayproxies&proxytype=socks5&timeout=10000&country=all");
            return "    Socks5 proxies " + DateTime.Now.ToString("hhhh:mmmm") + "\n" + abc;
        }
        #endregion
        public static void Credits()
        {
            // A simple program that downloads proxies from https://proxyscrape.com and saves to file using a unique ID to make sure file can always be present
            //created by hrc retro!
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(titleSpacing +"                       CREDITS\n");
            
            Console.WriteLine(titleSpacing +"Retro#1435:          Creator\n");
            Console.WriteLine(titleSpacing +"Proxyscra.pe:        For providing all these proxies!!\n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
        public static void title(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("                               ██████╗.██████╗..██████╗.███████╗██╗███████╗██╗...██╗");
            Console.WriteLine("                               ██╔══██╗██╔══██╗██╔═══██╗╚══███╔╝██║██╔════╝╚██╗.██╔╝");
            Console.WriteLine("                               ██████╔╝██████╔╝██║...██║..███╔╝.██║█████╗...╚████╔╝");
            Console.WriteLine("                               ██╔═══╝.██╔══██╗██║...██║.███╔╝..██║██╔══╝....╚██╔╝..");
            Console.WriteLine("                               ██║.....██║..██║╚██████╔╝███████╗██║██║........██║...");
            Console.WriteLine("                               ╚═╝.....╚═╝..╚═╝.╚═════╝.╚══════╝╚═╝╚═╝........╚═╝...");
            Console.WriteLine("                               .....................................................");
        }
            }
        }
