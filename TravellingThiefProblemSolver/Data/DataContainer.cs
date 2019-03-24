using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravellingThiefProblemSolver.Model;

namespace TravellingThiefProblemSolver.Data
{
    public sealed class DataContainer
    {

        private static DataContainer _oInstance = null;
        public List<City> _Cities { get; set; }
        public List<Item> _Items { get; set; }
        public int Dimension { get; set; }
        public int NumberOfItems { get; set; }
        public int Capacity { get; set; }
        public double MinSpeed { get; set; }
        public double MaxSpeed { get; set; }
        public double RentingRatio { get; set; }

        public static DataContainer Instance
        {
            get
            {
                if (_oInstance == null)
                {
                    _oInstance = new DataContainer();
                }
                return _oInstance;
            }
        }

        public static void Clear()
        {
            if(_oInstance != null)
                _oInstance = new DataContainer();
        }

        private DataContainer()
        {
            _Cities = new List<City>();
            _Items = new List<Item>();
        }
        

    }
}
