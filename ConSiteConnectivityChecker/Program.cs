using System;
using System.Configuration;
using System.Timers;
using System.IO;
using siteconnectivitychecker;
using siteconnectivitychecker.urlsproviders;

namespace ConSiteConnectivityChecker
{
    class Program
    {

        static string filepath = "./urls.txt";
        static double intervals_ms = 5000;
        static Timer timer = null;
        static Iurlprovider urlprovider = null;
        static string[] urls = null;

        public static int Main(string[] args)
        {
            setup();

            while (true)
            {
                char command = Console.ReadKey().KeyChar;
                switch (command)
                {
                    case 'q':
                        {
                            timer.Stop();
                            Console.WriteLine("\n quit .....");
                            return 0;
                        }
                    case 's':
                        {
                            Console.WriteLine("\n start the application :");
                            timer.Start();
                            break;
                        }
                    case 'a':
                        {
                            timer.Stop();

                            Console.Write("\n add url entry: ");

                            string url = Console.ReadLine();

                            if (urlprovider.addurl(url))
                            {
                                Console.WriteLine("\n new url entry was addes");
                            }
                            else
                            {
                                Console.WriteLine("\n failed to add the url entry");
                            }

                            urls = urlprovider.geturls();
                            timer.Start();
                            break;
                        }
                    case 'c':
                        {
                            timer.Stop();
                            Console.WriteLine("\n enter the specified timer intervals: ");
                            double interval = Convert.ToDouble(Console.ReadLine());
                            timer.Interval = interval;
                            timer.Start();
                            break;
                        }
                    case 'r':
                        {
                            timer.Stop();
                            Console.Write("\n select url to remove: ");
                            string url = Console.ReadLine();

                            if (urlprovider.removeurl(url))
                            {
                                Console.WriteLine("url removed successufully");
                            }
                            else
                            {
                                Console.WriteLine("fail to remove the url");
                            }
                            urls = urlprovider.geturls();
                            timer.Start();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("invalid command");
                            break;
                        }
                }
            }
        }

        private static void setup()
        {
            //urlprovider = new fileurlprovider(filepath);
            string cs = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            urlprovider = new sqliteurlprovider(cs);

            createsamplesdata();

            timer = new Timer(intervals_ms);

            urls = urlprovider.geturls();

            timer.Elapsed += Timer_Elapsed;

        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {

            foreach (var url in urls)
            {
                if (ConnectionChecker.ConnectionCheck(url))
                {
                    Console.WriteLine(string.Format("the site {0} is up ", url));
                }
                else
                {
                    Console.WriteLine(string.Format("the site {0} is down ", url));
                }
            }
            Console.WriteLine("*******************************");
        }

        private static void createsamplesdata()
        {
            string[] sites = new string[] { "youtube.com", "facebook.com", "stackoverflow.com", "google.com", "medium.com" };
            foreach (string url in sites)
            {
                urlprovider.addurl(url);
            }
        }

    }
}
