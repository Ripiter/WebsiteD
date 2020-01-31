using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteD
{
    class RequestHandler
    {
        string url = string.Empty;
        IRequest request;

        public RequestHandler(IRequest request)
        {
            this.request = request;
        }

        public string RequestedUrl(string url)
        {
            this.url = url;

            return RetrunResponse();
        }

        string RetrunResponse()
        {
            return request.Request(url);
        }
    }
}
