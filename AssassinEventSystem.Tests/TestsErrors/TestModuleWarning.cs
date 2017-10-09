using System;
using AssassinEventSystem.Infrastructure;

namespace AssassinEventSystem.Tests.TestsErrors
{
    public class TestModuleWarning : Warning
    {
        public TestModuleWarning(string message) : base(message)
        {
        }

        public TestModuleWarning(string message, Exception exception) : base(message, exception)
        {
        }

        public TestModuleWarning(Exception exception) : base(exception)
        {
        }
    }
}