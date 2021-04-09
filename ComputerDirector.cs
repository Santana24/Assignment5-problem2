using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public class ComputerDirector
    {
        public Computer construct(ComputerBuilder builder) 
        {
            return builder.build();
        }
    }
}
