using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public class Computer
    {
        public HardDrive HardDrive { get; set; }
        public Motherboard Motherboard { get; set; }
        public CPU CPU { get; set; }
        public Memory Memory { get; set; }
        public GraphicsCard GraphicsCard { get; set; }
        public Case Case { get; set; }

        public string Name{ get; set; }
        public Computer() { }

        public Computer(string name) 
        {
            Name = name;
        }

        // public Computer (HardDrive hardDrive, Motherboard motherboard, CPU cpu,
        //     Memory memory, GraphicsCard graphicsCard, Case computerCase)
        //  {
        //     this.HardDrive= hardDrive;
        //     this.Motherboard = motherboard;
        //     this.CPU = cpu;
        //    this.Memory = memory;
        //     this.GraphicsCard = graphicsCard;
        //     this.Case = computerCase;
        // }

        public override string ToString()
        {
            string s = Name + "\n";

            s+= HardDrive + "\n" + Motherboard + "\n" + CPU + "\n" + Memory + "\n" +
                GraphicsCard + "\n" + Case;

            return s;
        }
    }
}
