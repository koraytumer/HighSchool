using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using ServiceLayer;
using ServiceLayer.DTO;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.BandedGrid;

namespace HighSchool
{
    public partial class FormStudentsA : Form
    {
        IService service;
        public FormStudentsA()
        {
            InitializeComponent();
        }
        void StudentsList()
        {
            service = new Service();
            var list = service.studentsList("sp_students_classA");
            gridControl1.DataSource = list;
        } 
        private void FormStudentsA_Load(object sender, EventArgs e)
        {

            this.sp_ogrenci_classA_infoTableAdapter.Fill(this.highSchoolDataSet.sp_ogrenci_classA_info);
            StudentsList();
        }

        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        { 
            GridView view = sender as GridView;
            if (view == null) return;
            if (e.Column.FieldName != "Midterm" && e.Column.FieldName != "Final") return; 
            if (!String.IsNullOrEmpty(view.GetRowCellValue(e.RowHandle, "Midterm").ToString()) && !String.IsNullOrEmpty(view.GetRowCellValue(e.RowHandle, "Final").ToString()))
            {
                int total = (Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "Midterm").ToString())) * (Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "Final").ToString()));
                view.SetRowCellValue(e.RowHandle, "OverallGrade", total);
            }
        } 
    }
}
