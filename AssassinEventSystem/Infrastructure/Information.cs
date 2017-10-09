using System;

namespace AssassinEventSystem.Infrastructure
{
    public abstract class Information : EventBase
    {
        protected Information(string message) : base(message)
        {
        }

        protected Information(string message, Exception exception) : base(message, exception)
        {
        }

        protected Information(Exception exception) : base(exception)
        {
        }
    }
}