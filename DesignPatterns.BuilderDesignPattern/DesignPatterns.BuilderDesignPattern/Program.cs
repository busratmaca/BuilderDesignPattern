using DesignPatterns.BuilderDesignPattern.URLBuilderv1;
using DesignPatterns.BuilderDesignPattern.URLBuilderv2;

var urlBuilder = new URLBuilder("https://localhost");

urlBuilder
    .Append("api")
    .Append("v1")
    .Append("product")
    .QueryStringAppend("id", "5")
    .QueryStringAppend("name", "book");

var finalUrl = urlBuilder.BuildURL();

Console.WriteLine("Final URL: " + finalUrl);

/* v2 part*/

var urlBuilderv2 = new URLBuilderv2();

urlBuilderv2
    .Protocol("https://")
    .Hostname("mywebsite")
    .PathParam("products")
    .QueryParam("id", "5")
    .QueryParam("name", "lolipop");

var finalURLv2 = urlBuilderv2.BuildURL();

Console.WriteLine("Final URL v2: " + finalURLv2);

