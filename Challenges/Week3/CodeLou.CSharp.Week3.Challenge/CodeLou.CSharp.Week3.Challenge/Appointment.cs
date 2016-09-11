using System;

namespace CodeLou.CSharp.Week3.Challenge
{
	public class Appointment : CalendarItemBase
	{
        public DateTime EndDateTime { get; set; }
        public string Location { get; set; }
    }
}
