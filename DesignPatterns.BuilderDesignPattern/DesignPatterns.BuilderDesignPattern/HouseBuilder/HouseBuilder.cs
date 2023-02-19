using System;

namespace DesignPatterns.BuilderDesignPattern.HouseBuilder
{
	public class HouseBuilder
	{
		private House house;

		public HouseBuilder()
		{
            house = new House();
		}

		public House BuildHouse()
		{
			return this.house;
		}

        public HouseBuilder setBasement(string basement)
        {
            house.basement = basement;

            return this;
        }

        public HouseBuilder setInterior(string interior)
        {
            house.interior = interior;

            return this;
        }

        public HouseBuilder setRoof(string roof)
        {
            house.roof = roof;


            return this;
        }

        public HouseBuilder setStructure(string structure)
        {
            house.structure = structure;


            return this;
        }
    }
}

