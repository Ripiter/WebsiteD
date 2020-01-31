using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WebsiteD
{
    class FileRequest : IRequest
    {
        public string Request(string url)
        {
            string text = File.ReadAllText(url);

            return text;
        }
    }
}
