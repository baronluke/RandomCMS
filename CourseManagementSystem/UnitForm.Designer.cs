namespace CourseManagementSystem
{
    partial class UnitForm
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
            this.rdbElectiveUnit = new System.Windows.Forms.RadioButton();
            this.rdbCoreUnit = new System.Windows.Forms.RadioButton();
            this.lblUnitType = new System.Windows.Forms.Label();
            this.mnuAssessmentForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTeacherForm = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvUnit = new System.Windows.Forms.DataGridView();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.mnuUnitForm = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUnitForm = new System.Windows.Forms.Label();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNavigate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnrolmentForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCourseForm = new System.Windows.Forms.ToolStripMenuItem();
            this.UnitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmbUnitName = new System.Windows.Forms.ComboBox();
            this.txtNumOfAssessments = new System.Windows.Forms.TextBox();
            this.txtNoOfHours = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblNumOfAssessments = new System.Windows.Forms.Label();
            this.lblNoOfHours = new System.Windows.Forms.Label();
            this.txtUnitID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbElectiveUnit
            // 
            this.rdbElectiveUnit.AutoSize = true;
            this.rdbElectiveUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbElectiveUnit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdbElectiveUnit.Location = new System.Drawing.Point(379, 266);
            this.rdbElectiveUnit.Name = "rdbElectiveUnit";
            this.rdbElectiveUnit.Size = new System.Drawing.Size(128, 24);
            this.rdbElectiveUnit.TabIndex = 97;
            this.rdbElectiveUnit.TabStop = true;
            this.rdbElectiveUnit.Tag = "Unit Type";
            this.rdbElectiveUnit.Text = "Elective Unit";
            this.rdbElectiveUnit.UseVisualStyleBackColor = true;
            // 
            // rdbCoreUnit
            // 
            this.rdbCoreUnit.AutoSize = true;
            this.rdbCoreUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCoreUnit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rdbCoreUnit.Location = new System.Drawing.Point(259, 266);
            this.rdbCoreUnit.Name = "rdbCoreUnit";
            this.rdbCoreUnit.Size = new System.Drawing.Size(103, 24);
            this.rdbCoreUnit.TabIndex = 96;
            this.rdbCoreUnit.TabStop = true;
            this.rdbCoreUnit.Tag = "Unit Type";
            this.rdbCoreUnit.Text = "Core Unit";
            this.rdbCoreUnit.UseVisualStyleBackColor = true;
            // 
            // lblUnitType
            // 
            this.lblUnitType.AutoSize = true;
            this.lblUnitType.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblUnitType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitType.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUnitType.Location = new System.Drawing.Point(152, 268);
            this.lblUnitType.Name = "lblUnitType";
            this.lblUnitType.Size = new System.Drawing.Size(90, 20);
            this.lblUnitType.TabIndex = 90;
            this.lblUnitType.Text = "Unit Type:";
            // 
            // mnuAssessmentForm
            // 
            this.mnuAssessmentForm.Name = "mnuAssessmentForm";
            this.mnuAssessmentForm.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.mnuAssessmentForm.Size = new System.Drawing.Size(259, 22);
            this.mnuAssessmentForm.Text = "Assessment Form";
            this.mnuAssessmentForm.ToolTipText = "Go to assessment form";
            // 
            // mnuTeacherForm
            // 
            this.mnuTeacherForm.Name = "mnuTeacherForm";
            this.mnuTeacherForm.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.mnuTeacherForm.Size = new System.Drawing.Size(259, 22);
            this.mnuTeacherForm.Text = "Teacher Form";
            this.mnuTeacherForm.ToolTipText = "Go to teacher form";
            // 
            // dgvUnit
            // 
            this.dgvUnit.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnit.Location = new System.Drawing.Point(12, 414);
            this.dgvUnit.Name = "dgvUnit";
            this.dgvUnit.ReadOnly = true;
            this.dgvUnit.Size = new System.Drawing.Size(642, 120);
            this.dgvUnit.TabIndex = 83;
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUnitName.Location = new System.Drawing.Point(147, 171);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(98, 20);
            this.lblUnitName.TabIndex = 78;
            this.lblUnitName.Text = "Unit Name:";
            // 
            // mnuUnitForm
            // 
            this.mnuUnitForm.Name = "mnuUnitForm";
            this.mnuUnitForm.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.U)));
            this.mnuUnitForm.Size = new System.Drawing.Size(259, 22);
            this.mnuUnitForm.Text = "Unit Form";
            this.mnuUnitForm.ToolTipText = "Go to unit form";
            // 
            // lblUnitForm
            // 
            this.lblUnitForm.AutoSize = true;
            this.lblUnitForm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblUnitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitForm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUnitForm.Location = new System.Drawing.Point(252, 60);
            this.lblUnitForm.Name = "lblUnitForm";
            this.lblUnitForm.Size = new System.Drawing.Size(168, 37);
            this.lblUnitForm.TabIndex = 76;
            this.lblUnitForm.Text = "Unit Form";
            this.lblUnitForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUnitID.Location = new System.Drawing.Point(175, 139);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(71, 20);
            this.lblUnitID.TabIndex = 75;
            this.lblUnitID.Text = "Unit ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuNavigate});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 88;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdd,
            this.mnuDelete,
            this.mnuUpdate,
            this.mnuViewAll});
            this.mnuFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(42, 20);
            this.mnuFile.Text = "File";
            this.mnuFile.ToolTipText = "Press to add, delete, update or view all";
            // 
            // mnuAdd
            // 
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuAdd.Size = new System.Drawing.Size(166, 22);
            this.mnuAdd.Text = "Add";
            this.mnuAdd.ToolTipText = "Add a new record";
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.ShortcutKeyDisplayString = "";
            this.mnuDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuDelete.Size = new System.Drawing.Size(166, 22);
            this.mnuDelete.Text = "Delete";
            this.mnuDelete.ToolTipText = "Delete  record";
            // 
            // mnuUpdate
            // 
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.mnuUpdate.Size = new System.Drawing.Size(166, 22);
            this.mnuUpdate.Text = "Update";
            this.mnuUpdate.ToolTipText = "Update record";
            // 
            // mnuViewAll
            // 
            this.mnuViewAll.Name = "mnuViewAll";
            this.mnuViewAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuViewAll.Size = new System.Drawing.Size(166, 22);
            this.mnuViewAll.Text = "View All";
            this.mnuViewAll.ToolTipText = "View All record";
            // 
            // mnuNavigate
            // 
            this.mnuNavigate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEnrolmentForm,
            this.mnuCourseForm,
            this.mnuUnitForm,
            this.mnuAssessmentForm,
            this.mnuTeacherForm});
            this.mnuNavigate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuNavigate.Name = "mnuNavigate";
            this.mnuNavigate.Size = new System.Drawing.Size(75, 20);
            this.mnuNavigate.Text = "Navigate";
            this.mnuNavigate.ToolTipText = "Navigate to enrolment form";
            // 
            // mnuEnrolmentForm
            // 
            this.mnuEnrolmentForm.Name = "mnuEnrolmentForm";
            this.mnuEnrolmentForm.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.mnuEnrolmentForm.Size = new System.Drawing.Size(259, 22);
            this.mnuEnrolmentForm.Text = "Enrolment Form";
            this.mnuEnrolmentForm.ToolTipText = "Go to enrolment form";
            // 
            // mnuCourseForm
            // 
            this.mnuCourseForm.Name = "mnuCourseForm";
            this.mnuCourseForm.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.mnuCourseForm.Size = new System.Drawing.Size(259, 22);
            this.mnuCourseForm.Text = "Course Form";
            this.mnuCourseForm.ToolTipText = "Go to course form";
            // 
            // cmbUnitName
            // 
            this.cmbUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnitName.FormattingEnabled = true;
            this.cmbUnitName.Location = new System.Drawing.Point(259, 168);
            this.cmbUnitName.Name = "cmbUnitName";
            this.cmbUnitName.Size = new System.Drawing.Size(347, 28);
            this.cmbUnitName.TabIndex = 93;
            this.cmbUnitName.Tag = "Unit Name";
            this.UnitToolTip.SetToolTip(this.cmbUnitName, "press the down arrow to make a selection");
            // 
            // txtNumOfAssessments
            // 
            this.txtNumOfAssessments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfAssessments.Location = new System.Drawing.Point(259, 234);
            this.txtNumOfAssessments.Name = "txtNumOfAssessments";
            this.txtNumOfAssessments.Size = new System.Drawing.Size(113, 26);
            this.txtNumOfAssessments.TabIndex = 87;
            this.txtNumOfAssessments.Tag = "No. of Assessments";
            // 
            // txtNoOfHours
            // 
            this.txtNoOfHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfHours.Location = new System.Drawing.Point(259, 202);
            this.txtNoOfHours.Name = "txtNoOfHours";
            this.txtNoOfHours.Size = new System.Drawing.Size(113, 26);
            this.txtNoOfHours.TabIndex = 85;
            this.txtNoOfHours.Tag = "No. of Hours";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch.Image = global::CourseManagementSystem.Properties.Resources.unnamed__1_5;
            this.btnSearch.Location = new System.Drawing.Point(441, 136);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 28);
            this.btnSearch.TabIndex = 89;
            this.UnitToolTip.SetToolTip(this.btnSearch, "Press to search");
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblNumOfAssessments
            // 
            this.lblNumOfAssessments.AutoSize = true;
            this.lblNumOfAssessments.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblNumOfAssessments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfAssessments.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNumOfAssessments.Location = new System.Drawing.Point(73, 237);
            this.lblNumOfAssessments.Name = "lblNumOfAssessments";
            this.lblNumOfAssessments.Size = new System.Drawing.Size(169, 20);
            this.lblNumOfAssessments.TabIndex = 86;
            this.lblNumOfAssessments.Text = "No. of Assessments";
            // 
            // lblNoOfHours
            // 
            this.lblNoOfHours.AutoSize = true;
            this.lblNoOfHours.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblNoOfHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfHours.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNoOfHours.Location = new System.Drawing.Point(127, 205);
            this.lblNoOfHours.Name = "lblNoOfHours";
            this.lblNoOfHours.Size = new System.Drawing.Size(115, 20);
            this.lblNoOfHours.TabIndex = 84;
            this.lblNoOfHours.Text = "No. of Hours:";
            // 
            // txtUnitID
            // 
            this.txtUnitID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitID.Location = new System.Drawing.Point(259, 136);
            this.txtUnitID.Name = "txtUnitID";
            this.txtUnitID.Size = new System.Drawing.Size(176, 26);
            this.txtUnitID.TabIndex = 77;
            this.txtUnitID.Tag = "Unit ID";
            // 
            // UnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(666, 546);
            this.Controls.Add(this.rdbElectiveUnit);
            this.Controls.Add(this.rdbCoreUnit);
            this.Controls.Add(this.lblUnitType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvUnit);
            this.Controls.Add(this.lblUnitName);
            this.Controls.Add(this.lblUnitForm);
            this.Controls.Add(this.lblUnitID);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblNumOfAssessments);
            this.Controls.Add(this.lblNoOfHours);
            this.Controls.Add(this.txtUnitID);
            this.Controls.Add(this.cmbUnitName);
            this.Controls.Add(this.txtNumOfAssessments);
            this.Controls.Add(this.txtNoOfHours);
            this.Location = new System.Drawing.Point(423, 123);
            this.MaximizeBox = false;
            this.Name = "UnitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbElectiveUnit;
        private System.Windows.Forms.RadioButton rdbCoreUnit;
        private System.Windows.Forms.Label lblUnitType;
        private System.Windows.Forms.ToolStripMenuItem mnuAssessmentForm;
        private System.Windows.Forms.ToolStripMenuItem mnuTeacherForm;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolTip UnitToolTip;
        private System.Windows.Forms.DataGridView dgvUnit;
        private System.Windows.Forms.Label lblUnitName;
        private System.Windows.Forms.ToolStripMenuItem mnuUnitForm;
        private System.Windows.Forms.Label lblUnitForm;
        private System.Windows.Forms.Label lblUnitID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuViewAll;
        private System.Windows.Forms.ToolStripMenuItem mnuNavigate;
        private System.Windows.Forms.ToolStripMenuItem mnuEnrolmentForm;
        private System.Windows.Forms.ToolStripMenuItem mnuCourseForm;
        private System.Windows.Forms.ComboBox cmbUnitName;
        private System.Windows.Forms.TextBox txtNumOfAssessments;
        private System.Windows.Forms.TextBox txtNoOfHours;
        private System.Windows.Forms.Label lblNumOfAssessments;
        private System.Windows.Forms.Label lblNoOfHours;
        private System.Windows.Forms.TextBox txtUnitID;
    }
}