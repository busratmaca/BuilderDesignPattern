using System;
using System.Text;

namespace DesignPatterns.BuilderDesignPattern
{
    public class URLBuilder
    {
        private readonly StringBuilder urlBuilder = new();
        private readonly StringBuilder queryStringParams = new();

        const char delimeter = '/';

        public string BaseURL { get; set; }

        public URLBuilder(string baseUrl)
        {
            BaseURL = baseUrl;
        }

        public URLBuilder Append(string value)
        {
            //localhost/api/v1/product
            urlBuilder.Append(value);
            urlBuilder.Append(delimeter);
            return this;

        }

        public URLBuilder QueryStringAppend(string name, string value)
        {
            //localhost/api/v1/product?id=5&name=test
            queryStringParams.AppendFormat("{0}={1}&", name, value);
            return this;

        }

        public string BuildURL()
        {
            if (BaseURL.EndsWith(delimeter))
                urlBuilder.Insert(0, BaseURL);
            else
                urlBuilder.Insert(0, BaseURL + delimeter);

            //localhost/api/v1/product
            var url = urlBuilder.ToString().TrimEnd('&');

            if (queryStringParams.Length > 0)
            {
                string qsParams = queryStringParams.ToString().TrimEnd('&');
                url = urlBuilder.ToString().TrimEnd(delimeter).TrimEnd('?');

                url = $"{url}?{qsParams}";

            }
        
            return url.TrimEnd(delimeter);
        }
    }
}

