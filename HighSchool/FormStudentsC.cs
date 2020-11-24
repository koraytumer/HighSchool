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
    public partial class FormStudentsC : Form
    {
        IService service;
        public FormStudentsC()
        {
            InitializeComponent();
        }
        void StudentsList()
        {
            service = new Service();
            var list = service.studentsList("sp_students_classC");
            gridControl1.DataSource = list;
        }
        private void FormStudentsC_Load(object sender, EventArgs e)
        {
            StudentsList();
        }
    }
}



