using HealthFirst.Core.Todo;
using NUnit.Framework;


namespace HealthFirst.Tests.Todo
{
    //Туду лист и туду элементы
    //Дата создания, дата завершения - не изменяемые
    //Название, описание, приоритет, статус - изменяемые  

    [TestFixture]
    internal class TodoTest
    {
        [SetUp]
        public void SetUp()
        { }

        [Test]
        public void CreateTodoItem()
        {
            var newItem = new TodoItem("Title", "Description", DateTime.Today, 
                DateTime.ParseExact("20240501T08:30:52Z", "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture));

            Assert.AreEqual(newItem.ToString(), 
                $"Title:Title Description:Description CreatedTime:{newItem.CreatedTime} DeadlineTime:{newItem.DeadlineTime} Status:{newItem.Status} Priority:{newItem.Priority}");
        }

        [Test]
        public void DeadlineEarlierThanCreationException()
        {
            var newItem = new TodoItem("Title", "discription", DateTime.Today,
                DateTime.ParseExact("20240501T08:30:52Z", "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture));

            Assert.Throws<ArgumentException>(() => newItem.DeadlineTime = DateTime.ParseExact("20230501T08:30:52Z", "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture));
        }

        [Test]
        public void ChangeStatus()
        {
            var newItem = new TodoItem("Title", "discription", DateTime.Today, 
                DateTime.ParseExact("20240501T08:30:52Z", "yyyyMMddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture));
            newItem.ChangeStatus(Status.InProgress, null);
            
            Assert.AreEqual (Status.InProgress, newItem.Status);
        }
    }
}
