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
            IRequest request = new WebsiteRequest();
            WebsiteRequestHandler handler = new WebsiteRequestHandler(request);
            string url = Console.ReadLine();

            Console.WriteLine(handler.RequestedUrl(url));

            Console.ReadKey();
        }
    }
}
