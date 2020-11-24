using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTO
{
    public class PrincipalDTO
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string Gender { get; set; }
        public string Class { get; set; }
        public string StudentAdress { get; set; }
        public string RegisterDate { get; set; }
    }
}

