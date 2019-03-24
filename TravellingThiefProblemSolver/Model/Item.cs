using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingThiefProblemSolver.Model
{
    public class Item: IComparable<Item>
    {
        public int ItemId { get; }
        public int Profit { get; }
        public int Weight { get; }
        public int AssignedNodeNumber { get; }

        public Item(int id, int profit, int weight, int assignedNode)
        {
            ItemId = id;
            Profit = profit;
            Weight = weight;
            AssignedNodeNumber = assignedNode;
        }

        public override string ToString()
        {
            return "Item: " + ItemId + " profit:" + Profit + " weight:" + Weight + " AssignedToNodeNumber:" + AssignedNodeNumber;
        }

        public Item Copy()
        {
            Item copy = new Item(this.ItemId, this.Profit, this.Weight, this.AssignedNodeNumber);
            return copy;
        }

        public int CompareTo(Item item)
        {
            double itemRatio = item.Profit / item.Weight;
            double thisRatio = this.Profit / this.Weight;
            if (itemRatio > thisRatio)
                return 1;
            else if (itemRatio < thisRatio)
                return -1;
            else
                return 0;
        }


    }
}
