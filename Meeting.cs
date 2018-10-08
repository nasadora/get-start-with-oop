using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartWithOOP.Events
{
    class Meeting<THoster, TAttendee, TAssist>
        where THoster : class
        where TAttendee : HR.Employee
        where TAssist : TAttendee
    {
        public THoster Hoster;
        public List<TAttendee> Attendees;
        public TAssist Assistance;

        public void StrartMeeting()
        {
            
        }

        public void AddAttentee(TAttendee attendee)
        {
        }
    }
}
