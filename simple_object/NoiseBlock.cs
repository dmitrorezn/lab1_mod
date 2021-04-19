using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_object
{
    public class NoiseBlock : BaseBlock
    {
        private double margin; //значення похибки у відсотках
        private Random random = new Random();

        public NoiseBlock(double margin)
        {
            this.margin = margin;
        }
        public override double Calculate(double x)
        {
            var m = x / 100 * margin; //значення похибки в абсолютних одиницях
            var r = random.NextDouble() * m; //випадкове значення в абсолютних одиницях
            return x + r - m / 2 + random.NextDouble() / 2;
        }
    }
}
