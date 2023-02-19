
using DesignPatterns.BuilderDesignPattern.HouseBuilder;
using DesignPatterns.BuilderDesignPattern.HouseBuilderv2;
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


/*HOUSE BUILDER*/

var houseBuilder = new HouseBuilder();
var house = houseBuilder
    .setBasement("basement")
    .setStructure("structure")
    .setRoof("roof")
    .setInterior("interior");
var mynewhouse = house.BuildHouse();

System.Console.Out.WriteLine("Builder constructed: " + mynewhouse.basement);

/*HOUSE BUILDER V2*/

IHousebuilder housebuilder = new CottageHouse();
housebuilder
    .setInterior("interior")
    .setBasement("basement")
    .setInterior("interior")
    .setRoof("roof");


var newhouse = housebuilder.BuildHouse();

System.Console.Out.WriteLine("Builder constructed: " + newhouse.basement + newhouse.roof);
