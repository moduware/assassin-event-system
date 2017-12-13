using System;

namespace AssassinEventSystem.EventArguments
{
    public class NotificationEventArgs : EventArgs
    {
        public string Message { get; set; }

        public NotificationEventArgs(string notification)
        {
            Message = notification;
        }
    }
}