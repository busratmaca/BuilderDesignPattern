using System;
namespace DesignPatterns.BuilderDesignPattern.URLBuilderv2
{
	public class URL
	{
        public string protocol { get; set; }
        public string hostname { get; set; }
        public string pathParam { get; set; }
        public string queryParam { get; set; }

        public override string ToString()
        {
            return $"{protocol}{hostname}{pathParam}{queryParam}";
        }
    }
}

