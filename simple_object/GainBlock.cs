using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_object
{
    public class GainBlock : BaseBlock 
    {
        private double Gain { get; set; }
        public GainBlock(double _gain)
        {
            this.Gain = _gain;
        }
        public override double Calculate(double x)
        {
            return this.Gain * x;
        }
    }
}
