using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravellingThiefProblemSolver.Data;
using TravellingThiefProblemSolver.Model;
using TravellingThiefProblemSolver.Utilities;

namespace TravellingThiefProblemSolver.TravellingSalesmanProblem
{
    public class TTP
    {
        private DataContainer _container;
        private Random _rnd;
        //private SubjectTraveller[] _population;
        private double[,] _distanceMatrix;
        public double _bestTravelTime { get; set; }
        public Dictionary<int, double> _generationFittnesMap { get; }

        public TTP()
        {
            _rnd = new Random();
            _container = DataContainer.Instance;
            _distanceMatrix = new double[_container.Dimension, _container.Dimension];
            FillDistanceMatrix(_container._Cities);
            //MaxValue jeśli F function
            _bestTravelTime = double.MinValue;
            _generationFittnesMap = new Dictionary<int, double>();

        }

        public void StartTTP(int sizeOfPopulation, int coutOfGenerations, int itemChooseMethod, double mutProp)
        {
            //sort items in Cities 1- sortByBestRatio(value/weight)
            foreach(City c in _container._Cities)
            {
                c.SortItemsBy(itemChooseMethod);
            }

            //INIT POPULATION
            SubjectTraveller[] _population;
            _population = new SubjectTraveller[sizeOfPopulation];
            //SubjectTraveller[] population = new SubjectTraveller[sizeOfPopulation];
            InitPopulation(_population, mutProp);
            
            //CHECK POPULATION 
            foreach (SubjectTraveller subTrav in _population)
            {
                //FixSubjectTraveller(subTrav); //no need to fix
                
                subTrav.TravelTime = FittnesFunction(subTrav);
                //jeśli FittnesFunctionF to musi być odwrotnie znak nierówności

                if ( subTrav.TravelTime > _bestTravelTime)
                {
                    _bestTravelTime = subTrav.TravelTime;
                }

                //Console.WriteLine(subTrav); //print to check
            }
            _generationFittnesMap.Add(0, _bestTravelTime);

            //Console.WriteLine(_bestTravelTime);

            for (int i=0; i < Env.GENERATION_COUNT; i++)
            {
                double bestFittnesInGeneration = Double.MinValue;
                //SELECT CANDIDATS TO CROSSING
                //CROSS
                //MUTATE
                _population = SelectCrossMutate(_population);

                //CHECK NEW POPULATION
                foreach (SubjectTraveller subTrav in _population)
                {
                    subTrav.TravelTime = FittnesFunction(subTrav);
                    if (subTrav.TravelTime > bestFittnesInGeneration)
                    {
                       bestFittnesInGeneration = subTrav.TravelTime;
                    }
                    if (subTrav.TravelTime > _bestTravelTime)
                    {
                        _bestTravelTime = subTrav.TravelTime;
                    }
                    
                }
                _generationFittnesMap.Add( i+1, bestFittnesInGeneration);
            }

            foreach(KeyValuePair<int, double> value in _generationFittnesMap)
            {
                Console.WriteLine($"Generation number: {value.Key}\nFittnesValue: {value.Value}");
            }

            Console.WriteLine($"The Best is: {_bestTravelTime}");
            
        }

        //Generates random population(subset of chromosoms/solutions ) 
        public void InitPopulation(SubjectTraveller[] pop, double mutProp)
        {
            for(int j = 0; j < pop.Length; j++)
            {
                List<int> citiesIndexesLeft = new List<int>();
                //becouse count of cities - first city
                pop[j] = new SubjectTraveller(_container.Dimension - 1, mutProp, _container._Cities[0]);
                //{
                //    FirstCity = 
                //};
                foreach(City c in _container._Cities)
                {
                    citiesIndexesLeft.Add(c.CityId);
                }
                //usuwamy 0 bo już jest dodane w FirstCity
                citiesIndexesLeft.RemoveAt(0);

                if (pop[j].TripPlan.Length != citiesIndexesLeft.Count)
                    throw new Exception("Length of trip is not the same as Count of cities");

                for(int i=0; i<pop[j].TripPlan.Length; i++)
                {
                    //int cityNumber = _rnd.Next(citiesIndexesLeft.Count);
                    int rndNumOfCityFromCitiesIndexesLeft = ThreadSafeRandom.ThisThreadsRandom.Next(citiesIndexesLeft.Count);
                    pop[j].TripPlan[i] = _container._Cities[citiesIndexesLeft[rndNumOfCityFromCitiesIndexesLeft]-1];
                    citiesIndexesLeft.Remove(rndNumOfCityFromCitiesIndexesLeft);
                }
                
            }
        }

        public void FixSubjectTraveller(SubjectTraveller st)
        {
            List<City> chosen = new List<City>();
            List<City> left = new List<City>();

            foreach (City c in _container._Cities)
            {
                if( st.TripPlan.Contains(c) )
                {
                    left.Remove(c);
                }
                else
                {
                    left.Add(c);
                }
            }

            
            for(int i=0; i < st.TripPlan.Length; i++)
            {
                for(int j=i+1; j < st.TripPlan.Length; i++)
                {
                    if (st.TripPlan[i].Equals(st.TripPlan[j]))
                    {
                        st.TripPlan[j] = left[left.Count];
                        left.Remove(left[left.Count]);
                    }
                }
            }

        }

        public SubjectTraveller[] SelectCrossMutate(SubjectTraveller[] population)
        {
            //SortPopulationByTravelTimeAsc();  //NIE MA TO SENSU - W TURNIEJU TO I TAK WYBIERANY JEST NAJLEPSZY POSROD KILKU 
            List<SubjectTraveller> newGeneration = new List<SubjectTraveller>(Env.POP_SIZE);
            //int actualPopSize = 0;

            while ( newGeneration.Count <= Env.POP_SIZE)
            {
                double rndNum = ThreadSafeRandom.ThisThreadsRandom.NextDouble();
                SubjectTraveller child;
                SubjectTraveller mother = TournamentSelection(Env.CROSS_RATE, Env.TOURNAMENT_SIZE, population);
                
                if ( rndNum <= Env.CROSS_RATE)
                {
                    SubjectTraveller father = TournamentSelection(Env.CROSS_RATE, Env.TOURNAMENT_SIZE,population);
                    child = CrossOverInKindOfUniform(mother, father);
                }
                else
                {
                    child = new SubjectTraveller(mother);
                }
                child.Mutate();
                if ( !newGeneration.Contains(child))
                    newGeneration.Add(child);
                //actualPopSize++;
            }

            //_population = newGeneration.ToArray();
            return newGeneration.ToArray();

        }

        private SubjectTraveller[] SortPopulationByTravelTimeAsc(SubjectTraveller[] population)
        {
            return population.ToList().OrderBy(o => o.TravelTime).ToArray();
        }

        //selekcja turniejowa, wybieramy z całej populacji n osobników i robimy turniej, i wybieramy najlpszego, sprawdzamy czy się ma krzyrzować czy nie i jeśli tak to krzyżujemy z elementem z kolejnego turnieju 
        private SubjectTraveller TournamentSelection(double crossPropabilty ,int tournamentSize, SubjectTraveller[] population)
        {
            List<SubjectTraveller> citiesSelectedToTournament = new List<SubjectTraveller>(tournamentSize);
            while( citiesSelectedToTournament.Count <= tournamentSize)
            {
                int numberOfSubjectToTournament = ThreadSafeRandom.ThisThreadsRandom.Next(Env.POP_SIZE);
                if ( !citiesSelectedToTournament.ToArray().Contains(population[numberOfSubjectToTournament]))
                {
                    citiesSelectedToTournament.Add(population[numberOfSubjectToTournament]);
                }
                
            }
           
            return new SubjectTraveller(citiesSelectedToTournament.ToList().OrderByDescending(x => x.TravelTime).First());

        }

        public SubjectTraveller CrossOverInKindOfUniform(SubjectTraveller mother, SubjectTraveller father)
        {
            //HashSet<SubjectTraveller> children = new HashSet<SubjectTraveller>();
            SubjectTraveller child = new SubjectTraveller(mother.TripPlan.Length, mother.MutationPropability, mother.FirstCity);

            //double crossingImportanceMother = mother.TravelTime;
            //double crossingImportanceFather = father.TravelTime;
            double crossingImportanceMother;
            //double crossingImportanceFather;
            if ( mother.TravelTime >= father.TravelTime)
            {
                crossingImportanceMother = 0.8;
                //crossingImportanceFather = 0.3;
            }
            else
            {
                crossingImportanceMother = 0.2;
                //crossingImportanceFather = 0.7;
            }

            double randomNumber = ThreadSafeRandom.ThisThreadsRandom.NextDouble();
            for (int i = 0; i < mother.TripPlan.Length; i++)
            {
                if ( randomNumber < crossingImportanceMother)
                {
                    if (!child.TripPlan.Contains(mother.TripPlan[i]))
                    {
                        child.TripPlan[i] = mother.TripPlan[i];
                    }
                    else
                    {
                        child.TripPlan[i] = father.TripPlan[i];
                    }
                    
                }
                else
                {
                    if (!child.TripPlan.Contains(father.TripPlan[i]))
                    {
                        child.TripPlan[i] = father.TripPlan[i];
                    }
                    else
                    {
                        child.TripPlan[i] = mother.TripPlan[i];
                    }
                }
            }

            return child;

        }

        public SubjectTraveller CrossOverOX1(SubjectTraveller mother, SubjectTraveller father)
        {
            int halfOfTripLength = mother.TripPlan.Length / 2;
            int firstPoint = ThreadSafeRandom.ThisThreadsRandom.Next(halfOfTripLength-(Convert.ToInt32(halfOfTripLength*0.2))) + Convert.ToInt32(halfOfTripLength * 0.1);
            int secondPoint = ThreadSafeRandom.ThisThreadsRandom.Next(halfOfTripLength-(Convert.ToInt32(halfOfTripLength*0.2))) + Convert.ToInt32(halfOfTripLength * 0.1) + halfOfTripLength;

            SubjectTraveller firstChild = new SubjectTraveller(mother.TripPlan.Length, mother.MutationPropability, mother.FirstCity);
            //SubjectTraveller secondChild = new SubjectTraveller(mother.TripPlan.Length, mother.MutationPropability, mother.FirstCity);

            for( int i = firstPoint; i <= secondPoint; i++)
            {
                firstChild.TripPlan[i] = mother.TripPlan[i];
            }
            
            //jeszcze reszta 

            //for (int i = firstPoint; i <= secondPoint; i++)
            //{
            //    secondChild.TripPlan[i] = father.TripPlan[i];
            //}
            //jeszcze reszta

            return firstChild;
            //return new SubjectTraveller[2] { firstChild, secondChild };
        }

        

        //small value is good, high is bad (it is a function of time and time need to be as small as it is possible)
        public double FittnesFunction(SubjectTraveller subject)
        {
            int actualWeight = 0;
            int actualValue = 0;
            double vc = _container.MaxSpeed;
            double f = CalculateTimeBetweenCities(subject.FirstCity, subject.TripPlan[0], vc);
            int itemWeight = subject.TripPlan[0].ItemsInCity.Last().Weight;
            if ( CanPickUpItem(itemWeight, actualWeight, _container.Capacity))
            {
                actualWeight += itemWeight;
                actualValue += subject.TripPlan[0].ItemsInCity.Last().Profit;
            }
                

            for (int i=0; i < subject.TripPlan.Count()-1 ; i++ )
            {
                vc = _container.MaxSpeed - actualWeight * ((_container.MaxSpeed - _container.MinSpeed) / _container.Capacity);
                f += CalculateTimeBetweenCities(subject.TripPlan[i], subject.TripPlan[i+1], vc);
                itemWeight = subject.TripPlan[i + 1].ItemsInCity.Last().Weight;
                if (CanPickUpItem(itemWeight, actualWeight, _container.Capacity))
                {
                    actualWeight += itemWeight;
                    actualValue += subject.TripPlan[i + 1].ItemsInCity.Last().Profit;
                }
                    
            }

            vc = _container.MaxSpeed - actualWeight * ((_container.MaxSpeed - _container.MinSpeed) / _container.Capacity);
            f += CalculateTimeBetweenCities(subject.TripPlan[subject.TripPlan.Count()-1], subject.FirstCity, vc);

            double g = actualValue - f;

            return g;
        }

        public double FittnesFunctionF(SubjectTraveller subject)
        {
            int actualWeight = 0;
            double vc = _container.MaxSpeed;
            double f = CalculateTimeBetweenCities(subject.FirstCity, subject.TripPlan[0], vc);
            int itemWeight = subject.TripPlan[0].ItemsInCity.Last().Weight;
            if (CanPickUpItem(itemWeight, actualWeight, _container.Capacity))
                actualWeight += itemWeight;

            for (int i = 0; i < subject.TripPlan.Count() - 1; i++)
            {
                vc = _container.MaxSpeed - actualWeight * ((_container.MaxSpeed - _container.MinSpeed) / _container.Capacity);
                f += CalculateTimeBetweenCities(subject.TripPlan[i], subject.TripPlan[i + 1], vc);
                itemWeight = subject.TripPlan[i + 1].ItemsInCity.Last().Weight;
                if (CanPickUpItem(itemWeight, actualWeight, _container.Capacity))
                    actualWeight += itemWeight;
            }

            vc = _container.MaxSpeed - actualWeight * ((_container.MaxSpeed - _container.MinSpeed) / _container.Capacity);
            f += CalculateTimeBetweenCities(subject.TripPlan[subject.TripPlan.Count() - 1], subject.FirstCity, vc);

            return f;
        }

        //utlis for fittness function
        private void FillDistanceMatrix(List<City> cities)
        {
            for(int i = 0; i < _distanceMatrix.GetLength(0); i++ )
                for (int j=0; j < _distanceMatrix.GetLength(0); j++)
                {
                    _distanceMatrix[_container._Cities[i].CityId-1, _container._Cities[j].CityId-1] =cities[i].CountDistance(cities[j]);
                }
            
        }

        private double CalculateTimeBetweenCities(City c1, City c2, double v)
        {
            return _distanceMatrix[c1.CityId - 1, c2.CityId - 1] / v;
            //return c1.CountDistance(c2) / v;
        }

        private bool CanPickUpItem(int itemWeight, int actualCapacity, int capacity)
        {
            if ( itemWeight <= capacity - actualCapacity)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        //end utils for fittness function






    }
}
