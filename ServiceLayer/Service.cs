using HighSchoolDAL;
using ServiceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class Service : IService
    {
        Connection connection = new Connection();
        Command cmd = new Command();

        public void delete(string _sql)
        {
            SqlCommand cmd1 = cmd.sqlCommand(_sql);
            cmd1.ExecuteNonQuery();
            connection.CloseConnection();
        }
        public int insert(string _sql)
        {
            SqlCommand cmd1 = cmd.sqlCommand(_sql);
            cmd1.ExecuteNonQuery();
            connection.CloseConnection();
            return 0;
        }
        public List<StudentsDTO> studentsList(string _sql)
        {
            List<StudentsDTO> stdntDto = new List<StudentsDTO>();
            try
            {
                SqlCommand cmd1 = cmd.sqlCommand(_sql);
                SqlDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    stdntDto.Add(new StudentsDTO
                    {
                        StudentID = Convert.ToInt32(dr["StudentID"].ToString()),
                        StudentName = dr["StudentName"].ToString(),
                        StudentSurname = dr["StudentSurname"].ToString(),
                        Gender = dr["Gender"].ToString(),
                        Midterm = (object)dr["Midterm"].ToString(),
                        Final = (object)(dr["Final"].ToString()),
                        OverallGrade = (object)(dr["OverallGrade"].ToString())
                    });
                }
            }
            catch (Exception)
            {
                connection.CloseConnection();
            }
            return stdntDto;
        }
        public List<GraphicsDTO> graphicsList(string _sql)
        {
            List<GraphicsDTO> grphcDTO = new List<GraphicsDTO>();
            SqlCommand cmd1 = cmd.sqlCommand(_sql);
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                grphcDTO.Add(new GraphicsDTO
                {
                    StudentID = Convert.ToInt32(dr["StudentID"].ToString()),
                    Midterm = (object)dr["Midterm"].ToString(),
                    Final = (object)dr["Final"].ToString(),
                    OverallGrade = (object)dr["OverallGrade"].ToString(),
                    Gender = dr["Gender"].ToString(),
                    Class = dr["Class"].ToString()
                });
            }
            connection.CloseConnection();
            return grphcDTO;
        }
        public List<PrincipalDTO> principalList(string _sql)
        {
            List<PrincipalDTO> prncplDTO = new List<PrincipalDTO>();
            SqlCommand cmd1 = cmd.sqlCommand(_sql);
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                prncplDTO.Add(new PrincipalDTO
                {
                    StudentID = Convert.ToInt32(dr["StudentID"].ToString()),
                    StudentName = dr["StudentName"].ToString(),
                    StudentSurname = dr["StudentSurname"].ToString(),
                    Gender = dr["Gender"].ToString(),
                    Class = dr["Class"].ToString(),
                    RegisterDate = dr["RegisterDate"].ToString(),
                    StudentAdress = dr["StudentAdress"].ToString(),
                });

            }
            connection.CloseConnection();
            return prncplDTO;
        }
        public List<TeachersDTO> teacherList(string _sql)
        {
            List<TeachersDTO> tchrDTO = new List<TeachersDTO>();
            SqlCommand cmd1 = cmd.sqlCommand(_sql);
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                tchrDTO.Add(new TeachersDTO
                {
                    TeacherID = Convert.ToInt32(dr["TeacherID"].ToString()),
                    TeacherName = dr["TeacherName"].ToString(),
                    TeacherSurname = dr["TeacherSurname"].ToString(),
                    TeacherAdress = dr["TeacherAdress"].ToString(),
                    TeacherGender = dr["TeacherGender"].ToString(),
                    RegisterDate = dr["RegisterDate"].ToString()
                });
            }
            connection.CloseConnection();
            return tchrDTO;
        }
        public void update(string _sql)
        {
            SqlCommand cmd1 = cmd.sqlCommand(_sql);
            cmd1.ExecuteNonQuery();
            connection.CloseConnection();
        }
    }
}
