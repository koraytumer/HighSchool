using ServiceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighSchoolDAL;

namespace ServiceLayer
{
    public interface IService
    {
        int insert(string _sql);
        void delete(string _sql);
        void update(string _sql);
        List<StudentsDTO> studentsList(string _sql);
        List<GraphicsDTO> graphicsList(string _sql);
        List<PrincipalDTO> principalList(string _sql);
        List<TeachersDTO> teacherList(string _sql);

    }
}
