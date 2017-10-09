using System;

namespace AssassinEventSystem.Infrastructure
{
    public abstract class EventBase
    {
        protected EventBase(string message)
        {
            Message = message;
        }

        protected EventBase(string message, Exception exception) : this(message)
        {
            Exception = exception;
        }

        protected EventBase(Exception exception)
        {
            Exception = exception;
            Message = exception.Message;
        }

        public Exception Exception { get; set; }
        public string Message { get; set; }
        public bool HasException => Exception != null;
    }
}