using System;
using System.Collections.Generic;
using System.Text;

namespace ATTP.Models
{
    public class Course
    {

        //below needed to be modify
        public string SubjectCode { get; set; } //need to create another class called subject
        public string TafeCode { get; set; }
        public string NationalCode { get; set; }
        public string CompetencyName { get; set; }
        public string Grade { get; set; }
    }
}
