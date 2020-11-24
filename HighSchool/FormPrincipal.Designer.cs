namespace HighSchool
{
    partial class FormPrincipal
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
            this.gcStudent = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStudentClear = new System.Windows.Forms.Button();
            this.txStudentID = new System.Windows.Forms.TextBox();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.cbStudentClass = new System.Windows.Forms.ComboBox();
            this.cbStudentGender = new System.Windows.Forms.ComboBox();
            this.btnStudentDelete = new System.Windows.Forms.Button();
            this.btnStudentUpdate = new System.Windows.Forms.Button();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.txStudentSurname = new System.Windows.Forms.TextBox();
            this.txStudentName = new System.Windows.Forms.TextBox();
            this.lbStudentAdress = new System.Windows.Forms.Label();
            this.lbStudentGender = new System.Windows.Forms.Label();
            this.lbStudentClass = new System.Windows.Forms.Label();
            this.lbStudentSurname = new System.Windows.Forms.Label();
            this.lbStudentName = new System.Windows.Forms.Label();
            this.txStudentAdress = new DevExpress.XtraEditors.MemoEdit();
            this.gcTeacher = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnTeacherDelete = new System.Windows.Forms.Button();
            this.btnTeacherUpdate = new System.Windows.Forms.Button();
            this.btnTeacherClear = new System.Windows.Forms.Button();
            this.txTeacherID = new System.Windows.Forms.TextBox();
            this.lbTeacherID = new System.Windows.Forms.Label();
            this.cbTeacherGender = new System.Windows.Forms.ComboBox();
            this.btnTeacherAdd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txTeacherAdress = new DevExpress.XtraEditors.MemoEdit();
            this.txTeacherSurname = new System.Windows.Forms.TextBox();
            this.txTeacherName = new System.Windows.Forms.TextBox();
            this.lbTeacherName = new System.Windows.Forms.Label();
            this.lbTeacherSurname = new System.Windows.Forms.Label();
            this.lbTeacherGender = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudent)).BeginInit();
            this.gcStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txStudentAdress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTeacher)).BeginInit();
            this.gcTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txTeacherAdress.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gcStudent
            // 
            this.gcStudent.Controls.Add(this.pictureBox1);
            this.gcStudent.Controls.Add(this.btnStudentClear);
            this.gcStudent.Controls.Add(this.txStudentID);
            this.gcStudent.Controls.Add(this.lbStudentID);
            this.gcStudent.Controls.Add(this.cbStudentClass);
            this.gcStudent.Controls.Add(this.cbStudentGender);
            this.gcStudent.Controls.Add(this.btnStudentDelete);
            this.gcStudent.Controls.Add(this.btnStudentUpdate);
            this.gcStudent.Controls.Add(this.btnStudentAdd);
            this.gcStudent.Controls.Add(this.label12);
            this.gcStudent.Controls.Add(this.label5);
            this.gcStudent.Controls.Add(this.label4);
            this.gcStudent.Controls.Add(this.label3);
            this.gcStudent.Controls.Add(this.lbError);
            this.gcStudent.Controls.Add(this.txStudentSurname);
            this.gcStudent.Controls.Add(this.txStudentName);
            this.gcStudent.Controls.Add(this.lbStudentAdress);
            this.gcStudent.Controls.Add(this.lbStudentGender);
            this.gcStudent.Controls.Add(this.lbStudentClass);
            this.gcStudent.Controls.Add(this.lbStudentSurname);
            this.gcStudent.Controls.Add(this.lbStudentName);
            this.gcStudent.Controls.Add(this.txStudentAdress);
            this.gcStudent.Location = new System.Drawing.Point(311, 31);
            this.gcStudent.Name = "gcStudent";
            this.gcStudent.Size = new System.Drawing.Size(380, 383);
            this.gcStudent.TabIndex = 1;
            this.gcStudent.Text = "Add Student";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnStudentClear
            // 
            this.btnStudentClear.Location = new System.Drawing.Point(299, 232);
            this.btnStudentClear.Name = "btnStudentClear";
            this.btnStudentClear.Size = new System.Drawing.Size(75, 23);
            this.btnStudentClear.TabIndex = 24;
            this.btnStudentClear.Text = "Clear";
            this.btnStudentClear.UseVisualStyleBackColor = true;
            this.btnStudentClear.Click += new System.EventHandler(this.btnStudentClear_Click);
            // 
            // txStudentID
            // 
            this.txStudentID.Enabled = false;
            this.txStudentID.Location = new System.Drawing.Point(255, 38);
            this.txStudentID.Name = "txStudentID";
            this.txStudentID.Size = new System.Drawing.Size(100, 21);
            this.txStudentID.TabIndex = 23;
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Location = new System.Drawing.Point(185, 38);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(59, 13);
            this.lbStudentID.TabIndex = 22;
            this.lbStudentID.Text = "Student ID";
            // 
            // cbStudentClass
            // 
            this.cbStudentClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudentClass.FormattingEnabled = true;
            this.cbStudentClass.Items.AddRange(new object[] {
            "9-A",
            "10-B",
            "11-C",
            "12-D"});
            this.cbStudentClass.Location = new System.Drawing.Point(255, 148);
            this.cbStudentClass.Name = "cbStudentClass";
            this.cbStudentClass.Size = new System.Drawing.Size(100, 21);
            this.cbStudentClass.TabIndex = 13;
            // 
            // cbStudentGender
            // 
            this.cbStudentGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudentGender.FormattingEnabled = true;
            this.cbStudentGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbStudentGender.Location = new System.Drawing.Point(255, 186);
            this.cbStudentGender.Name = "cbStudentGender";
            this.cbStudentGender.Size = new System.Drawing.Size(100, 21);
            this.cbStudentGender.TabIndex = 4;
            // 
            // btnStudentDelete
            // 
            this.btnStudentDelete.Location = new System.Drawing.Point(170, 232);
            this.btnStudentDelete.Name = "btnStudentDelete";
            this.btnStudentDelete.Size = new System.Drawing.Size(75, 23);
            this.btnStudentDelete.TabIndex = 21;
            this.btnStudentDelete.Text = "Delete";
            this.btnStudentDelete.UseVisualStyleBackColor = true;
            this.btnStudentDelete.Click += new System.EventHandler(this.btnStudentDelete_Click);
            // 
            // btnStudentUpdate
            // 
            this.btnStudentUpdate.Location = new System.Drawing.Point(89, 232);
            this.btnStudentUpdate.Name = "btnStudentUpdate";
            this.btnStudentUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnStudentUpdate.TabIndex = 20;
            this.btnStudentUpdate.Text = "Update";
            this.btnStudentUpdate.UseVisualStyleBackColor = true;
            this.btnStudentUpdate.Click += new System.EventHandler(this.btnStudentUpdate_Click);
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.Location = new System.Drawing.Point(8, 232);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(75, 23);
            this.btnStudentAdd.TabIndex = 19;
            this.btnStudentAdd.Text = "Add";
            this.btnStudentAdd.UseVisualStyleBackColor = true;
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(361, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(361, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(361, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(361, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "*";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(361, 151);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(13, 13);
            this.lbError.TabIndex = 13;
            this.lbError.Text = "*";
            // 
            // txStudentSurname
            // 
            this.txStudentSurname.Location = new System.Drawing.Point(255, 113);
            this.txStudentSurname.Name = "txStudentSurname";
            this.txStudentSurname.Size = new System.Drawing.Size(100, 21);
            this.txStudentSurname.TabIndex = 10;
            // 
            // txStudentName
            // 
            this.txStudentName.Location = new System.Drawing.Point(255, 78);
            this.txStudentName.Name = "txStudentName";
            this.txStudentName.Size = new System.Drawing.Size(100, 21);
            this.txStudentName.TabIndex = 9;
            // 
            // lbStudentAdress
            // 
            this.lbStudentAdress.AutoSize = true;
            this.lbStudentAdress.Location = new System.Drawing.Point(5, 262);
            this.lbStudentAdress.Name = "lbStudentAdress";
            this.lbStudentAdress.Size = new System.Drawing.Size(40, 13);
            this.lbStudentAdress.TabIndex = 6;
            this.lbStudentAdress.Text = "Adress";
            // 
            // lbStudentGender
            // 
            this.lbStudentGender.AutoSize = true;
            this.lbStudentGender.Location = new System.Drawing.Point(185, 189);
            this.lbStudentGender.Name = "lbStudentGender";
            this.lbStudentGender.Size = new System.Drawing.Size(42, 13);
            this.lbStudentGender.TabIndex = 5;
            this.lbStudentGender.Text = "Gender";
            // 
            // lbStudentClass
            // 
            this.lbStudentClass.AutoSize = true;
            this.lbStudentClass.Location = new System.Drawing.Point(185, 151);
            this.lbStudentClass.Name = "lbStudentClass";
            this.lbStudentClass.Size = new System.Drawing.Size(32, 13);
            this.lbStudentClass.TabIndex = 4;
            this.lbStudentClass.Text = "Class";
            // 
            // lbStudentSurname
            // 
            this.lbStudentSurname.AutoSize = true;
            this.lbStudentSurname.Location = new System.Drawing.Point(185, 113);
            this.lbStudentSurname.Name = "lbStudentSurname";
            this.lbStudentSurname.Size = new System.Drawing.Size(49, 13);
            this.lbStudentSurname.TabIndex = 3;
            this.lbStudentSurname.Text = "Surname";
            // 
            // lbStudentName
            // 
            this.lbStudentName.AutoSize = true;
            this.lbStudentName.Location = new System.Drawing.Point(185, 78);
            this.lbStudentName.Name = "lbStudentName";
            this.lbStudentName.Size = new System.Drawing.Size(34, 13);
            this.lbStudentName.TabIndex = 2;
            this.lbStudentName.Text = "Name";
            // 
            // txStudentAdress
            // 
            this.txStudentAdress.EditValue = "";
            this.txStudentAdress.Location = new System.Drawing.Point(8, 278);
            this.txStudentAdress.Name = "txStudentAdress";
            this.txStudentAdress.Size = new System.Drawing.Size(347, 96);
            this.txStudentAdress.TabIndex = 7;
            // 
            // gcTeacher
            // 
            this.gcTeacher.Controls.Add(this.pictureBox2);
            this.gcTeacher.Controls.Add(this.btnTeacherDelete);
            this.gcTeacher.Controls.Add(this.btnTeacherUpdate);
            this.gcTeacher.Controls.Add(this.btnTeacherClear);
            this.gcTeacher.Controls.Add(this.txTeacherID);
            this.gcTeacher.Controls.Add(this.lbTeacherID);
            this.gcTeacher.Controls.Add(this.cbTeacherGender);
            this.gcTeacher.Controls.Add(this.btnTeacherAdd);
            this.gcTeacher.Controls.Add(this.label13);
            this.gcTeacher.Controls.Add(this.label11);
            this.gcTeacher.Controls.Add(this.label8);
            this.gcTeacher.Controls.Add(this.label7);
            this.gcTeacher.Controls.Add(this.label1);
            this.gcTeacher.Controls.Add(this.txTeacherAdress);
            this.gcTeacher.Controls.Add(this.txTeacherSurname);
            this.gcTeacher.Controls.Add(this.txTeacherName);
            this.gcTeacher.Controls.Add(this.lbTeacherName);
            this.gcTeacher.Controls.Add(this.lbTeacherSurname);
            this.gcTeacher.Controls.Add(this.lbTeacherGender);
            this.gcTeacher.Location = new System.Drawing.Point(311, 420);
            this.gcTeacher.Name = "gcTeacher";
            this.gcTeacher.Size = new System.Drawing.Size(380, 381);
            this.gcTeacher.TabIndex = 2;
            this.gcTeacher.Text = "Add Teacher";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(8, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // btnTeacherDelete
            // 
            this.btnTeacherDelete.Location = new System.Drawing.Point(176, 232);
            this.btnTeacherDelete.Name = "btnTeacherDelete";
            this.btnTeacherDelete.Size = new System.Drawing.Size(75, 23);
            this.btnTeacherDelete.TabIndex = 30;
            this.btnTeacherDelete.Text = "Delete";
            this.btnTeacherDelete.UseVisualStyleBackColor = true;
            this.btnTeacherDelete.Click += new System.EventHandler(this.btnTeacherDelete_Click);
            // 
            // btnTeacherUpdate
            // 
            this.btnTeacherUpdate.Location = new System.Drawing.Point(95, 232);
            this.btnTeacherUpdate.Name = "btnTeacherUpdate";
            this.btnTeacherUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnTeacherUpdate.TabIndex = 29;
            this.btnTeacherUpdate.Text = "Update";
            this.btnTeacherUpdate.UseVisualStyleBackColor = true;
            this.btnTeacherUpdate.Click += new System.EventHandler(this.btnTeacherUpdate_Click);
            // 
            // btnTeacherClear
            // 
            this.btnTeacherClear.Location = new System.Drawing.Point(299, 232);
            this.btnTeacherClear.Name = "btnTeacherClear";
            this.btnTeacherClear.Size = new System.Drawing.Size(75, 23);
            this.btnTeacherClear.TabIndex = 28;
            this.btnTeacherClear.Text = "Clear";
            this.btnTeacherClear.UseVisualStyleBackColor = true;
            this.btnTeacherClear.Click += new System.EventHandler(this.btnTeacherClear_Click);
            // 
            // txTeacherID
            // 
            this.txTeacherID.Enabled = false;
            this.txTeacherID.Location = new System.Drawing.Point(260, 35);
            this.txTeacherID.Name = "txTeacherID";
            this.txTeacherID.Size = new System.Drawing.Size(100, 21);
            this.txTeacherID.TabIndex = 18;
            // 
            // lbTeacherID
            // 
            this.lbTeacherID.AutoSize = true;
            this.lbTeacherID.Location = new System.Drawing.Point(183, 35);
            this.lbTeacherID.Name = "lbTeacherID";
            this.lbTeacherID.Size = new System.Drawing.Size(60, 13);
            this.lbTeacherID.TabIndex = 13;
            this.lbTeacherID.Text = "Teacher ID";
            // 
            // cbTeacherGender
            // 
            this.cbTeacherGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeacherGender.FormattingEnabled = true;
            this.cbTeacherGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbTeacherGender.Location = new System.Drawing.Point(260, 151);
            this.cbTeacherGender.Name = "cbTeacherGender";
            this.cbTeacherGender.Size = new System.Drawing.Size(100, 21);
            this.cbTeacherGender.TabIndex = 27;
            // 
            // btnTeacherAdd
            // 
            this.btnTeacherAdd.Location = new System.Drawing.Point(8, 232);
            this.btnTeacherAdd.Name = "btnTeacherAdd";
            this.btnTeacherAdd.Size = new System.Drawing.Size(75, 23);
            this.btnTeacherAdd.TabIndex = 20;
            this.btnTeacherAdd.Text = "Add";
            this.btnTeacherAdd.UseVisualStyleBackColor = true;
            this.btnTeacherAdd.Click += new System.EventHandler(this.btnTeacherAdd_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(362, 278);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(362, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(362, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(362, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Adress";
            // 
            // txTeacherAdress
            // 
            this.txTeacherAdress.EditValue = "";
            this.txTeacherAdress.Location = new System.Drawing.Point(8, 276);
            this.txTeacherAdress.Name = "txTeacherAdress";
            this.txTeacherAdress.Size = new System.Drawing.Size(352, 96);
            this.txTeacherAdress.TabIndex = 14;
            // 
            // txTeacherSurname
            // 
            this.txTeacherSurname.Location = new System.Drawing.Point(260, 112);
            this.txTeacherSurname.Name = "txTeacherSurname";
            this.txTeacherSurname.Size = new System.Drawing.Size(100, 21);
            this.txTeacherSurname.TabIndex = 20;
            // 
            // txTeacherName
            // 
            this.txTeacherName.Location = new System.Drawing.Point(260, 73);
            this.txTeacherName.Name = "txTeacherName";
            this.txTeacherName.Size = new System.Drawing.Size(100, 21);
            this.txTeacherName.TabIndex = 19;
            // 
            // lbTeacherName
            // 
            this.lbTeacherName.AutoSize = true;
            this.lbTeacherName.Location = new System.Drawing.Point(183, 73);
            this.lbTeacherName.Name = "lbTeacherName";
            this.lbTeacherName.Size = new System.Drawing.Size(34, 13);
            this.lbTeacherName.TabIndex = 14;
            this.lbTeacherName.Text = "Name";
            // 
            // lbTeacherSurname
            // 
            this.lbTeacherSurname.AutoSize = true;
            this.lbTeacherSurname.Location = new System.Drawing.Point(183, 112);
            this.lbTeacherSurname.Name = "lbTeacherSurname";
            this.lbTeacherSurname.Size = new System.Drawing.Size(49, 13);
            this.lbTeacherSurname.TabIndex = 15;
            this.lbTeacherSurname.Text = "Surname";
            // 
            // lbTeacherGender
            // 
            this.lbTeacherGender.AutoSize = true;
            this.lbTeacherGender.Location = new System.Drawing.Point(183, 157);
            this.lbTeacherGender.Name = "lbTeacherGender";
            this.lbTeacherGender.Size = new System.Drawing.Size(42, 13);
            this.lbTeacherGender.TabIndex = 17;
            this.lbTeacherGender.Text = "Gender";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbClass);
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Location = new System.Drawing.Point(719, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 383);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a class";
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Items.AddRange(new object[] {
            "List ALL",
            "9-A",
            "10-B",
            "11-C",
            "12-D"});
            this.cbClass.Location = new System.Drawing.Point(17, 19);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(121, 21);
            this.cbClass.TabIndex = 16;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.AccessibleName = "";
            this.gridControl1.Location = new System.Drawing.Point(17, 54);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(757, 310);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridControl2);
            this.groupBox2.Location = new System.Drawing.Point(719, 420);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(792, 381);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teachers List";
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(17, 25);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(757, 347);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.Tag = "gcTeacher";
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.Click += new System.EventHandler(this.gridView2_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 820);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcTeacher);
            this.Controls.Add(this.gcStudent);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcStudent)).EndInit();
            this.gcStudent.ResumeLayout(false);
            this.gcStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txStudentAdress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTeacher)).EndInit();
            this.gcTeacher.ResumeLayout(false);
            this.gcTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txTeacherAdress.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcStudent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStudentClear;
        private System.Windows.Forms.TextBox txStudentID;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.ComboBox cbStudentClass;
        private System.Windows.Forms.ComboBox cbStudentGender;
        private System.Windows.Forms.Button btnStudentDelete;
        private System.Windows.Forms.Button btnStudentUpdate;
        private System.Windows.Forms.Button btnStudentAdd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.TextBox txStudentSurname;
        private System.Windows.Forms.TextBox txStudentName;
        private System.Windows.Forms.Label lbStudentAdress;
        private System.Windows.Forms.Label lbStudentGender;
        private System.Windows.Forms.Label lbStudentClass;
        private System.Windows.Forms.Label lbStudentSurname;
        private System.Windows.Forms.Label lbStudentName;
        private DevExpress.XtraEditors.MemoEdit txStudentAdress;
        private DevExpress.XtraEditors.GroupControl gcTeacher;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnTeacherDelete;
        private System.Windows.Forms.Button btnTeacherUpdate;
        private System.Windows.Forms.Button btnTeacherClear;
        private System.Windows.Forms.ComboBox cbTeacherGender;
        private System.Windows.Forms.Button btnTeacherAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.MemoEdit txTeacherAdress;
        private System.Windows.Forms.TextBox txTeacherID;
        private System.Windows.Forms.TextBox txTeacherSurname;
        private System.Windows.Forms.Label lbTeacherID;
        private System.Windows.Forms.TextBox txTeacherName;
        private System.Windows.Forms.Label lbTeacherName;
        private System.Windows.Forms.Label lbTeacherSurname;
        private System.Windows.Forms.Label lbTeacherGender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbClass;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}