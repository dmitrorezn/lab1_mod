using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_object
{
    public class ComplexBlock : BaseBlock
    {
        public List<BaseBlock> Blocks { get; set; }

        public ComplexBlock()
        {
            this.Blocks = new List<BaseBlock>();
        }

        public override double Calculate(double x)
        {
            foreach( var block in this.Blocks)
            {
                x = block.Calculate(x);
            }
            return x;
        }
    }
}
