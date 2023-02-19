using System;
namespace DesignPatterns.BuilderDesignPattern.URLBuilderv2
{
    public static class Extension
    {
        public static string addDelimeter(this string str, char delimeter)
        {

            return $"{str}{delimeter}";
        }

        public static string Concat(this URL url)
        {
            if (url.queryParam is null)
                return $"{url.protocol}{url.hostname}{url.pathParam}";
            else
                return $"{url.protocol}{url.hostname}{url.pathParam}?{url.queryParam}";
        }
    }
}

