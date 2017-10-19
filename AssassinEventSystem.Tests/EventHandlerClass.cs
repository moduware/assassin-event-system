using System;
using AssassinEventSystem.EventArguments;
using AssassinEventSystem.Infrastructure;

namespace AssassinEventSystem.Tests
{
    public class EventHandlerClass
    {
        public string Message;
        public bool HasException;
        public Exception Exception;
        public Error Error { get; set; }
        public Warning Warning { get; set; }
        public Notification Notification { get; set; }

        public EventHandlerClass()
        {
            Message = string.Empty;
            HasException = false;

            Assassin.OnError += OnError;
            Assassin.OnNotification += OnNotification;
            Assassin.OnWarning += OnWarning;
            //Assassin.OnBadErrorHappened += OnBadError;
        }

        //private void OnBadError(ErrorEventArgs args)
        //{
        //    Message = "Bad error here";
        //}

        private void OnWarning(object sender, WarningEventArgs e)
        {
            Message = e.Warning.Message;
            Warning = e.Warning;

            if (e.Warning.Exception != null)
            {
                HasException = true;
                Exception = e.Warning.Exception;
            }
        }

        private void OnNotification(object sender, NotificationEventArgs e)
        {
            Message = e.Notification.Message;
            Notification = e.Notification;

            if (e.Notification.Exception != null)
            {
                HasException = true;
                Exception = e.Notification.Exception;
            }
        }

        private void OnError(object sender, ErrorEventArgs e)
        {
            Message = e.Error.Message;
            Error = e.Error;

            if (e.Error.Exception != null)
            {
                HasException = true;
                Exception = e.Error.Exception;
            }
        }
    }
}