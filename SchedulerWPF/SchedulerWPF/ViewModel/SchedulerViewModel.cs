using Syncfusion.UI.Xaml.Scheduler;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SchedulerWPF
{
    /// <summary>
    /// Month cell customization View Model class.
    /// </summary>
    public class SchedulerViewModel : INotifyPropertyChanged
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerViewModel" /> class
        /// </summary>
        public SchedulerViewModel()
        {
            this.AddAppointments();
        }

        #endregion Constructor

        #region Public Properties

        /// <summary>
        /// Property changed event handler.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets appointments
        /// </summary>
        public ScheduleAppointmentCollection Appointments { get; set; }

        #endregion

        #region Property Changed Event

        /// <summary>
        /// Invoke method when property changed
        /// </summary>
        /// <param name="propertyName">property name</param>
        private void RaiseOnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Methods
        /// <summary>
        /// Adding appointments
        /// </summary>
        private void AddAppointments()
        {
            var exceptionDate = new DateTime(2021, 06, 09);
            this.Appointments = new ScheduleAppointmentCollection();

            var newEvent = new ScheduleAppointment();
            newEvent.Subject = "Meeting";
            newEvent.StartTime = new DateTime(2021, 06, 2, 10, 0, 0);
            newEvent.EndTime = new DateTime(2021, 06, 2, 11, 0, 0);
            newEvent.RecurrenceRule = "FREQ=DAILY;INTERVAL=1;COUNT=10";
            newEvent.RecurrenceExceptionDates = new ObservableCollection<DateTime>() { exceptionDate };
            newEvent.AppointmentBackground = Brushes.Green;

            this.Appointments.Add(newEvent);
        }
        #endregion
    }
}
