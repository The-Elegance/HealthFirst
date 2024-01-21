using HealthFirst.Core.CalendarObject;
using HealthFirst.Core.Training;
using HealthFirst.Core.Training.Builders;
using NUnit.Framework;

namespace HealthFirst.Tests
{
    [TestFixture]
    internal class TrainingCourseTests
    {
        [Test]
        public void CreateTrainingCourse()
        {
            var trainingCourseInfo = new TrainingCourseInfo("Home Training", "...", "...", null);
            var calendarRepeatInfo = new CalendarObjectRepeatInfo(
                CalendarObjectRepeat.Monthly,
                2,
                DateTime.Today,
                DateTime.Today,
                TimeZoneInfo.Utc);

            var traingingCourse = new TrainingCourse(0, trainingCourseInfo, calendarRepeatInfo, null);

            Assert.AreEqual(
                "TrainingCourse 0: Name: Home Training, Description: ..., Summary: ..., WeeksCount: 0",
                traingingCourse.ToString());
        }

        [Test]
        public void TestExerciesBuilder()
        {
            var presInfo = new ExericePresentationInfo("HomeTraining", "...", "...", 4, 4, TimeSpan.FromSeconds(60));
            var exercisesBuilder = new ExercisesBuilder(0);

            var exericies = exercisesBuilder
             .AddEmptySets(4)
             .AddPresentationInfo(presInfo)
             .Build();

            Assert.AreEqual("", exericies.ToString());
        }
    }
}
