using DevExpress.XtraGrid.Views.Grid;
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
    public partial class FormTeachersMath : Form
    {
        IService service;
        public FormTeachersMath()
        {
            InitializeComponent();
        }
        void StudentsList()
        {
            service = new Service();
            var list = service.studentsList("sp_ogrenci_info_grades_list");
            gridControl1.DataSource = list;
        }
        private void FormTeachersMath_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'highSchoolDataSet4.sp_ogrenci_info_grades_list' table. You can move, or remove it, as needed.
            this.sp_ogrenci_info_grades_listTableAdapter1.Fill(this.highSchoolDataSet4.sp_ogrenci_info_grades_list);
            //this.sp_ogrenci_info_grades_listTableAdapter.Fill(this.highSchoolDataSet3.sp_ogrenci_info_grades_list);
            StudentsList();
            GraphicsList();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            Clear();
        }
        public void Clear()
        {
            txStudentGender.Text = "";
            txStudentID.Text = "";
            txStudentName.Text = "";
            txStudentSurname.Text = "";
            txStudentMidterm.Text = "";
            txStudentFinal.Text = "";
            txOverallGrade.Text = "";
            cbClass.SelectedIndex = -1;
            pictureBox1.Image = null;
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            txStudentID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "StudentID").ToString();
            txStudentName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "StudentName").ToString();
            txStudentSurname.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "StudentSurname").ToString();
            txStudentGender.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Gender").ToString();
            txStudentMidterm.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Midterm").ToString();
            txStudentFinal.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Final").ToString();
            txOverallGrade.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "OverallGrade").ToString();
            if (txStudentGender.Text == "Male") { this.pictureBox1.Load("Male_Student_Uniform.png"); }
            else if (txStudentGender.Text == "Female") { this.pictureBox1.Load("Female_Student_Uniform.png"); }
            if (!String.IsNullOrEmpty(txStudentMidterm.Text) && !String.IsNullOrEmpty(txStudentFinal.Text))
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
            }
            else if (String.IsNullOrEmpty(txStudentMidterm.Text) && String.IsNullOrEmpty(txStudentFinal.Text))
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            service = new Service();
            if (!String.IsNullOrEmpty(txStudentMidterm.Text) && !String.IsNullOrEmpty(txStudentFinal.Text))
            {
                try
                {
                    double midterm1 = Convert.ToInt32(txStudentMidterm.Text);
                    double final1 = Convert.ToInt32(txStudentFinal.Text);
                    var avrg = ((midterm1 * 4) / 10 + (final1 * 6) / 10);

                    service.insert("insert into StudentsGrades values('" + Convert.ToInt32(txStudentID.Text) + "','" + (object)txStudentMidterm.Text + "','" + (object)txStudentFinal.Text + "','" + avrg.ToString() + "')");
                    Clear();
                    StudentsList();
                    MessageBox.Show("Added succesfully!");
                }
                catch (Exception)
                {
                    MessageBox.Show("There is no such student found!");

                }
            }
            else
            {
                MessageBox.Show("Please enter all textboxes!");

            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            service = new Service();
            if (!String.IsNullOrEmpty(txStudentID.Text) && (!String.IsNullOrEmpty(txStudentMidterm.Text)) && (!String.IsNullOrEmpty(txStudentFinal.Text)))
            {
                double midterm1 = Convert.ToInt32(txStudentMidterm.Text);
                double final1 = Convert.ToInt32(txStudentFinal.Text);
                var avrg = ((midterm1 * 4) / 10 + (final1 * 6) / 10);
                try
                {
                    service.update("UPDATE StudentsGrades SET Midterm ='" + txStudentMidterm.Text + "', Final ='" + txStudentFinal.Text + "', OverallGrade ='" + avrg.ToString() + "'WHERE StudentID ='" + txStudentID.Text + "'");
                    StudentsList();
                    Clear();
                    MessageBox.Show("Updated succesfully.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                MessageBox.Show("Please enter all textboxes!");
            }
        }
        void GraphicsList()
        {
            service = new Service();
            var list = service.graphicsList("sp_graphics_student_list");
            double midterm = 0; double div = 0; double avgMid = 0; double midtermSum = 0;
            double final = 0; double avgFin = 0; double finalSum = 0; int stndsA = 0;
            int stndsB = 0; int stndsC = 0; int stndsD = 0; string stndtsClass;
            double OverallGrade = 0;
            for (int i = 0; i < list.Count; i++)
            {
                var allList = list[i];
                midterm = Convert.ToDouble(allList.Midterm);
                final = Convert.ToDouble(allList.Final);
                OverallGrade = Convert.ToDouble(allList.OverallGrade);
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

            }
            chartControl1.Series["Midterm"].Points.AddPoint("Midterm Average", avgMid);
            chartControl1.Series["Final"].Points.AddPoint("Final Average", avgFin);
            chartControl1.Series["Overall Grades"].Points.AddPoint("Overall Grades", OverallGrade);
            chartControl2.Series["Total Students"].Points.AddPoint("Total Students", div);
            chartControl2.Series["9-A"].Points.AddPoint("9-A", stndsA);
            chartControl2.Series["10-B"].Points.AddPoint("10-B", stndsB);
            chartControl2.Series["11-C"].Points.AddPoint("11-C", stndsC);
            chartControl2.Series["12-D"].Points.AddPoint("12-D", stndsD);
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            service = new Service();
            if ((string)cbClass.SelectedItem == "9-A")
            {
                var list = service.studentsList("sp_ogrenci_info_grades_listA");
                gridControl1.DataSource = list;
            }
            else if ((string)cbClass.SelectedItem == "10-B")
            {
                var list = service.studentsList("sp_ogrenci_info_grades_listB");
                gridControl1.DataSource = list;
            }
            else if ((string)cbClass.SelectedItem == "11-C")
            {
                var list = service.studentsList("sp_ogrenci_info_grades_listC");
                gridControl1.DataSource = list;
            }
            else if ((string)cbClass.SelectedItem == "12-D")
            {
                var list = service.studentsList("sp_ogrenci_info_grades_listD");
                gridControl1.DataSource = list;
            }
            else if ((string)cbClass.SelectedItem == "List ALL")
            {
                var list = service.studentsList("sp_ogrenci_info_grades_list");
                gridControl1.DataSource = list;
            }
            else
            {
                cbClass.SelectedIndex = -1;
            }
        }
    }
}
