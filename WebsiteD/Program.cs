using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteD
{
    class Program
    {
        static void Main(string[] args)
        {
            string urlPath = @"C:\websiteh2ReadingFromFile.txt";
            IRequest request = new FileRequest();

            //IRequest request = new WebsiteRequest();
            //string url = Console.ReadLine();


            RequestHandler handler = new RequestHandler(request);

            Console.WriteLine(handler.RequestedUrl(urlPath));

            Console.ReadKey();
        }
    }
}
