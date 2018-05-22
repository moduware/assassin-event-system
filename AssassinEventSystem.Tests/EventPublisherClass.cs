using System;

namespace AssassinEventSystem.Tests
{
    public class EventPublisherClass
    {
        #region Raise With No Exception

        public void RaiseError(string message)
        {
            Assassin.RaiseError(message);
        }

        public void RaiseWarning(string message)
        {
            Assassin.RaiseWarning(message);
        }

        public void RaiseNotification(string message)
        {
            Assassin.RaiseNotification(message);
        }

        #endregion
    }
}