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
            this.B_Dispatch = new System.Windows.Forms.Button();
            this.RTB_Dispatch = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CLB_TeacherList
            // 
            this.CLB_TeacherList.BackColor = System.Drawing.SystemColors.Control;
            this.CLB_TeacherList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CLB_TeacherList.CheckOnClick = true;
            this.CLB_TeacherList.FormattingEnabled = true;
            this.CLB_TeacherList.Location = new System.Drawing.Point(68, 17);
            this.CLB_TeacherList.Name = "CLB_TeacherList";
            this.CLB_TeacherList.Size = new System.Drawing.Size(210, 270);
            this.CLB_TeacherList.TabIndex = 0;
            // 
            // B_Dispatch
            // 
            this.B_Dispatch.Location = new System.Drawing.Point(238, 310);
            this.B_Dispatch.Name = "B_Dispatch";
            this.B_Dispatch.Size = new System.Drawing.Size(210, 23);
            this.B_Dispatch.TabIndex = 1;
            this.B_Dispatch.Text = "Répartir les élèves";
            this.B_Dispatch.UseVisualStyleBackColor = true;
            this.B_Dispatch.Click += new System.EventHandler(this.B_Dispatch_Click);
            // 
            // RTB_Dispatch
            // 
            this.RTB_Dispatch.Location = new System.Drawing.Point(380, 17);
            this.RTB_Dispatch.Name = "RTB_Dispatch";
            this.RTB_Dispatch.ReadOnly = true;
            this.RTB_Dispatch.Size = new System.Drawing.Size(320, 270);
            this.RTB_Dispatch.TabIndex = 3;
            this.RTB_Dispatch.Text = "";
            // 
            // TeacherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RTB_Dispatch);
            this.Controls.Add(this.B_Dispatch);
            this.Controls.Add(this.CLB_TeacherList);
            this.Name = "TeacherControl";
            this.Size = new System.Drawing.Size(724, 390);
            this.Load += new System.EventHandler(this.TeacherControl_Load);
            this.Leave += new System.EventHandler(this.TeacherControl_Leave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CLB_TeacherList;
        private System.Windows.Forms.Button B_Dispatch;
        private System.Windows.Forms.RichTextBox RTB_Dispatch;
    }
}
