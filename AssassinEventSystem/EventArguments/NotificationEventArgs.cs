using System;
using AssassinEventSystem.Infrastructure;

namespace AssassinEventSystem.EventArguments
{
    public class NotificationEventArgs : EventArgs
    {
        public Notification Notification { get; set; }

        public NotificationEventArgs(Notification notification)
        {
            Notification = notification;
        }
    }
}