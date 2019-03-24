﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingThiefProblemSolver
{
    public static class Env
    {
        public const string FILE_NAME = "medium_0.ttp";
        public const double MUT_RATE = 0.2;
        public const double CROSS_RATE = 0.70;
        public const int POP_SIZE = 100;
        public const int GENERATION_COUNT = 1000;
        //sort type: 1 - greedy on profit, 2-greedy on ratio
        public const int SORT_TYPE = 1;

        public const int TOURNAMENT_SIZE = 20;
        //public const int ELITISM = 6;
        //public const int NUM_CITIES = 40;
    }
}