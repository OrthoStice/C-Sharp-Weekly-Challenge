using System;

namespace CodeLou.CSharp.Week3.Challenge
{
	public abstract class CalendarItemBase
	{
		public int Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Location { get; set; }
        public string[] Attendees { get; set; }
    }
}


// Task 2:
// Define Your Data
// Appointments need to be assigned a start date and time, an end date and time, and a location.
// Meetings need to be assigned a start date and time, an end date and time, a location, and attendees. You can decide what data you need for attendees.
// Reminders need to be assigned a start date and time.
// Hint: Use inheritance to make your life easier.