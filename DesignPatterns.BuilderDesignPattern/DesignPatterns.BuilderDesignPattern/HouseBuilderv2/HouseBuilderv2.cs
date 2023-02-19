using System;
using DesignPatterns.BuilderDesignPattern.HouseBuilder;

namespace DesignPatterns.BuilderDesignPattern.HouseBuilderv2
{
    public interface IHousebuilder
    {
        Housev2 BuildHouse();
        IHousebuilder setBasement(string basement);

        IHousebuilder setInterior(string interior);

        IHousebuilder setRoof(string roof);

        IHousebuilder setStructure(string structure);

    }
    public abstract class HouseBuilderv2 : IHousebuilder
    {
        protected Housev2 housev2;

        public HouseBuilderv2()
        {
            housev2 = new Housev2();
        }

        public Housev2 BuildHouse()
        {
            return this.housev2;
        }

        public abstract IHousebuilder setBasement(string basement);

        public abstract IHousebuilder setInterior(string interior);

        public abstract IHousebuilder setRoof(string roof);

        public abstract IHousebuilder setStructure(string structure);

    }
}

