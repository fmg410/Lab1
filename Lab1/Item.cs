using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Item
    {
        public int id;
        public int value;
        public int weight;
        public Item(int value, int weight)
        {
            if (value < 0) value = 0;
            if (weight < 0) weight = 0;
            this.value = value;
            this.weight = weight;
        }
        public static int compareItems(Item item1, Item item2)
        {
            double r1 = (double)item1.value / item1.weight;
            double r2 = (double)item2.value / item2.weight;
            if (item1 == null || item2 == null) return 0;
            if (r1 > r2) return -1;
            if (r1 < r2) return 1;
            if (r1 == r2) return (item1.weight < item2.weight) ? 1 : -1;
            return 0;
        }
    }
}
