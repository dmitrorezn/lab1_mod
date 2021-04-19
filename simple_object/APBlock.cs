using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_object
{
    public class APBlock : BaseBlock
    {
        private double dt;
        private double T;
        private double prev = 0;
        public APBlock(double _dt, double _T)
        {
            this.dt = _dt;
            this.T = _T;
        }

        public override double Calculate(double x)
        {
            var y = (dt * x + T * prev) / (T + dt);
            this.prev = y;
            return y;
        }
    }
}
