using NUnit.Framework;

namespace AssassinEventSystem.Tests
{
    [TestFixture]
    public class AssassinTest
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
    }
}