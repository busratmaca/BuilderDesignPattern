using DesignPatterns.BuilderDesignPattern;

var urlBuilder = new URLBuilder("https://localhost");

urlBuilder
    .Append("api")
    .Append("v1")
    .Append("product")
    .QueryStringAppend("id", "5")
    .QueryStringAppend("name", "book");

var finalUrl = urlBuilder.BuildURL();

Console.WriteLine("URL: " + finalUrl);

