using System;
using AssassinEventSystem.Tests.TestsErrors;

namespace AssassinEventSystem.Tests
{
    public class EventPublisherClass
    {
        #region Raise With No Exception

        public void RaiseError(string message)
        {
            Assassin.RaiseError(new TestModuleError(message));
        }

        public void RaiseWarning(string message)
        {
            Assassin.RaiseWarning(new TestModuleWarning(message));
        }

        public void RaiseNotification(string message)
        {
            Assassin.RaiseNotification(new TestModuleNotification(message));
        }

        #endregion

        #region Raise With NullReferenceException

        public void RaiseTestModuleErrorWithNullReferenceException(string message)
        {
            var ex = new NullReferenceException(message);
            Assassin.RaiseError(new TestModuleError(ex.Message, ex));
            throw ex;
        }

        public void RaiseTestModuleWarningWithNullReferenceException(string message)
        {
            var ex = new NullReferenceException(message);
            Assassin.RaiseWarning(new TestModuleWarning(ex.Message, ex));
            throw ex;
        }

        public void RaiseTestModuleNotificationWithNullReferenceException(string message)
        {
            var ex = new NullReferenceException(message);
            Assassin.RaiseNotification(new TestModuleNotification(message, ex));
            throw ex;
        }

        #endregion

        #region Raise With ArgumentNullException

        public void RaiseTestModuleErrorWithArgumentNullException(string message)
        {
            var ex = new ArgumentNullException("", message);
            Assassin.RaiseError(new TestModuleError(ex.Message, ex));
            throw ex;
        }

        #endregion

        public void RaiseTestModuleErrorWithNullReferenceException2(string message)
        {
            var ex = new NullReferenceException(message);
            Assassin.RaiseError(new TestModuleError(ex));
            throw ex;
        }

        public void RaiseTestModuleWarningWithNullReferenceException2(string message)
        {
            var ex = new NullReferenceException(message);
            Assassin.RaiseWarning(new TestModuleWarning(ex));
            throw ex;
        }

        public void RaiseTestModuleNotificationWithNullReferenceException2(string message)
        {
            var ex = new NullReferenceException(message);
            Assassin.RaiseNotification(new TestModuleNotification(ex));
            throw ex;
        }

        //public void RaiseBadError()
        //{
        //    GlobalEventsManager.RaiseBadError(new TestModuleError("Bad error here"));
        //}

    }
}