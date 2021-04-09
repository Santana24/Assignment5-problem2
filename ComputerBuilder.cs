using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public class ComputerBuilder
    {
        private Computer computer;

        public ComputerBuilder() 
        {
            ComputerFactory computerFactory = new ComputerFactory();
            this.computer = computerFactory.createComputer("Super Computer");
        }

        public Computer build() 
        {
            return computer;
         }

        public ComputerBuilder addHardDrive( HardDrive hardDrive) 
        {
            computer.HardDrive = hardDrive;
            return this;
        }
        public ComputerBuilder addMotherboard(Motherboard motherboard)
        {
            computer.Motherboard = motherboard;
            return this;
        }
        public ComputerBuilder addCPU(CPU cpu)
        {
            computer.CPU = cpu;
            return this;
        }
        public ComputerBuilder addMemory(Memory memory)
        {
            computer.Memory = memory;
            return this;
        }
        public ComputerBuilder addGraphicsCard(GraphicsCard graphicsCard)
        {
            computer.GraphicsCard = graphicsCard;
            return this;
        }
        public ComputerBuilder addCase(Case computerCase)
        {
            computer.Case = computerCase;
            return this;
        }

    }
}
