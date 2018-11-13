using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class OneDimArray
    {
        public int[] Numbers { get; set; }
        public int Length { get; set; }

        public OneDimArray(int length)
        {
            Length = length;
            Numbers = new int[length];
        }

        public int this[int i]
        {
            get
            {
                return Numbers[i];
            }
            set
            {

                Numbers[i] = value * value;
            }
        }

    
    }
}
