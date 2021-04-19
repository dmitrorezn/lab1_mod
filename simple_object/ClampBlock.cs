using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_object
{
    public class ClampBlock : BaseBlock
    {
        private double min;
        private double max;
        public ClampBlock(double min, double max)
        {
            this.min = min;
            this.max = max;
        }
        public override double Calculate(double x)
        {
            x = (x > max) ? max : x;
            x = (x < min) ? min : x;
            return x;
        }
    }
}
