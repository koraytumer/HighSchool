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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        FormStudentsA formStudentsA;
        FormStudentsB formStudentsB;
        FormStudentsC formStudentsC;
        FormStudentsD formStudentsD;
        FormTeachersMath formTeachersMath;
        FormPrincipal formPrincipal;
        FormGraphics formGraphics;

        public void btnClassA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formStudentsA == null)
            {
                formStudentsA = new FormStudentsA();
                formStudentsA.MdiParent = this;
                formStudentsA.Show();
            }
        }

        private void btnClassB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formStudentsB == null)
            {
                formStudentsB = new FormStudentsB();
                formStudentsB.MdiParent = this;
                formStudentsB.Show();
            }
        }

        private void btnClassC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formStudentsC == null)
            {
                formStudentsC = new FormStudentsC();
                formStudentsC.MdiParent = this;
                formStudentsC.Show();
            }
        }

        private void btnClassD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formStudentsD == null)
            {
                formStudentsD = new FormStudentsD();
                formStudentsD.MdiParent = this;
                formStudentsD.Show();
            }
        }

        private void btnTeacherMath_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formTeachersMath == null)
            {
                formTeachersMath = new FormTeachersMath();
                formTeachersMath.MdiParent = this;
                formTeachersMath.Show();
            }
        }

        private void btnPrincipalUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formPrincipal == null)
            {
                formPrincipal = new FormPrincipal();
                formPrincipal.MdiParent = this;
                formPrincipal.Show();
            }
        }

        private void btnPrincipalGraphics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formGraphics == null)
            {
                formGraphics = new FormGraphics();
                formGraphics.MdiParent = this;
                formGraphics.Show();
            }
        }
    }
}

