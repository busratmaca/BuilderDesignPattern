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
            return $"{url.protocol}{url.hostname}{url.pathParam}?{url.queryParam}";
        }
    }
}

