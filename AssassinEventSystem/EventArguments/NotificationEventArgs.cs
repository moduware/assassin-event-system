using System;

namespace AssassinEventSystem.EventArguments
{
    public class NotificationEventArgs : EventArgs
    {
        //public Notification Notification { get; set; }
        public string Message { get; set; }

        public NotificationEventArgs(string notification)
        {
            Message = notification;
        }
    }
}