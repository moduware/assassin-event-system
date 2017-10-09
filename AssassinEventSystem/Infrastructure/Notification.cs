using System;

namespace AssassinEventSystem.Infrastructure
{
    public abstract class Notification : EventBase
    {
        protected Notification(string message) : base(message)
        {
        }

        protected Notification(string message, Exception exception) : base(message, exception)
        {
        }

        protected Notification(Exception exception) : base(exception)
        {
        }
    }
}