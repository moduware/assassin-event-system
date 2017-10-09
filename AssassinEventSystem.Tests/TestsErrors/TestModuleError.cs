using System;
using AssassinEventSystem.Infrastructure;

namespace AssassinEventSystem.Tests.TestsErrors
{
    public class TestModuleError : Error
    {
        public TestModuleError(string message) : base(message)
        {
        }

        public TestModuleError(string message, Exception exception) : base(message, exception)
        {
        }

        public TestModuleError(Exception exception) : base(exception)
        {
        }
    }

    public class AnotherTestModuleError : Error
    {
        public AnotherTestModuleError(string message) : base(message)
        {
        }

        public AnotherTestModuleError(string message, Exception exception) : base(message, exception)
        {
        }

        public AnotherTestModuleError(Exception exception) : base(exception)
        {
        }
    }
}