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
    public partial class FormPrincipal : Form
    {
        IService service;
        public FormPrincipal()
        {
            InitializeComponent();
            pictureBox1.Image = null;
        }
        void StudentsList()
        {
            service = new Service();
            var list = service.principalList("sp_ogrenci_info_princial_listALL");
            gridControl1.DataSource = list;
        }
        void TeacherList()
        {
            service = new Service();
            var list = service.teacherList("sp_teachers_info");
            gridControl2.DataSource = list;
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            StudentsList();
            TeacherList();
        }
        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            service = new Service();
            if ((string)cbClass.SelectedItem == "9-A")
            {
                var list = service.principalList("sp_ogrenci_info_princial_listA");
                gridControl1.DataSource = list;
            }
            else if ((string)cbClass.SelectedItem == "10-B")
            {
                var list = service.principalList("sp_ogrenci_info_princial_listB");
                gridControl1.DataSource = list;
            }
            else if ((string)cbClass.SelectedItem == "11-C")
            {
                var list = service.principalList("sp_ogrenci_info_princial_listC");
                gridControl1.DataSource = list;
            }
            else if ((string)cbClass.SelectedItem == "12-D")
            {
                var list = service.principalList("sp_ogrenci_info_princial_listD");
                gridControl1.DataSource = list;
            }
            else if ((string)cbClass.SelectedItem == "List ALL")
            {
                var list = service.principalList("sp_ogrenci_info_princial_listALL");
                gridControl1.DataSource = list;
            }
            else
            {
                cbClass.SelectedIndex = -1;
            }
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            btnStudentAdd.Enabled = false;
            txStudentID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "StudentID").ToString();
            txStudentName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "StudentName").ToString();
            txStudentSurname.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "StudentSurname").ToString();
            cbStudentGender.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Gender").ToString();
            cbStudentClass.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Class").ToString();
            txStudentAdress.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "StudentAdress").ToString();
            if ((string)cbStudentGender.SelectedItem == "Male") { this.pictureBox1.Load("Male_Student_Uniform.png"); }
            else if ((string)cbStudentGender.SelectedItem == "Female") { this.pictureBox1.Load("Female_Student_Uniform.png"); }
        }
        public void ClearStudent()
        {
            txStudentID.Text = "";
            txStudentName.Text = "";
            txStudentSurname.Text = "";
            cbStudentGender.SelectedIndex = -1;
            cbStudentClass.SelectedIndex = -1;
            txStudentAdress.Text = "";
            pictureBox1.Image = null;
            cbClass.SelectedIndex = -1;
        }
        public void ClearTeacher()
        {
            txTeacherID.Text = "";
            txTeacherName.Text = "";
            txTeacherSurname.Text = "";
            cbTeacherGender.SelectedIndex = -1;
            txTeacherAdress.Text = "";
            pictureBox2.Image = null;
            btnTeacherAdd.Enabled = true;
        }

        private void btnStudentClear_Click(object sender, EventArgs e)
        {
            btnStudentAdd.Enabled = true;
            ClearStudent();
        }
        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txStudentID.Text))
            {
                try
                {
                    service = new Service();
                    service.delete("delete from StudentsInfo where StudentID ='" + txStudentID.Text + "'");
                    StudentsList();
                    ClearStudent();
                    MessageBox.Show("Deleted succesfully.");
                }

                catch (Exception)
                {
                    MessageBox.Show("Error.");
                }
            }
            else
            {
                MessageBox.Show("Error.");
            }
        }
        private void btnStudentUpdate_Click(object sender, EventArgs e)
        {
            service = new Service();
            var cbstudentgender = cbStudentGender.SelectedItem.ToString();
            var cbstudentclass = cbStudentClass.SelectedItem.ToString();

            if (!String.IsNullOrEmpty(txStudentID.Text) && !String.IsNullOrEmpty(txStudentName.Text) && !String.IsNullOrEmpty(txStudentSurname.Text) && !String.IsNullOrEmpty(cbStudentClass.Text) && !String.IsNullOrEmpty(cbStudentGender.Text) && !String.IsNullOrEmpty(txStudentAdress.Text))
            {
                try
                {
                    service.update("UPDATE StudentsInfo SET StudentName ='" + txStudentName.Text + "', StudentSurname ='" + txStudentSurname.Text + "', Gender ='" + cbstudentgender.ToString() + "', Class ='" + cbstudentclass.ToString() + "', StudentAdress ='" + txStudentAdress.Text + "' WHERE StudentID ='" + txStudentID.Text + "'");
                    StudentsList();
                    ClearStudent();
                    MessageBox.Show("Updated succesfully.");
                }

                catch (Exception)
                {
                    MessageBox.Show("Error.");
                }
            }
            else
            {
                MessageBox.Show("Please enter all textboxes.");
            }
        }
        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            service = new Service();
            if (!String.IsNullOrEmpty(txStudentName.Text) && !String.IsNullOrEmpty(txStudentSurname.Text) && !String.IsNullOrEmpty(cbStudentGender.ToString()) && !String.IsNullOrEmpty(txStudentAdress.Text) && !String.IsNullOrEmpty(cbStudentClass.ToString()))
            {
                var cbstudentgender = cbStudentGender.SelectedItem.ToString();
                var cbstudentclass = cbStudentClass.SelectedItem.ToString();
                try
                {
                    service.insert(" INSERT INTO StudentsInfo VALUES('" + txStudentName.Text + "','" + txStudentSurname.Text + "','" + cbstudentgender.ToString() + "','" + txStudentAdress.Text + "',GETDATE(),'" + cbstudentclass.ToString() + "')");
                    StudentsList();
                    ClearStudent();
                    MessageBox.Show("Added succesfully!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");

                }
            }
            else
            {
                MessageBox.Show("Please enter all student boxes!");
            }
        }
        private void gridView2_Click(object sender, EventArgs e)
        {
            btnTeacherAdd.Enabled = false;
            txTeacherID.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TeacherID").ToString();
            txTeacherName.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TeacherName").ToString();
            txTeacherSurname.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TeacherSurname").ToString();
            cbTeacherGender.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TeacherGender").ToString();
            txTeacherAdress.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TeacherAdress").ToString();
            if ((string)cbTeacherGender.SelectedItem == "Male") { this.pictureBox2.Load("Male_Student_Uniform.png"); }
            else if ((string)cbTeacherGender.SelectedItem == "Female") { this.pictureBox2.Load("Female_Student_Uniform.png"); }
        }
        private void btnTeacherClear_Click(object sender, EventArgs e)
        {
            ClearTeacher();
        }
        private void btnTeacherAdd_Click(object sender, EventArgs e)
        {
            service = new Service();

            if (!String.IsNullOrEmpty(txTeacherName.Text) && !String.IsNullOrEmpty(txTeacherSurname.Text) && !String.IsNullOrEmpty(cbTeacherGender.ToString()) && !String.IsNullOrEmpty(txTeacherAdress.Text))
            {
                var cbteacherGender = cbTeacherGender.SelectedItem.ToString();
                try
                {
                    service.insert("INSERT INTO TeachersInfo (TeacherName,TeacherSurname,TeacherGender,TeacherAdress) VALUES('" + txTeacherName.Text + "','" + txTeacherSurname.Text + "','" + cbteacherGender.ToString() + "','" + txTeacherAdress.Text + "')");

                    TeacherList();
                    ClearTeacher();
                    MessageBox.Show("Added succesfully!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");

                }
            }
            else
            {
                MessageBox.Show("Please enter all student boxes!");
            }
        }
        private void btnTeacherUpdate_Click(object sender, EventArgs e)
        {
            service = new Service();
            var cbteacherGender = cbTeacherGender.SelectedItem.ToString();
            if (!String.IsNullOrEmpty(txTeacherID.Text) && !String.IsNullOrEmpty(txTeacherName.Text) && !String.IsNullOrEmpty(txTeacherSurname.Text) && !String.IsNullOrEmpty(cbTeacherGender.Text) && !String.IsNullOrEmpty(txTeacherAdress.Text))
            {
                try
                {
                    service.update("UPDATE TeachersInfo SET TeacherName ='" + txTeacherName.Text + "', TeacherSurname='" + txTeacherSurname.Text + "', TeacherGender='" + cbteacherGender.ToString() + "',TeacherAdress='" + txTeacherAdress.Text + "' WHERE TeacherID ='" + txTeacherID.Text + "'");
                    TeacherList();
                    ClearTeacher();
                    MessageBox.Show("Updated succesfully.");
                }

                catch (Exception)
                {
                    MessageBox.Show("Error.");
                }
            }
            else
            {
                MessageBox.Show("Please enter all textboxes.");
            }
        }
        private void btnTeacherDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txTeacherID.Text))
            {
                try
                {
                    service = new Service();
                    service.delete("delete from TeachersInfo where TeacherID ='" + txTeacherID.Text + "'");
                    TeacherList();
                    ClearTeacher();
                    MessageBox.Show("Deleted succesfully.");
                }

                catch (Exception)
                {
                    MessageBox.Show("Error.");
                }
            }
            else
            {
                MessageBox.Show("Error.");
            }

        }
    }
}


