using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTO
{
    public class TeachersDTO
    {
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public string TeacherGender { get; set; }
        public string TeacherAdress { get; set; }
        public string RegisterDate { get; set; }
    }
}
