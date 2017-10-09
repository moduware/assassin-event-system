using System;

namespace AssassinEventSystem.Infrastructure
{
    public abstract class Error : EventBase
    {
        protected Error(string message) : base(message)
        {
        }

        protected Error(string message, Exception exception) : base(message, exception)
        {
        }

        protected Error(Exception exception) : base(exception)
        {
        }
    }
}