using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteD
{
    static class WebsiteLinkChecker
    {
        public static bool CorrectUrl(string url)
        {
            if (url.Contains("https") || url.Contains("http"))
                return true;

            return false;
        }
    }
}
