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
            this.DGV_ClassDetails = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberStudentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberSeatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ClassDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_ClassDetails
            // 
            this.DGV_ClassDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_ClassDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_ClassDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ClassDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassNameColumn,
            this.TeacherNameColumn,
            this.NumberStudentColumn,
            this.NumberSeatColumn});
            this.DGV_ClassDetails.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DGV_ClassDetails.Location = new System.Drawing.Point(45, 43);
            this.DGV_ClassDetails.MultiSelect = false;
            this.DGV_ClassDetails.Name = "DGV_ClassDetails";
            this.DGV_ClassDetails.Size = new System.Drawing.Size(724, 256);
            this.DGV_ClassDetails.TabIndex = 0;
            this.DGV_ClassDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_ClassDetails_CellValueChanged);
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
            // ClassNameColumn
            // 
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
            // ClassRoomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DGV_ClassDetails);
            this.Name = "ClassRoomControl";
            this.Size = new System.Drawing.Size(797, 387);
            this.Load += new System.EventHandler(this.ClassRoomControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ClassDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_ClassDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberStudentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberSeatColumn;
    }
}
