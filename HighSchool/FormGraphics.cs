using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighSchool
{
    public partial class FormGraphics : Form
    {
        IService service;
        public FormGraphics()
        {
            InitializeComponent();
        }
        private void FormGraphics_Load(object sender, EventArgs e)
        {
            AllStudents();
        }
        void AllStudents()
        {
            service = new Service();
            var listTeacher = service.teacherList("sp_graphics_teacher_list");
            int teacherid = 0; string teacherGender; int teacherMale = 0;
            int teacherFemale = 0;
            for (int i = 0; i < listTeacher.Count; i++)
            {
                var allList = listTeacher[i];
                teacherid = teacherid + 1;
                teacherGender = allList.TeacherGender;
                if (teacherGender.ToString() == "Male")
                {
                    teacherMale++;
                }
                else if (teacherGender.ToString() == "Female")
                {
                    teacherFemale++;
                }
            }
            service = new Service();
            var list = service.graphicsList("sp_graphics_student_list");
            double midterm = 0; double div = 0; double avgMid = 0; double midtermSum = 0;
            double final = 0; double avgFin = 0; double finalSum = 0; int stndsA = 0;
            int stndsB = 0; int stndsC = 0; int stndsD = 0; string stndtsClass;
            double OverallGrade = 0; string gender; int studentMale = 0; int studentFemale = 0;
            for (int i = 0; i < list.Count; i++)
            {
                var allList = list[i];
                midterm = Convert.ToDouble(allList.Midterm);
                final = Convert.ToDouble(allList.Final);
                OverallGrade = Convert.ToDouble(allList.OverallGrade);
                gender = allList.Gender;
                stndtsClass = allList.Class;
                midtermSum += midterm;
                finalSum += final;
                div = div + 1;
                avgMid = midtermSum / div;
                avgFin = finalSum / div;
                avgMid = Math.Round(avgMid, 2);
                avgFin = Math.Round(avgFin, 2);
                if (stndtsClass == "9-A") { stndsA = stndsA + 1; }
                if (stndtsClass == "10-B") { stndsB = stndsB + 1; }
                if (stndtsClass == "11-C") { stndsC = stndsC + 1; }
                if (stndtsClass == "12-D") { stndsD = stndsD + 1; }
                if (gender.ToString() == "Male")
                {
                    studentMale++;
                }
                else if (gender.ToString() == "Female")
                {
                    studentFemale++;
                }

            }
            chartControl1.Series["9-A Students"].Points.AddPoint("9-A", stndsA);
            chartControl1.Series["10-B Students"].Points.AddPoint("10-B", stndsB);
            chartControl1.Series["11-C Students"].Points.AddPoint("11-C", stndsC);
            chartControl1.Series["12-D Students"].Points.AddPoint("12-D", stndsD);
            chartControl1.Series["Total Students"].Points.AddPoint("Total Students", div);
            chartControl2.Series["Male"].Points.AddPoint("All Classes", studentMale);
            chartControl2.Series["Female"].Points.AddPoint("All Classes", studentFemale);
            chartControl3.Series["Midterm"].Points.AddPoint("Midterm Average", avgMid);
            chartControl3.Series["Final"].Points.AddPoint("Final Average", avgFin);
            chartControl3.Series["Overall Grades"].Points.AddPoint("Overall Grades", OverallGrade);
            chartControl4.Series["Male"].Points.AddPoint("Male", teacherMale);
            chartControl4.Series["Female"].Points.AddPoint("Female", teacherFemale);
            chartControl4.Series["All Teachers"].Points.AddPoint("All Teachers", teacherid);


        }
    }
}
