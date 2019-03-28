using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingThiefProblemSolver
{
    public static class Env
    {
        public const string FILE_NAME = "medium_1.ttp";
        public const double MUT_RATE = 0.06;
        public const double CROSS_RATE = 1.0;
        public const int POP_SIZE = 500;
        public const int GENERATION_COUNT = 1000;
        //sort type: 1 - greedy on profit, 2-greedy on ratio
        public const int SORT_TYPE = 1;
        //1  by best profit asc
        //2  total random sort
        //3  by weight dsc (last is the lighest)
        //default example 0 is sort by ratio asc

        public const int TOURNAMENT_SIZE = 10;
        
        

        //public const int ELITISM = 6;
        //public const int NUM_CITIES = 40;
    }
}
