using System;

namespace AssassinEventSystem.Infrastructure
{
    public abstract class Warning : EventBase
    {
        protected Warning(string message) : base(message)
        {
        }

        protected Warning(string message, Exception exception) : base(message, exception)
        {
        }

        protected Warning(Exception exception) : base(exception)
        {
        }
    }
}