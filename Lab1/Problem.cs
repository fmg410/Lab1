using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("TestProject1")]

namespace Lab1
{
    public class Problem
    {
        public const int MIN_WEIGHT = 1;
        public const int MAX_WEIGHT = 10;
        public const int MIN_VALUE = 1;
        public const int MAX_VALUE = 10;

        public int n;
        public int seed;
        public List<Item> items;
        public Problem(int n, int seed)
        {
            this.n = n;
            this.seed = seed;
            this.items = new List<Item>();
            var rand = new Random(seed);
            for (int i = 0; i < n; i++)
            {
                items.Add(new Item(rand.Next(MIN_VALUE, MAX_VALUE), rand.Next(MIN_WEIGHT, MAX_WEIGHT)));
            }
        }
        public Result solve(int capacity)
        {
            if (capacity < 0) capacity = 0;

            items.Sort(Item.compareItems);
            List<Item> result = new List<Item>();
            int total_weight = 0;
            int total_value = 0;
            foreach (Item item in items)
            {
                if (item.weight + total_weight <= capacity)
                {
                    result.Add(item);
                    total_value += item.value;
                    total_weight += item.weight;
                }
            }
            return new Result(total_weight, total_value, result);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("value : weight");

            foreach (Item i in items)
                stringBuilder.Append(i.value.ToString()).Append(" ").AppendLine(i.weight.ToString());

            //Console.WriteLine(stringBuilder.ToString());
            return stringBuilder.ToString();
        }
    }
}
