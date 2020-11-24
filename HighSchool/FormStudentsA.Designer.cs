namespace HighSchool
{
    partial class FormStudentsA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.spstudentsclassABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.highSchoolDataSet2 = new HighSchool.HighSchoolDataSet2();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStudentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStudentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStudentSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgcMidterm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgcFinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgcOverallGrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spogrenciclassAinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.highSchoolDataSet = new HighSchool.HighSchoolDataSet();
            this.sp_ogrenci_classA_infoTableAdapter = new HighSchool.HighSchoolDataSetTableAdapters.sp_ogrenci_classA_infoTableAdapter();
            this.highSchoolDataSet1 = new HighSchool.HighSchoolDataSet1();
            this.spstudentsclassABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_students_classATableAdapter = new HighSchool.HighSchoolDataSet1TableAdapters.sp_students_classATableAdapter();
            this.spogrenciclassAinfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.highSchoolDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_students_classATableAdapter1 = new HighSchool.HighSchoolDataSet2TableAdapters.sp_students_classATableAdapter();
            this.colMidterm = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spstudentsclassABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highSchoolDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spogrenciclassAinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highSchoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highSchoolDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spstudentsclassABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spogrenciclassAinfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highSchoolDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.spstudentsclassABindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // spstudentsclassABindingSource1
            // 
            this.spstudentsclassABindingSource1.DataMember = "sp_students_classA";
            this.spstudentsclassABindingSource1.DataSource = this.highSchoolDataSet2;
            // 
            // highSchoolDataSet2
            // 
            this.highSchoolDataSet2.DataSetName = "HighSchoolDataSet2";
            this.highSchoolDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStudentID,
            this.colStudentName,
            this.colStudentSurname,
            this.colGender,
            this.dgcMidterm,
            this.dgcFinal,
            this.dgcOverallGrade});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colStudentID
            // 
            this.colStudentID.FieldName = "StudentID";
            this.colStudentID.Name = "colStudentID";
            this.colStudentID.Visible = true;
            this.colStudentID.VisibleIndex = 0;
            // 
            // colStudentName
            // 
            this.colStudentName.FieldName = "StudentName";
            this.colStudentName.Name = "colStudentName";
            this.colStudentName.Visible = true;
            this.colStudentName.VisibleIndex = 1;
            // 
            // colStudentSurname
            // 
            this.colStudentSurname.FieldName = "StudentSurname";
            this.colStudentSurname.Name = "colStudentSurname";
            this.colStudentSurname.Visible = true;
            this.colStudentSurname.VisibleIndex = 2;
            // 
            // colGender
            // 
            this.colGender.FieldName = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 3;
            // 
            // dgcMidterm
            // 
            this.dgcMidterm.Caption = "Midterm";
            this.dgcMidterm.FieldName = "Midterm";
            this.dgcMidterm.Name = "dgcMidterm";
            this.dgcMidterm.Visible = true;
            this.dgcMidterm.VisibleIndex = 4;
            // 
            // dgcFinal
            // 
            this.dgcFinal.Caption = "Final";
            this.dgcFinal.FieldName = "Final";
            this.dgcFinal.Name = "dgcFinal";
            this.dgcFinal.Visible = true;
            this.dgcFinal.VisibleIndex = 5;
            // 
            // dgcOverallGrade
            // 
            this.dgcOverallGrade.Caption = "OverallGrade";
            this.dgcOverallGrade.FieldName = "OverallGrade";
            this.dgcOverallGrade.Name = "dgcOverallGrade";
            this.dgcOverallGrade.Visible = true;
            this.dgcOverallGrade.VisibleIndex = 6;
            // 
            // spogrenciclassAinfoBindingSource
            // 
            this.spogrenciclassAinfoBindingSource.DataMember = "sp_ogrenci_classA_info";
            this.spogrenciclassAinfoBindingSource.DataSource = this.highSchoolDataSet;
            // 
            // highSchoolDataSet
            // 
            this.highSchoolDataSet.DataSetName = "HighSchoolDataSet";
            this.highSchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_ogrenci_classA_infoTableAdapter
            // 
            this.sp_ogrenci_classA_infoTableAdapter.ClearBeforeFill = true;
            // 
            // highSchoolDataSet1
            // 
            this.highSchoolDataSet1.DataSetName = "HighSchoolDataSet1";
            this.highSchoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spstudentsclassABindingSource
            // 
            this.spstudentsclassABindingSource.DataMember = "sp_students_classA";
            this.spstudentsclassABindingSource.DataSource = this.highSchoolDataSet1;
            // 
            // sp_students_classATableAdapter
            // 
            this.sp_students_classATableAdapter.ClearBeforeFill = true;
            // 
            // spogrenciclassAinfoBindingSource1
            // 
            this.spogrenciclassAinfoBindingSource1.DataMember = "sp_ogrenci_classA_info";
            this.spogrenciclassAinfoBindingSource1.DataSource = this.highSchoolDataSet;
            // 
            // highSchoolDataSet1BindingSource
            // 
            this.highSchoolDataSet1BindingSource.DataSource = this.highSchoolDataSet1;
            this.highSchoolDataSet1BindingSource.Position = 0;
            // 
            // sp_students_classATableAdapter1
            // 
            this.sp_students_classATableAdapter1.ClearBeforeFill = true;
            // 
            // colMidterm
            // 
            this.colMidterm.Caption = "Midterm";
            this.colMidterm.FieldName = "Midterm";
            this.colMidterm.Name = "colMidterm";
            this.colMidterm.Visible = true;
            this.colMidterm.VisibleIndex = 4;
            // 
            // FormStudentsA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormStudentsA";
            this.Text = "9-A Students";
            this.Load += new System.EventHandler(this.FormStudentsA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spstudentsclassABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highSchoolDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spogrenciclassAinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highSchoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highSchoolDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spstudentsclassABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spogrenciclassAinfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highSchoolDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private HighSchoolDataSet highSchoolDataSet;
        private System.Windows.Forms.BindingSource spogrenciclassAinfoBindingSource;
        private HighSchoolDataSetTableAdapters.sp_ogrenci_classA_infoTableAdapter sp_ogrenci_classA_infoTableAdapter;
        private HighSchoolDataSet1 highSchoolDataSet1;
        private System.Windows.Forms.BindingSource spstudentsclassABindingSource;
        private HighSchoolDataSet1TableAdapters.sp_students_classATableAdapter sp_students_classATableAdapter;
        private System.Windows.Forms.BindingSource spogrenciclassAinfoBindingSource1;
        private System.Windows.Forms.BindingSource highSchoolDataSet1BindingSource;
        private HighSchoolDataSet2 highSchoolDataSet2;
        private System.Windows.Forms.BindingSource spstudentsclassABindingSource1;
        private HighSchoolDataSet2TableAdapters.sp_students_classATableAdapter sp_students_classATableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colStudentID;
        private DevExpress.XtraGrid.Columns.GridColumn colStudentName;
        private DevExpress.XtraGrid.Columns.GridColumn colStudentSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn dgcMidterm;
        private DevExpress.XtraGrid.Columns.GridColumn dgcFinal;
        private DevExpress.XtraGrid.Columns.GridColumn dgcOverallGrade;
        private DevExpress.XtraGrid.Columns.GridColumn colMidterm;
    }
}