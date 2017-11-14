using System;

namespace AssassinEventSystem.Infrastructure
{
    public class Information : EventBase
    {
        public Information(string message) : base(message)
        {
        }

        public Information(string message, Exception exception) : base(message, exception)
        {
        }

        public Information(Exception exception) : base(exception)
        {
        }
    }


}