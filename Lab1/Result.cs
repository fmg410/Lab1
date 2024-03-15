using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Result
    {
        public int total_weight;
        public int total_value;
        public List<Item> result;

        public Result(int total_weight, int total_value, List<Item> result)
        {
            this.total_weight = total_weight;
            this.total_value = total_value;
            this.result = result;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("value : weight");

            foreach (Item i in result)
                stringBuilder.Append(i.value.ToString()).Append(" ").AppendLine(i.weight.ToString());

            //Console.WriteLine(stringBuilder.ToString());
            return stringBuilder.ToString();
        }
    }
}
