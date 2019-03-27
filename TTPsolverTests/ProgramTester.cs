using NUnit.Framework;
using System;
using System.Collections.Generic;
using TravellingThiefProblemSolver;
using TravellingThiefProblemSolver.Data;
using TravellingThiefProblemSolver.Loaders;
using TravellingThiefProblemSolver.Model;
using TravellingThiefProblemSolver.TravellingSalesmanProblem;

namespace TTPsolverTests
{
    [TestFixture]
    public class ProgramTester
    {

        [Test]
        public void FitFunctionTest()
        {
            DataContainer container = DataContainer.Instance;
            container.Capacity = 6;
            container.Dimension = 4;
            container.MaxSpeed = 1.5;
            container.MinSpeed = 0.6;

            City cityA = new City(1, 1, 1);
            City cityB = new City(2, 4, 5);
            City cityC = new City(3, 8, 2);
            City cityD = new City(4, 2, -6);

            cityB.ItemsInCity.Add(new Item(1, 8, 3, 2));
            cityC.ItemsInCity.Add(new Item(2, 6, 5, 3));
            cityD.ItemsInCity.Add(new Item(3, 3, 1, 4));

            List<City> cities = new List<City>(){ cityA, cityB, cityC, cityD };
            DataContainer dc = DataContainer.Instance;
            dc._Cities = cities;

            SubjectTraveller st = new SubjectTraveller(4, 0.4, cityA);
            st.FirstCity = cityA;
            st.TripPlan = new City[] { cityB, cityC, cityD };


            TTP tsp = new TTP();
            double result = tsp.FittnesFunction(st);
            Console.WriteLine("Result is {0}", result);

            Assert.IsTrue(true);

        }

        [Test]
        public void SwapTest()
        {
            City cityA = new City(1, 1, 1);
            City cityB = new City(2, 4, 5);
            City cityC = new City(3, 8, 2);
            City cityD = new City(4, 2, -6);

            cityB.ItemsInCity.Add(new Item(1, 8, 3, 2));
            cityC.ItemsInCity.Add(new Item(2, 6, 5, 3));
            cityD.ItemsInCity.Add(new Item(3, 3, 1, 4));

            SubjectTraveller st = new SubjectTraveller(4, 0.4, cityA);
            st.FirstCity = cityA;
            st.TripPlan = new City[] { cityB, cityC, cityD };

            foreach (City c in st.TripPlan)
            {
                Console.WriteLine(c.ToString());
            }
            //st.SwapInTripPlan(0, 2);
            st.SwapInMemory(0, 2);
            Console.WriteLine("AFTER REVERSE:");
            foreach (City c in st.TripPlan)
            {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine("Cities");
            Console.WriteLine("City A: {0}", cityA.ToString());
            Console.WriteLine("City B: {0}", cityB.ToString());
            Console.WriteLine("City C: {0}", cityC.ToString());
            Console.WriteLine("City D: {0}", cityD.ToString());
            

            Assert.IsTrue(true);

        }

        [Test]
        public void GATest()
        {
            var _fileLoader = new FileLoader(Env.FILE_NAME);
            var dataParser = new DataParser();
            dataParser.ParseDataFromFileStream(_fileLoader.GetFileStream());

            Assert.IsTrue(true);
        }


        [TestCase("medium_1.ttp")]
        public void SolveTTPbyGoToNearestCityTest(String fileName)
        {
            //fileName = Env.FILE_NAME;
            var _fileLoader = new FileLoader(fileName);
            var dataParser = new DataParser();
            dataParser.ParseDataFromFileStream(_fileLoader.GetFileStream());
            TTP_spec ttpSolver = new TTP_spec();
            ttpSolver.SolveTTPbyGoToNarestCity(Env.SORT_TYPE);


            Assert.IsTrue(true);
        }


        
    }
}
