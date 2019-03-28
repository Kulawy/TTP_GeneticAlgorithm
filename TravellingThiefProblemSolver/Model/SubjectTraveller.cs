using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TravellingThiefProblemSolver.Utilities;

namespace TravellingThiefProblemSolver.Model
{
    public class SubjectTraveller
    {
        public City FirstCity { set; get; }
        //public int[] TripPlan { set; get; }
        public City[] TripPlan { set; get; }
        public double TravelTime { set; get; }
        public double MutationPropability { get; }
        private Random _rnd = new Random();

        public SubjectTraveller(SubjectTraveller other)
        {
            FirstCity = other.FirstCity;
            TripPlan = new City[other.TripPlan.Length];
            Array.Copy(other.TripPlan, TripPlan, other.TripPlan.Length);
            TravelTime = other.TravelTime;
            MutationPropability = other.MutationPropability;
        }

        public SubjectTraveller(int sizeOfTripPlan, double mutProp, City firstCity)
        {
            //TripPlan = new int[size];
            TripPlan = new City[sizeOfTripPlan];
            MutationPropability = mutProp;
            FirstCity = firstCity;
        }



        public override string ToString()
        {
            string subTravString = $"Travel time: {TravelTime} \n" +
                "Tripl Plan:\n" +
                "First City: " + FirstCity + "\n";
            foreach(City c in TripPlan)
            {
                subTravString += c + "\n";
            }

            return subTravString;
        }

        public override bool Equals(object obj)
        {
            if ( obj == null)
            {
                return false;
            }
            SubjectTraveller other = (SubjectTraveller)obj;
            if (!other.FirstCity.Equals(this.FirstCity))
            {
                return false;
            }
            if (!other.TripPlan.Equals(this.TripPlan))
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return TripPlan.GetHashCode();
        }

        public void SwapInTripPlan(int index1, int index2)
        {
            var temp = TripPlan[index1];
            TripPlan[index1] = TripPlan[index2];
            TripPlan[index2] = temp;

        }

        public void SwapInMemory(int index1, int index2)
        {
            //This method also create a value copy of an element
            //TripPlan[index1] = Interlocked.Exchange(ref TripPlan[index2], TripPlan[index1]);

            //Tylko przepięcie referencji ale Czy zadziała ?! w sumie działa ale chyba nie o to chodzi :D 
            Swap_ref(ref TripPlan[index1] , ref TripPlan[index2]);
        }

        private void Swap_ref(ref City cityOne, ref City cityTwo)
        {
            //Console.WriteLine("City one: {0}, City two: {1}", cityOne, cityTwo);
            var temp = cityOne;
            cityOne = cityTwo;
            cityTwo = temp;
            //Console.WriteLine("City one: {0}, City two: {1}", cityOne, cityTwo);
        }

        public void Mutate()
        {
            //SubjectTraveller solution = new SubjectTraveller(subject);

            for (int i = 0; i < this.TripPlan.Length; i++)
            {
                //int citiIdFirst = solution.TripPlan[ThreadSafeRandom.ThisThreadsRandom.Next(solution.TripPlan.Length)].CityId;
                //int citiIdFirst = this.TripPlan[i].CityId;

                //double num = ThreadSafeRandom.ThisThreadsRandom.NextDouble();
                double num = _rnd.NextDouble();


                if (num <= Env.MUT_RATE)
                {
                    int inTripListIdSecond = ThreadSafeRandom.ThisThreadsRandom.Next(this.TripPlan.Length);
                    this.SwapInTripPlan(i, inTripListIdSecond);
                }

            }
            //return solution ;
        }
    }

}
