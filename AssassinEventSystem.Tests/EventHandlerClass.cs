using AssassinEventSystem.EventArguments;
using System;

namespace AssassinEventSystem.Tests
{
    public class EventHandlerClass
    {
        public string Message;
        public bool HasException;
        public Exception Exception;

        public EventHandlerClass()
        {
            Message = string.Empty;
            HasException = false;

            Assassin.Error += OnError;
            Assassin.Notification += OnNotification;
            Assassin.Warning += OnWarning;
        }

        private void OnWarning(object sender, WarningEventArgs e)
        {
            Message = e.Message;
        }

        private void OnNotification(object sender, NotificationEventArgs e)
        {
            Message = e.Message;
        }

        private void OnError(object sender, ErrorEventArgs e)
        {
            Message = e.Message;
        }
    }
}