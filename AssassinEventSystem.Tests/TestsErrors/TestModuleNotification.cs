using System;
using AssassinEventSystem.Infrastructure;

namespace AssassinEventSystem.Tests.TestsErrors
{
    public class TestModuleNotification : Notification
    {
        public TestModuleNotification(string message) : base(message)
        {
        }

        public TestModuleNotification(string message, Exception exception) : base(message, exception)
        {
        }

        public TestModuleNotification(Exception exception) : base(exception)
        {
        }
    }
}