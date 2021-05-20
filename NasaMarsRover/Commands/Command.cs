using System;
using System.Collections.Generic;
using System.Text;

namespace NasaMarsRover.Commands
{

    public abstract class Command
    {
        public abstract void Execute(Rover rover);
    }
}