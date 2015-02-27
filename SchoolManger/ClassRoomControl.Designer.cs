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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClassNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberStudentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberSeatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassNameColumn,
            this.TeacherNameColumn,
            this.NumberStudentColumn,
            this.NumberSeatColumn});
            this.dataGridView1.Location = new System.Drawing.Point(147, 41);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 256);
            this.dataGridView1.TabIndex = 0;           
            // 
            // ClassNameColumn
            // 
            this.ClassNameColumn.HeaderText = "Classe";
            this.ClassNameColumn.Name = "ClassNameColumn";
            // 
            // TeacherNameColumn
            // 
            this.TeacherNameColumn.HeaderText = "Prof";
            this.TeacherNameColumn.Name = "TeacherNameColumn";
            // 
            // NumberStudentColumn
            // 
            this.NumberStudentColumn.HeaderText = "Nombre d\'élève";
            this.NumberStudentColumn.Name = "NumberStudentColumn";
            // 
            // NumberSeatColumn
            // 
            this.NumberSeatColumn.HeaderText = "Places libres";
            this.NumberSeatColumn.Name = "NumberSeatColumn";
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(ITI.SchoolManager.Teacher);
            // 
            // ClassRoomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClassRoomControl";
            this.Size = new System.Drawing.Size(797, 387);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberStudentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberSeatColumn;
        private System.Windows.Forms.BindingSource teacherBindingSource;
    }
}
