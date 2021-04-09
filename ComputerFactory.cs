using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public class ComputerFactory
    { 
         public Computer createComputer(string name)
            {
            return new Computer(name);
            }

    }
}
