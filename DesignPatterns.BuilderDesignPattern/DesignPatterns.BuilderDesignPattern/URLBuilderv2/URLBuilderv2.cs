using System;
using System.Text;
using System.Xml.Linq;
using DesignPatterns.BuilderDesignPattern.URLBuilderv1;

namespace DesignPatterns.BuilderDesignPattern.URLBuilderv2
{
    //https://mywebsite/products?name=book
    /*
	 protocol  -> https://
	 hostname  -> mywebsite
	 path params -> products
	 query param -> name=book
	 */

    public class URLBuilderv2
    {
        private URL url { get; set; }

        private readonly StringBuilder queryParams = new();

        private const char delimeter = '/';

        public URLBuilderv2()
        {
          
            url = new URL();

        }

        public URLBuilderv2 Protocol(string protocol)
        {
            url.protocol = protocol;

            return this;
        }

        public URLBuilderv2 Hostname(string hostname)
        {
            url.hostname = hostname.EndsWith(delimeter) ? hostname : hostname.addDelimeter(delimeter);

            return this;
        }

        public URLBuilderv2 PathParam(string pathparam)
        {
            url.pathParam = pathparam.EndsWith(delimeter) ? pathparam : pathparam.addDelimeter(delimeter);

            return this;
        }

        public URLBuilderv2 QueryParam(string queryparamname, string queryparamvalue)
        {
            queryParams.AppendFormat("{0}={1}&", queryparamname, queryparamvalue);
            //url.queryParam = string.Format("{0}={1}&", queryparamname, queryparamvalue);

            return this;
        }

        public string BuildURL()
        {
            if (queryParams.Length > 0)
            {
                string queryParam = queryParams.ToString().TrimEnd('&');
                url.pathParam = url.pathParam.TrimEnd(delimeter).TrimEnd('?');
                url.queryParam = queryParam;
            }

            return url.Concat().ToString().TrimEnd(delimeter);
        }
    }

}

