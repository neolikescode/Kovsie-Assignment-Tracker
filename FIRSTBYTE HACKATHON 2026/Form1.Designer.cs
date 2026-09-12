namespace FIRSTBYTE_HACKATHON_2026
{
    partial class FrmModuleTracker
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
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblCompletionStatus = new System.Windows.Forms.Label();
            this.lblAssignmentName = new System.Windows.Forms.Label();
            this.txtModule = new System.Windows.Forms.TextBox();
            this.txtAssignmentName = new System.Windows.Forms.TextBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpInputFormArea = new System.Windows.Forms.GroupBox();
            this.lblModule = new System.Windows.Forms.Label();
            this.lstAssignments = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpMainDisplayArea = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grpSummaryReportingArea = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.lblModuleProgress = new System.Windows.Forms.Label();
            this.lblDashboardSummary = new System.Windows.Forms.Label();
            this.grpSorting_Searching = new System.Windows.Forms.GroupBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.grpradiob = new System.Windows.Forms.GroupBox();
            this.radDateDesc = new System.Windows.Forms.RadioButton();
            this.radDateAsc = new System.Windows.Forms.RadioButton();
            this.radModule = new System.Windows.Forms.RadioButton();
            this.grpInputFormArea.SuspendLayout();
            this.grpMainDisplayArea.SuspendLayout();
            this.grpSummaryReportingArea.SuspendLayout();
            this.grpSorting_Searching.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpradiob.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(16, 143);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(74, 20);
            this.lblDueDate.TabIndex = 0;
            this.lblDueDate.Text = "DueDate";
            // 
            // lblCompletionStatus
            // 
            this.lblCompletionStatus.AutoSize = true;
            this.lblCompletionStatus.Location = new System.Drawing.Point(16, 200);
            this.lblCompletionStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompletionStatus.Name = "lblCompletionStatus";
            this.lblCompletionStatus.Size = new System.Drawing.Size(136, 20);
            this.lblCompletionStatus.TabIndex = 1;
            this.lblCompletionStatus.Text = "CompletionStatus";
            // 
            // lblAssignmentName
            // 
            this.lblAssignmentName.AutoSize = true;
            this.lblAssignmentName.Location = new System.Drawing.Point(16, 89);
            this.lblAssignmentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAssignmentName.Name = "lblAssignmentName";
            this.lblAssignmentName.Size = new System.Drawing.Size(139, 20);
            this.lblAssignmentName.TabIndex = 3;
            this.lblAssignmentName.Text = "Assignment Name";
            // 
            // txtModule
            // 
            this.txtModule.Location = new System.Drawing.Point(168, 29);
            this.txtModule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(298, 26);
            this.txtModule.TabIndex = 4;
            // 
            // txtAssignmentName
            // 
            this.txtAssignmentName.Location = new System.Drawing.Point(168, 78);
            this.txtAssignmentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAssignmentName.Name = "txtAssignmentName";
            this.txtAssignmentName.Size = new System.Drawing.Size(298, 26);
            this.txtAssignmentName.TabIndex = 5;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(168, 134);
            this.dtpDueDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(298, 26);
            this.dtpDueDate.TabIndex = 6;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(164, 188);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(302, 28);
            this.cmbStatus.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(168, 272);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add/Update";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpInputFormArea
            // 
            this.grpInputFormArea.BackColor = System.Drawing.Color.White;
            this.grpInputFormArea.Controls.Add(this.lblModule);
            this.grpInputFormArea.Controls.Add(this.btnAdd);
            this.grpInputFormArea.Controls.Add(this.lblDueDate);
            this.grpInputFormArea.Controls.Add(this.dtpDueDate);
            this.grpInputFormArea.Controls.Add(this.lblCompletionStatus);
            this.grpInputFormArea.Controls.Add(this.lblAssignmentName);
            this.grpInputFormArea.Controls.Add(this.txtModule);
            this.grpInputFormArea.Controls.Add(this.txtAssignmentName);
            this.grpInputFormArea.Controls.Add(this.cmbStatus);
            this.grpInputFormArea.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpInputFormArea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpInputFormArea.Location = new System.Drawing.Point(18, 18);
            this.grpInputFormArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpInputFormArea.Name = "grpInputFormArea";
            this.grpInputFormArea.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpInputFormArea.Size = new System.Drawing.Size(600, 443);
            this.grpInputFormArea.TabIndex = 9;
            this.grpInputFormArea.TabStop = false;
            this.grpInputFormArea.Text = " ";
            this.grpInputFormArea.Enter += new System.EventHandler(this.grpInputFormArea_Enter);
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(26, 40);
            this.lblModule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(61, 20);
            this.lblModule.TabIndex = 15;
            this.lblModule.Text = "Module";
            // 
            // lstAssignments
            // 
            this.lstAssignments.FormattingEnabled = true;
            this.lstAssignments.ItemHeight = 20;
            this.lstAssignments.Location = new System.Drawing.Point(9, 89);
            this.lstAssignments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstAssignments.Name = "lstAssignments";
            this.lstAssignments.Size = new System.Drawing.Size(481, 244);
            this.lstAssignments.TabIndex = 9;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(130, 35);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(148, 26);
            this.txtSearch.TabIndex = 10;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(9, 372);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(112, 35);
            this.btnSort.TabIndex = 11;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(188, 372);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 35);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(354, 372);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 35);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpMainDisplayArea
            // 
            this.grpMainDisplayArea.Controls.Add(this.lblSearch);
            this.grpMainDisplayArea.Controls.Add(this.lstAssignments);
            this.grpMainDisplayArea.Controls.Add(this.txtSearch);
            this.grpMainDisplayArea.Controls.Add(this.btnDelete);
            this.grpMainDisplayArea.Controls.Add(this.btnSearch);
            this.grpMainDisplayArea.Controls.Add(this.btnSort);
            this.grpMainDisplayArea.Location = new System.Drawing.Point(627, 18);
            this.grpMainDisplayArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMainDisplayArea.Name = "grpMainDisplayArea";
            this.grpMainDisplayArea.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMainDisplayArea.Size = new System.Drawing.Size(542, 443);
            this.grpMainDisplayArea.TabIndex = 14;
            this.grpMainDisplayArea.TabStop = false;
            this.grpMainDisplayArea.Text = "Main Display Area";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(26, 40);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(60, 20);
            this.lblSearch.TabIndex = 14;
            this.lblSearch.Text = "Search";
            // 
            // grpSummaryReportingArea
            // 
            this.grpSummaryReportingArea.Controls.Add(this.button1);
            this.grpSummaryReportingArea.Controls.Add(this.btnSummary);
            this.grpSummaryReportingArea.Controls.Add(this.lblModuleProgress);
            this.grpSummaryReportingArea.Controls.Add(this.lblDashboardSummary);
            this.grpSummaryReportingArea.Location = new System.Drawing.Point(627, 471);
            this.grpSummaryReportingArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSummaryReportingArea.Name = "grpSummaryReportingArea";
            this.grpSummaryReportingArea.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSummaryReportingArea.Size = new System.Drawing.Size(542, 275);
            this.grpSummaryReportingArea.TabIndex = 14;
            this.grpSummaryReportingArea.TabStop = false;
            this.grpSummaryReportingArea.Text = "Summary & Reporting Area";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 127);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "View Progress";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(344, 55);
            this.btnSummary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(148, 35);
            this.btnSummary.TabIndex = 16;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // lblModuleProgress
            // 
            this.lblModuleProgress.AutoSize = true;
            this.lblModuleProgress.Location = new System.Drawing.Point(16, 134);
            this.lblModuleProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModuleProgress.Name = "lblModuleProgress";
            this.lblModuleProgress.Size = new System.Drawing.Size(136, 20);
            this.lblModuleProgress.TabIndex = 1;
            this.lblModuleProgress.Text = "  Module Progress";
            // 
            // lblDashboardSummary
            // 
            this.lblDashboardSummary.Location = new System.Drawing.Point(16, 55);
            this.lblDashboardSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDashboardSummary.Name = "lblDashboardSummary";
            this.lblDashboardSummary.Size = new System.Drawing.Size(232, 35);
            this.lblDashboardSummary.TabIndex = 0;
            this.lblDashboardSummary.Text = "Dashboard Summary";
            this.lblDashboardSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpSorting_Searching
            // 
            this.grpSorting_Searching.Controls.Add(this.grpSearch);
            this.grpSorting_Searching.Controls.Add(this.grpradiob);
            this.grpSorting_Searching.Location = new System.Drawing.Point(18, 471);
            this.grpSorting_Searching.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSorting_Searching.Name = "grpSorting_Searching";
            this.grpSorting_Searching.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSorting_Searching.Size = new System.Drawing.Size(600, 275);
            this.grpSorting_Searching.TabIndex = 15;
            this.grpSorting_Searching.TabStop = false;
            this.grpSorting_Searching.Text = "Sorting";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.lblKeyword);
            this.grpSearch.Controls.Add(this.txtKeyword);
            this.grpSearch.Controls.Add(this.btnFind);
            this.grpSearch.Location = new System.Drawing.Point(258, 55);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSearch.Size = new System.Drawing.Size(274, 202);
            this.grpSearch.TabIndex = 17;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Location = new System.Drawing.Point(9, 34);
            this.lblKeyword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(69, 20);
            this.lblKeyword.TabIndex = 2;
            this.lblKeyword.Text = "Keyword";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(87, 28);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(179, 26);
            this.txtKeyword.TabIndex = 15;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(87, 98);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(112, 35);
            this.btnFind.TabIndex = 15;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // grpradiob
            // 
            this.grpradiob.Controls.Add(this.radDateDesc);
            this.grpradiob.Controls.Add(this.radDateAsc);
            this.grpradiob.Controls.Add(this.radModule);
            this.grpradiob.Location = new System.Drawing.Point(21, 55);
            this.grpradiob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpradiob.Name = "grpradiob";
            this.grpradiob.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpradiob.Size = new System.Drawing.Size(228, 202);
            this.grpradiob.TabIndex = 16;
            this.grpradiob.TabStop = false;
            this.grpradiob.Text = "Sorting";
            // 
            // radDateDesc
            // 
            this.radDateDesc.AutoSize = true;
            this.radDateDesc.Location = new System.Drawing.Point(9, 108);
            this.radDateDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radDateDesc.Name = "radDateDesc";
            this.radDateDesc.Size = new System.Drawing.Size(138, 24);
            this.radDateDesc.TabIndex = 3;
            this.radDateDesc.TabStop = true;
            this.radDateDesc.Text = "Date (In Desc)";
            this.radDateDesc.UseVisualStyleBackColor = true;
            this.radDateDesc.CheckedChanged += new System.EventHandler(this.radDateDesc_CheckedChanged);
            // 
            // radDateAsc
            // 
            this.radDateAsc.AutoSize = true;
            this.radDateAsc.Location = new System.Drawing.Point(9, 72);
            this.radDateAsc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radDateAsc.Name = "radDateAsc";
            this.radDateAsc.Size = new System.Drawing.Size(128, 24);
            this.radDateAsc.TabIndex = 2;
            this.radDateAsc.TabStop = true;
            this.radDateAsc.Text = "Date (In Asc)";
            this.radDateAsc.UseVisualStyleBackColor = true;
            this.radDateAsc.CheckedChanged += new System.EventHandler(this.radDateAsc_CheckedChanged);
            // 
            // radModule
            // 
            this.radModule.AutoSize = true;
            this.radModule.Location = new System.Drawing.Point(9, 37);
            this.radModule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radModule.Name = "radModule";
            this.radModule.Size = new System.Drawing.Size(86, 24);
            this.radModule.TabIndex = 1;
            this.radModule.TabStop = true;
            this.radModule.Text = "Module";
            this.radModule.UseVisualStyleBackColor = true;
            this.radModule.CheckedChanged += new System.EventHandler(this.radModule_CheckedChanged);
            // 
            // FrmModuleTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 774);
            this.Controls.Add(this.grpSorting_Searching);
            this.Controls.Add(this.grpSummaryReportingArea);
            this.Controls.Add(this.grpMainDisplayArea);
            this.Controls.Add(this.grpInputFormArea);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmModuleTracker";
            this.Text = "Module Tracker";
            this.Load += new System.EventHandler(this.FrmModuleTracker_Load);
            this.grpInputFormArea.ResumeLayout(false);
            this.grpInputFormArea.PerformLayout();
            this.grpMainDisplayArea.ResumeLayout(false);
            this.grpMainDisplayArea.PerformLayout();
            this.grpSummaryReportingArea.ResumeLayout(false);
            this.grpSummaryReportingArea.PerformLayout();
            this.grpSorting_Searching.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpradiob.ResumeLayout(false);
            this.grpradiob.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblCompletionStatus;
        private System.Windows.Forms.Label lblAssignmentName;
        private System.Windows.Forms.TextBox txtModule;
        private System.Windows.Forms.TextBox txtAssignmentName;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpInputFormArea;
        private System.Windows.Forms.ListBox lstAssignments;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpMainDisplayArea;
        private System.Windows.Forms.GroupBox grpSummaryReportingArea;
        private System.Windows.Forms.Label lblModuleProgress;
        private System.Windows.Forms.Label lblDashboardSummary;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox grpSorting_Searching;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.RadioButton radDateDesc;
        private System.Windows.Forms.RadioButton radDateAsc;
        private System.Windows.Forms.RadioButton radModule;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.GroupBox grpradiob;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblModule;
    }
}

