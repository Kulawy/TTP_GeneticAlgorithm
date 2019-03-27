using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravellingThiefProblemSolver.Utilities;
using static TravellingThiefProblemSolver.TravellingSalesmanProblem.TTP;

namespace TravellingThiefProblemSolver.Model
{
    public class City
    {
        public int CityId { get; }
        public double X { get; }
        public double Y { get;}

        public List<Item> ItemsInCity { set; get; }

        public Item SelectedItem { set; get; }

        public City(int id, double x, double y)
        {
            CityId = id;
            X = x;
            Y = y;
            ItemsInCity = new List<Item>();
        }

        public override string ToString()
        {
            string items = "";
            for (int i = 0; i < ItemsInCity.Count; i++)
            {
                items += ItemsInCity[i].ItemId + " | ";
            }
            return "City: " + CityId + " x:" + X + " y:" + Y + " items in city: " + items;
        }

        public override bool Equals(object obj)
        {
            var other = (City)obj;
            if ( this.CityId == other.CityId)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double CountDistance(City otherCity)
        {
            double x_dist = X - otherCity.X;
            double y_dist = Y - otherCity.Y;
            
            return Math.Sqrt((x_dist*x_dist) + (y_dist*y_dist)); 
        }

        public delegate Item ItemSelection(City c);

        public Item SelectItem(ItemSelection itemSelection)
        {
            SelectedItem = itemSelection(this);
            return SelectedItem;
        }

        public delegate void SortItemMethod();

        public void SortItemsBy(int how)
        {
            if ( how == 1)
            {
                SortItemMethod sortMethodDelegate = new SortItemMethod(AscGreedyByProfitItemSort);
                SortItemList(sortMethodDelegate);
            }
            else if( how == 2)
            {
                Shuffle();
            }
            else if (how == 3)
            {
                SortItemMethod sortMethodDelegate = new SortItemMethod(AscGreedyByProfitItemSort);
                SortItemList(sortMethodDelegate);
            }
            else {
                SortItemMethod sortMethodDelegate = new SortItemMethod(AscGreedyByProfitItemSort);
                SortItemList(sortMethodDelegate);
            }
            
        }

        private void SortItemList(SortItemMethod itemSelection)
        {
            itemSelection();
        }


        private void AscGreedyByProfitItemSort()
        {
            //ItemsInCity.Sort();
            for (int i = 0; i < ItemsInCity.Count - 1; i++)
            {
                for (int j = 0; j < ItemsInCity.Count - 1; j++)
                {
                    if (ItemsInCity[j].Profit > ItemsInCity[j + 1].Profit)
                    {
                        Item bufor = ItemsInCity[j].Copy();
                        ItemsInCity[j] = ItemsInCity[j + 1].Copy();
                        ItemsInCity[j + 1] = bufor;
                    }

                }
            }
        }

        //
        private void DescWeightItemSort()
        {
            //ItemsInCity.Sort();
            for (int i = 0; i < ItemsInCity.Count; i++)
            {
                for (int j = 0; j < ItemsInCity.Count - 1; j++)
                {
                    if (ItemsInCity[j].Weight < ItemsInCity[j + 1].Weight)
                    {
                        Item bufor = ItemsInCity[j].Copy();
                        ItemsInCity[j] = ItemsInCity[j + 1].Copy();
                        ItemsInCity[j + 1] = bufor;
                    }

                }
            }
        }

        private void Shuffle()
        {
            int n = ItemsInCity.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                var value = ItemsInCity[k];
                ItemsInCity[k] = ItemsInCity[n];
                ItemsInCity[n] = value;
            }
        }

        public override int GetHashCode()
        {
            string[] path = { $"{CityId} {X} {Y}", $"{ItemsInCity} {SelectedItem}" } ;
            //return Path.Combine(CityId, X, Y, ItemsInCity, SelectedItem);
            return Convert.ToInt32(Path.Combine(path));

        }
    }
}


/*
SOME OLD STUFF
public delegate Item ItemSelection(City c);

public void ChooseItemInCity()
{
    ItemSelection choseDelegate = new ItemSelection(GreedyItemChoseByBestRatio);
    foreach (City c in _container._Cities)
    {
        c.SelectItem(choseDelegate);
    }
}

public Item GreedyItemChoseByValue(City c)
{
    List<Item> itemsInCity = c.ItemsInCity;
    Item best = itemsInCity[0];
    foreach (Item i in itemsInCity)
    {
        if (i.Profit > best.Profit)
        {
            best = i;
        }
    }
    return best;
}

public Item GreedyItemChoseByBestRatio(City c)
{
    List<Item> itemsInCity = c.ItemsInCity;
    Item best = itemsInCity[0];
    foreach (Item i in itemsInCity)
    {
        if ((i.Profit / i.Weight) > (best.Profit / best.Weight))
        {
            best = i;
        }
    }
    return best;
}

*/
