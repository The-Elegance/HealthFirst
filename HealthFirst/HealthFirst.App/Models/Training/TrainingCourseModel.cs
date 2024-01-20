using HealthFirst.Core.CalendarObject;
using HealthFirst.Core.Training;
using HealthFirst.Core.Training.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthFirst.App.Models.Training
{
    public class TrainingCourseModel : ITrainingCourse
    {


        public TrainingCourseModel()
        {

        }

        public uint Id { get => 0; }
        public ICollection<ITrainingWeek> TrainingWeeks { get; } = new ObservableCollection<ITrainingWeek>();
        public ITrainingCourseInfo PresentaionInfo { get; set; }
        public CalendarObjectRepeatInfo CalendarInfo { get; set; }
    }
}
