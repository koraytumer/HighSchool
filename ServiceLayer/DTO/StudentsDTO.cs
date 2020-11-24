using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTO
{
    public class StudentsDTO
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string Gender { get; set; }
        public object Midterm { get; set; }
        public object Final { get; set; }
        public object OverallGrade { get; set; }
    }
}
