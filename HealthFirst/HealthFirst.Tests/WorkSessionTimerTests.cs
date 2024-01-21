using HealthFirst.Core.Timer;
using NUnit.Framework;

namespace HealthFirst.Tests
{
    [TestFixture]
    internal class WorkSessionTimerTests
    {
        [SetUp]
        public void SetUp()
        { }

        [Test]
        public void TimerWillBeFinishedWithPausedAndResume()
        {
            var i = 0;
            var timer = new WorkSessionTimer(TimeSpan.FromSeconds(5));

            timer.Paused += (timerPausedData) =>
            {
                i++;
            };

            timer.Start();
            Thread.Sleep(2000);
            timer.Stop();

            timer.Start();
            Thread.Sleep(2000);
            timer.Stop();

            timer.Start();

            Assert.AreEqual(2, i);
        }

        [Test]
        public void TimerCanBePaused()
        {
            var timer = new WorkSessionTimer(TimeSpan.FromSeconds(3));

            timer.Start();
            Thread.Sleep((int)TimeSpan.FromSeconds(2).TotalMilliseconds);
            timer.Stop();

            timer.Paused += (timerPausedData) =>
            {
                Assert.AreEqual(1, timerPausedData.RemainingTime);
            };
        }

        [Test]
        public void TimerCanBeFinished()
        {
            var timer = new WorkSessionTimer(TimeSpan.FromSeconds(3));

            timer.Start();
            Thread.Sleep((int)TimeSpan.FromSeconds(2).TotalMilliseconds);
            timer.Stop();

            timer.Finished += () =>
            {
                Assert.AreEqual(true, true);
            };
        }
    }
}
