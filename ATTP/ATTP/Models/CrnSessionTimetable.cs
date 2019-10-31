using System;
using System.Collections.Generic;

using System.Text;

namespace ATTP.Models
{
    public class CrnSessionTimetable
    {
        public string SubjectCode { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Crn { get; set; }

        public string Instructor { get; set; }

        public string Duration { get; set; }

        public string Room { get; set; }

        public string Building { get; set; }

        public string CampusCode { get; set; }

        public string roombuildinginfo { get; set; }

        public int DayCode { get; set; }

        public bool IsLast { get; set; } = false;


    }




}
