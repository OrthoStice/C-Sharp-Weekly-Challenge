using System;

namespace CodeLou.CSharp.Week3.Challenge
{
	public class Meeting : CalendarItemBase
	{
        public DateTime EndDateTime { get; set; }
        public string Location { get; set; }
        public string[] Attendees { get; set; }
    }
}
