using System;

namespace AssassinEventSystem.Infrastructure
{
    public  class Warning : EventBase
    {
        public Warning(string message) : base(message)
        {
        }

        public Warning(string message, Exception exception) : base(message, exception)
        {
        }

        public Warning(Exception exception) : base(exception)
        {
        }
    }
}