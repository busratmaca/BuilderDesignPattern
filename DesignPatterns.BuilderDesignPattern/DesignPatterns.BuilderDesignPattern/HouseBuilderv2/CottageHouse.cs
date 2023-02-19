using System;
using DesignPatterns.BuilderDesignPattern.HouseBuilder;

namespace DesignPatterns.BuilderDesignPattern.HouseBuilderv2
{
    public class CottageHouse : HouseBuilderv2
    {
        public CottageHouse()
        {
        }

        public override IHousebuilder setBasement(string basement)
        {
            this.housev2.basement = basement;
            return this;
        }
        
        public override IHousebuilder setInterior(string interior)
        {
            housev2.interior = interior;

            return this;
        }

        public override IHousebuilder setRoof(string roof)
        {
            housev2.roof = roof;
            return this;
        }

        public override IHousebuilder setStructure(string structure)
        {
            housev2.structure = structure;
            return this;
        }
    }
}

