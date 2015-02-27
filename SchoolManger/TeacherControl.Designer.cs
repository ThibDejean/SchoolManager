namespace SchoolManger
{
    partial class TeacherControl
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
            this.CLB_TeacherList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // CLB_TeacherList
            // 
            this.CLB_TeacherList.FormattingEnabled = true;
            this.CLB_TeacherList.Location = new System.Drawing.Point(21, 14);
            this.CLB_TeacherList.Name = "CLB_TeacherList";
            this.CLB_TeacherList.Size = new System.Drawing.Size(237, 214);
            this.CLB_TeacherList.TabIndex = 0;           
            // 
            // TeacherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CLB_TeacherList);
            this.Name = "TeacherControl";
            this.Size = new System.Drawing.Size(288, 259);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CLB_TeacherList;
    }
}
