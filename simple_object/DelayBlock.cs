using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_object
{
    public class DelayBlock : BaseBlock
    {
        private double dt;
        private double tau;
        private Queue<double> q;
        private int capacity;

        public DelayBlock(double dt, double tau)
        {
            this.dt = dt;
            this.tau = tau;
            this.capacity = (int)(tau / dt);
            q = new Queue<double>(capacity);
        }
        public override double Calculate(double x)
        {
            q.Enqueue(x);
            return (q.Count < capacity) ? 0 : q.Dequeue();
        }

    }
}
