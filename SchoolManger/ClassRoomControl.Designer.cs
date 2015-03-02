namespace SchoolManger
{
    partial class ClassRoomControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DGV_ClassDetails = new System.Windows.Forms.DataGridView();
            this.ClassNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberStudentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberSeatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.TB_NbSeat = new System.Windows.Forms.TextBox();
            this.TB_NbStudent = new System.Windows.Forms.TextBox();
            this.TB_ProfName = new System.Windows.Forms.TextBox();
            this.TB_ClassName = new System.Windows.Forms.TextBox();
            this.L_NbEmptyPLace = new System.Windows.Forms.Label();
            this.L_NumberStudent = new System.Windows.Forms.Label();
            this.L_TechaerName = new System.Windows.Forms.Label();
            this.L_ClasseName = new System.Windows.Forms.Label();
            this.B_CreateNewClass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ClassDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_ClassDetails
            // 
            this.DGV_ClassDetails.AllowUserToAddRows = false;
            this.DGV_ClassDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_ClassDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_ClassDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ClassDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassNameColumn,
            this.TeacherNameColumn,
            this.NumberStudentColumn,
            this.NumberSeatColumn});
            this.DGV_ClassDetails.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DGV_ClassDetails.Location = new System.Drawing.Point(33, 37);
            this.DGV_ClassDetails.MultiSelect = false;
            this.DGV_ClassDetails.Name = "DGV_ClassDetails";
            this.DGV_ClassDetails.Size = new System.Drawing.Size(724, 217);
            this.DGV_ClassDetails.TabIndex = 0;
            this.DGV_ClassDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_ClassDetails_CellValueChanged);
            // 
            // ClassNameColumn
            // 
            this.ClassNameColumn.DataPropertyName = "CountClassRoom";
            this.ClassNameColumn.Frozen = true;
            this.ClassNameColumn.HeaderText = "Classe";
            this.ClassNameColumn.Name = "ClassNameColumn";
            this.ClassNameColumn.Width = 150;
            // 
            // TeacherNameColumn
            // 
            this.TeacherNameColumn.Frozen = true;
            this.TeacherNameColumn.HeaderText = "Prof";
            this.TeacherNameColumn.Name = "TeacherNameColumn";
            this.TeacherNameColumn.Width = 250;
            // 
            // NumberStudentColumn
            // 
            this.NumberStudentColumn.Frozen = true;
            this.NumberStudentColumn.HeaderText = "Nombre d\'élève";
            this.NumberStudentColumn.Name = "NumberStudentColumn";
            this.NumberStudentColumn.Width = 150;
            // 
            // NumberSeatColumn
            // 
            this.NumberSeatColumn.HeaderText = "Places libres";
            this.NumberSeatColumn.Name = "NumberSeatColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ClasseRoomTeacher";
            this.dataGridViewTextBoxColumn1.HeaderText = "Prof";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ClasseRoomTeacher";
            this.dataGridViewTextBoxColumn2.HeaderText = "Prof";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // schoolBindingSource
            // 
            this.schoolBindingSource.DataSource = typeof(ITI.SchoolManager.School);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.B_CreateNewClass);
            this.panel1.Controls.Add(this.TB_NbSeat);
            this.panel1.Controls.Add(this.TB_NbStudent);
            this.panel1.Controls.Add(this.TB_ProfName);
            this.panel1.Controls.Add(this.TB_ClassName);
            this.panel1.Controls.Add(this.L_NbEmptyPLace);
            this.panel1.Controls.Add(this.L_NumberStudent);
            this.panel1.Controls.Add(this.L_TechaerName);
            this.panel1.Controls.Add(this.L_ClasseName);
            this.panel1.Location = new System.Drawing.Point(33, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 121);
            this.panel1.TabIndex = 1;
            // 
            // TB_NbSeat
            // 
            this.TB_NbSeat.Location = new System.Drawing.Point(586, 43);
            this.TB_NbSeat.Name = "TB_NbSeat";
            this.TB_NbSeat.Size = new System.Drawing.Size(108, 20);
            this.TB_NbSeat.TabIndex = 7;
            this.TB_NbSeat.TextChanged += new System.EventHandler(this.TB_NbSeat_TextChanged);
            // 
            // TB_NbStudent
            // 
            this.TB_NbStudent.Location = new System.Drawing.Point(449, 43);
            this.TB_NbStudent.Name = "TB_NbStudent";
            this.TB_NbStudent.Size = new System.Drawing.Size(96, 20);
            this.TB_NbStudent.TabIndex = 6;
            this.TB_NbStudent.TextChanged += new System.EventHandler(this.TB_NbStudent_TextChanged);
            // 
            // TB_ProfName
            // 
            this.TB_ProfName.Location = new System.Drawing.Point(175, 43);
            this.TB_ProfName.Name = "TB_ProfName";
            this.TB_ProfName.Size = new System.Drawing.Size(234, 20);
            this.TB_ProfName.TabIndex = 5;
            this.TB_ProfName.TextChanged += new System.EventHandler(this.TB_ProfName_TextChanged);
            // 
            // TB_ClassName
            // 
            this.TB_ClassName.Location = new System.Drawing.Point(17, 43);
            this.TB_ClassName.Name = "TB_ClassName";
            this.TB_ClassName.Size = new System.Drawing.Size(126, 20);
            this.TB_ClassName.TabIndex = 4;
            this.TB_ClassName.TextChanged += new System.EventHandler(this.TB_ClassName_TextChanged);
            // 
            // L_NbEmptyPLace
            // 
            this.L_NbEmptyPLace.AutoSize = true;
            this.L_NbEmptyPLace.Location = new System.Drawing.Point(583, 17);
            this.L_NbEmptyPLace.Name = "L_NbEmptyPLace";
            this.L_NbEmptyPLace.Size = new System.Drawing.Size(70, 13);
            this.L_NbEmptyPLace.TabIndex = 3;
            this.L_NbEmptyPLace.Text = "Places Libres";
            // 
            // L_NumberStudent
            // 
            this.L_NumberStudent.AutoSize = true;
            this.L_NumberStudent.Location = new System.Drawing.Point(446, 17);
            this.L_NumberStudent.Name = "L_NumberStudent";
            this.L_NumberStudent.Size = new System.Drawing.Size(86, 13);
            this.L_NumberStudent.TabIndex = 2;
            this.L_NumberStudent.Text = "Nombre d\'élèves";
            // 
            // L_TechaerName
            // 
            this.L_TechaerName.AutoSize = true;
            this.L_TechaerName.Location = new System.Drawing.Point(192, 17);
            this.L_TechaerName.Name = "L_TechaerName";
            this.L_TechaerName.Size = new System.Drawing.Size(26, 13);
            this.L_TechaerName.TabIndex = 1;
            this.L_TechaerName.Text = "Prof";
            // 
            // L_ClasseName
            // 
            this.L_ClasseName.AutoSize = true;
            this.L_ClasseName.Location = new System.Drawing.Point(25, 17);
            this.L_ClasseName.Name = "L_ClasseName";
            this.L_ClasseName.Size = new System.Drawing.Size(38, 13);
            this.L_ClasseName.TabIndex = 0;
            this.L_ClasseName.Text = "Classe";
            // 
            // B_CreateNewClass
            // 
            this.B_CreateNewClass.Enabled = false;
            this.B_CreateNewClass.Location = new System.Drawing.Point(247, 80);
            this.B_CreateNewClass.Name = "B_CreateNewClass";
            this.B_CreateNewClass.Size = new System.Drawing.Size(232, 38);
            this.B_CreateNewClass.TabIndex = 8;
            this.B_CreateNewClass.Text = "Ajouter une classe";
            this.B_CreateNewClass.UseVisualStyleBackColor = true;
            this.B_CreateNewClass.Click += new System.EventHandler(this.B_CreateNewClass_Click);
            // 
            // ClassRoomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV_ClassDetails);
            this.Name = "ClassRoomControl";
            this.Size = new System.Drawing.Size(797, 429);
            this.Load += new System.EventHandler(this.ClassRoomControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ClassDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_ClassDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource schoolBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberStudentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberSeatColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TB_NbSeat;
        private System.Windows.Forms.TextBox TB_NbStudent;
        private System.Windows.Forms.TextBox TB_ProfName;
        private System.Windows.Forms.TextBox TB_ClassName;
        private System.Windows.Forms.Label L_NbEmptyPLace;
        private System.Windows.Forms.Label L_NumberStudent;
        private System.Windows.Forms.Label L_TechaerName;
        private System.Windows.Forms.Label L_ClasseName;
        private System.Windows.Forms.Button B_CreateNewClass;
    }
}
