using System;
using AssassinEventSystem.Infrastructure;

namespace AssassinEventSystem.EventArguments
{
    public class InformationEventArgs : EventArgs
    {
        public Information Information { get; set; }

        public InformationEventArgs(Information information)
        {
            Information = information;
        }
    }
}