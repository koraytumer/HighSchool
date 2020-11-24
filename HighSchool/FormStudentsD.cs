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
    public partial class FormStudentsD : Form
    {
        IService service;
        public FormStudentsD()
        {
            InitializeComponent();
        }
        void StudentsList()
        {
            service = new Service();
            var list = service.studentsList("sp_students_classD");
            gridControl1.DataSource = list;
        }
        private void FormStudentsD_Load(object sender, EventArgs e)
        {
            StudentsList();
        }
    }
}
