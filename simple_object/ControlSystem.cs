using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_object
{
    public class ControlSystem
    {
        List<BaseBlock> tank1;
        List<BaseBlock> gainBlocks1;
        List<BaseBlock> tank2;
        List<BaseBlock> gainBlocks2;
        private double valveIn1;
        private double valveIn2;
        private double valve12;
        private double valveOut1;
        private double valveOut2;

        private ClampBlock clamp = new ClampBlock(0, 100);
        public double dt { get; set; }
        public double Time;
        public ComplexBlock ControlObject { get; set; }
        public double ValveIn1 { get { return valveIn1; } set { valveIn1 = clamp.Calculate(value); } }
        public double ValveIn2 { get { return valveIn2; } set { valveIn2 = clamp.Calculate(value); } }
        public double Valve12 { get { return valve12; } set { valve12 = clamp.Calculate(value); } }
        public double ValveOut1 { get { return valveOut1; } set { valveOut1 = clamp.Calculate(value); } }
        public double ValveOut2 { get { return valveOut2; } set { valveOut2 = clamp.Calculate(value); } }


        private double out1;
        private double out2;
        public double Out1 { get { return out1; } }
        public double Out2 { get { return out2; } }


        public ControlSystem(double dt)
        {
            this.dt = dt;

            tank1 = new List<BaseBlock>();
            tank1.Add(new GainBlock(1));
            tank1.Add(new APBlock(dt, 78.1));
            tank1.Add(new ClampBlock(0, 100));
            tank1.Add(new NoiseBlock(1));

            gainBlocks1 = new List<BaseBlock>();
            gainBlocks1.Add(new GainBlock(205.1));
            gainBlocks1.Add(new GainBlock(211.1));
            gainBlocks1.Add(new GainBlock(77.57));
            gainBlocks1.Add(new GainBlock(0.957));

            tank2 = new List<BaseBlock>();
            tank2.Add(new GainBlock(1));
            tank2.Add(new APBlock(dt, 130));
            tank2.Add(new ClampBlock(0, 100));
            tank2.Add(new NoiseBlock(1));

            gainBlocks2 = new List<BaseBlock>();
            gainBlocks2.Add(new GainBlock(0.255));
            gainBlocks2.Add(new GainBlock(347.7));

        }
        public void Calculate()
        {
            double u = 0;
            u = gainBlocks1[0].Calculate(ValveIn1) 
                + gainBlocks1[1].Calculate(ValveIn2) 
                 - gainBlocks1[2].Calculate(ValveOut1) 
                  + gainBlocks1[3].Calculate(Out2);

            var y = u - out1;
            foreach (var b in tank1)
            {
                y = b.Calculate(y);
            }
            Time += dt;
            out1 = y;

            double u1 = 0;
            u1 = gainBlocks2[0].Calculate(Out1) 
                 - gainBlocks2[1].Calculate(ValveOut2);

            var y1 = u1 - out2;
            foreach (var b in tank2)
            {
                y1 = b.Calculate(y1);
            }
            Time += dt;
            out2 = y1;
        }
    }
}
