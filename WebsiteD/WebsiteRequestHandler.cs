using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteD
{
    class WebsiteRequestHandler
    {
        string url = string.Empty;
        IRequest request;

        public WebsiteRequestHandler(IRequest request)
        {
            this.request = request;
        }

        public string RequestedUrl(string url)
        {
            this.url = url;

            if (!WebsiteLinkChecker.CorrectUrl(url))
                return "Incorrect Link";

            return RetrunResponse();
        }

        string RetrunResponse()
        {
            return request.Request(url);
        }
    }
}
