using System;
using AssassinEventSystem.Tests.TestsErrors;
using NUnit.Framework;

namespace AssassinEventSystem.Tests
{
    [TestFixture]
    public class ErrorManagerTest
    {

        [Test]
        public void RaiseErrorWithMessageOnlyTriggerTheCorrectEventOnTheHandlerClass()
        {
            var handler = new EventHandlerClass();
            var publisher = new EventPublisherClass();

            Assert.AreEqual(string.Empty, handler.Message);
            publisher.RaiseError("some error");
            Assert.AreEqual("some error", handler.Message);
        }

        [Test]
        public void RaiseNotificationsWithMessageOnlyTriggerTheCorrectEventOnTheHandlerClass()
        {
            var handler = new EventHandlerClass();
            var publisher = new EventPublisherClass();

            Assert.AreEqual(string.Empty, handler.Message);
            publisher.RaiseNotification("some notification");
            Assert.AreEqual("some notification", handler.Message);
        }

        [Test]
        public void RaiseWarningWithMessageOnlyTriggerTheCorrectEventOnTheHandlerClass()
        {
            var handler = new EventHandlerClass();
            var publisher = new EventPublisherClass();

            Assert.AreEqual(string.Empty, handler.Message);
            publisher.RaiseWarning("some warning");
            Assert.AreEqual("some warning", handler.Message);
        }

        //-------------------------------------------------------------------------------------------------//

        [Test]
        public void RaiseErrorWithNullReferenceExceptionTriggerTheCorrectEventOnTheHandlerClass()
        {
            var handler = new EventHandlerClass();
            var publisher = new EventPublisherClass();

            Assert.AreEqual(string.Empty, handler.Message);

            try
            {
                publisher.RaiseTestModuleErrorWithNullReferenceException("some error");
            }
            catch (NullReferenceException)
            {
                Assert.AreEqual("some error", handler.Message);
                Assert.IsTrue(handler.Exception is NullReferenceException);
                Assert.AreEqual(true, handler.HasException);
                Assert.IsTrue(handler.Error is TestModuleError);
            }
        }

        [Test]
        public void RaiseWarningWithNullReferenceExceptionTriggerTheCorrectEventOnTheHandlerClass()
        {
            var handler = new EventHandlerClass();
            var publisher = new EventPublisherClass();

            Assert.AreEqual(string.Empty, handler.Message);

            try
            {
                publisher.RaiseTestModuleWarningWithNullReferenceException("some warning");
            }
            catch (NullReferenceException)
            {
                Assert.AreEqual("some warning", handler.Message);
                Assert.IsTrue(handler.Exception is NullReferenceException);
                Assert.AreEqual(true, handler.HasException);
                Assert.IsTrue(handler.Warning is TestModuleWarning);
            }
        }

        [Test]
        public void RaiseNotificationWithNullReferenceExceptionTriggerTheCorrectEventOnTheHandlerClass()
        {
            var handler = new EventHandlerClass();
            var publisher = new EventPublisherClass();

            Assert.AreEqual(string.Empty, handler.Message);

            try
            {
                publisher.RaiseTestModuleNotificationWithNullReferenceException("some noty");
            }
            catch (NullReferenceException)
            {
                Assert.AreEqual("some noty", handler.Message);
                Assert.IsTrue(handler.Exception is NullReferenceException);
                Assert.AreEqual(true, handler.HasException);
                Assert.IsTrue(handler.Notification is TestModuleNotification);
            }
        }

        //-------------------------------------------------------------------------------------------------//

        [Test]
        public void RaiseErrorWithArgumentNullExceptionTriggerTheCorrectEventOnTheHandlerClass()
        {
            var handler = new EventHandlerClass();
            var publisher = new EventPublisherClass();

            Assert.AreEqual(string.Empty, handler.Message);

            try
            {
                publisher.RaiseTestModuleErrorWithArgumentNullException("some error");
            }
            catch (ArgumentNullException)
            {
                Assert.AreEqual("some error", handler.Message);
                Assert.IsTrue(handler.Exception is ArgumentNullException);
                Assert.AreEqual(true, handler.HasException);
                Assert.IsTrue(handler.Error is TestModuleError);
            }
        }

        //-------------------------------------------------------------------------------------------------//

        [Test]
        public void RaiseErrorWithExceptionOnlyTriggerTheCorrectEventOnTheHandlerClass()
        {
            var handler = new EventHandlerClass();
            var publisher = new EventPublisherClass();

            Assert.AreEqual(string.Empty, handler.Message);

            try
            {
                publisher.RaiseTestModuleErrorWithNullReferenceException2("some error");
            }
            catch (NullReferenceException)
            {
                Assert.AreEqual("some error", handler.Message);
                Assert.IsTrue(handler.Exception is NullReferenceException);
                Assert.AreEqual(true, handler.HasException);
                Assert.IsTrue(handler.Error is TestModuleError);
            }
        }

        [Test]
        public void RaiseWarningWithExceptionOnlyTriggerTheCorrectEventOnTheHandlerClass()
        {
            var handler = new EventHandlerClass();
            var publisher = new EventPublisherClass();

            Assert.AreEqual(string.Empty, handler.Message);

            try
            {
                publisher.RaiseTestModuleWarningWithNullReferenceException2("some warning");
            }
            catch (NullReferenceException)
            {
                Assert.AreEqual("some warning", handler.Message);
                Assert.IsTrue(handler.Exception is NullReferenceException);
                Assert.AreEqual(true, handler.HasException);
                Assert.IsTrue(handler.Warning is TestModuleWarning);
            }
        }

        [Test]
        public void RaiseNotificationWithExceptionOnlyTriggerTheCorrectEventOnTheHandlerClass()
        {
            var handler = new EventHandlerClass();
            var publisher = new EventPublisherClass();

            Assert.AreEqual(string.Empty, handler.Message);

            try
            {
                publisher.RaiseTestModuleNotificationWithNullReferenceException2("some noty");
            }
            catch (NullReferenceException)
            {
                Assert.AreEqual("some noty", handler.Message);
                Assert.IsTrue(handler.Exception is NullReferenceException);
                Assert.AreEqual(true, handler.HasException);
                Assert.IsTrue(handler.Notification is TestModuleNotification);
            }
        }

        //[Test]
        //public void Test1()
        //{
        //    var handler = new EventHandlerClass();
        //    var publisher = new EventPublisherClass();

        //    publisher.RaiseBadError();

        //    Assert.AreEqual("Bad error here", handler.Message);
        //}
    }
}