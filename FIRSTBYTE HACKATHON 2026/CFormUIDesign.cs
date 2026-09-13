using System.Drawing;
using System.Windows.Forms;

namespace FIRSTBYTE_HACKATHON_2026
{
    public partial class FrmModuleTracker
    {
        //This Class was optional btw, the program i'm writing in here can be done in the form design, but that was tedious
        //so i decided to use this method which is faster

        //This class will be used for the styling/designing of the form

        //The theme colors will be
        /* Primary - Blue
         * Background - White
         * Success - Green
         * Warning - Orange
         * Text Color - White
         */

        private void ApplyButtonTheme()
        {

            // ADD ASSIGNMENT Button
            btnAdd.Text = "+ Add Assignment";
            btnAdd.BackColor = ColorTranslator.FromHtml("#2563EB");
            btnAdd.ForeColor = Color.White;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.AutoSize = false;
            btnAdd.Size = new Size(235, 45);
            btnAdd.Location = new Point(60, 200);
            btnAdd.TextAlign = ContentAlignment.MiddleCenter;
            btnAdd.UseVisualStyleBackColor = false;

            btnAdd.MouseEnter += BtnAdd_MouseEnter;
            btnAdd.MouseLeave += BtnAdd_MouseLeave;

            //Search Button
            btnSearch.Text = "Search";
            btnSearch.BackColor = Color.White;
            btnSearch.ForeColor = ColorTranslator.FromHtml("#2563EB");
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.FlatAppearance.BorderSize = 1;
            btnSearch.FlatAppearance.BorderColor =
                ColorTranslator.FromHtml("#2563EB");
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.AutoSize = false;
            btnSearch.Size = new Size(100, 40);
            btnSearch.Location = new Point(115, 225);
            btnSearch.TextAlign = ContentAlignment.MiddleCenter;
            btnSearch.UseVisualStyleBackColor = false;

            btnSearch.MouseEnter += BtnSearch_MouseEnter;
            btnSearch.MouseLeave += BtnSearch_MouseLeave;

            //Sort Button
            btnSort.Text = "Sort";
            btnSort.BackColor = Color.White;
            btnSort.ForeColor = ColorTranslator.FromHtml("#334155");
            btnSort.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSort.FlatStyle = FlatStyle.Flat;
            btnSort.FlatAppearance.BorderSize = 1;
            btnSort.FlatAppearance.BorderColor =
                ColorTranslator.FromHtml("#CBD5E1");
            btnSort.Cursor = Cursors.Hand;
            btnSort.AutoSize = false;
            btnSort.Size = new Size(100, 40);
            btnSort.Location = new Point(6, 225);
            btnSort.TextAlign = ContentAlignment.MiddleCenter;
            btnSort.UseVisualStyleBackColor = false;

            btnSort.MouseEnter += BtnSort_MouseEnter;
            btnSort.MouseLeave += BtnSort_MouseLeave;

            //Delete Button
            btnDelete.Text = "Delete";
            btnDelete.BackColor = ColorTranslator.FromHtml("#DC2626");
            btnDelete.ForeColor = Color.White;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.AutoSize = false;
            btnDelete.Size = new Size(100, 40);
            btnDelete.Location = new Point(228, 225);
            btnDelete.TextAlign = ContentAlignment.MiddleCenter;
            btnDelete.UseVisualStyleBackColor = false;

            btnDelete.MouseEnter += BtnDelete_MouseEnter;
            btnDelete.MouseLeave += BtnDelete_MouseLeave;

            //The View Progress button was giving me issues, it wouldn't display properly
            //View Progress button styling
            btnViewProgress.AutoSize = false;
            btnViewProgress.Size = new Size(100, 30);
            btnViewProgress.Text = "View Progress";
            btnViewProgress.TextAlign = ContentAlignment.MiddleCenter;
            btnViewProgress.BackColor = Color.White;
            btnViewProgress.ForeColor = ColorTranslator.FromHtml("#2563EB");
            btnViewProgress.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnViewProgress.FlatStyle = FlatStyle.Flat;
            btnViewProgress.FlatAppearance.BorderSize = 1;
            btnViewProgress.FlatAppearance.BorderColor =
                ColorTranslator.FromHtml("#2563EB");
            btnViewProgress.Cursor = Cursors.Hand;
            btnViewProgress.UseVisualStyleBackColor = false;
            btnViewProgress.MouseEnter += BtnViewProgress_MouseEnter;
            btnViewProgress.MouseLeave += BtnViewProgress_MouseLeave;

            //Find Button
            btnFind.Text = "Find";
            btnFind.BackColor = Color.White;
            btnFind.ForeColor = ColorTranslator.FromHtml("#2563EB");
            btnFind.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.FlatAppearance.BorderSize = 1;
            btnFind.FlatAppearance.BorderColor =
                ColorTranslator.FromHtml("#2563EB");
            btnFind.Cursor = Cursors.Hand;
            btnFind.AutoSize = false;
            btnFind.Size = new Size(100, 40);
            btnFind.TextAlign = ContentAlignment.MiddleCenter;
            btnFind.UseVisualStyleBackColor = false;

            btnFind.MouseEnter += BtnFind_MouseEnter;
            btnFind.MouseLeave += BtnFind_MouseLeave;

            //Summary Button
            btnSummary.Text = "Summary";
            btnSummary.BackColor = Color.White;
            btnSummary.ForeColor = ColorTranslator.FromHtml("#2563EB");
            btnSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSummary.FlatStyle = FlatStyle.Flat;
            btnSummary.FlatAppearance.BorderSize = 1;
            btnSummary.FlatAppearance.BorderColor =
                ColorTranslator.FromHtml("#2563EB");
            btnSummary.Cursor = Cursors.Hand;
            btnSummary.AutoSize = false;
            btnSummary.Size = new Size(100, 40);
            btnSummary.TextAlign = ContentAlignment.MiddleCenter;
            btnSummary.UseVisualStyleBackColor = false;

            btnSummary.MouseEnter += BtnSummary_MouseEnter;
            btnSummary.MouseLeave += BtnSummary_MouseLeave;
            
        }

        //background color change
        private void ApplyFormTheme()
        {
            //subtle light-grey / blue background
            this.BackColor = ColorTranslator.FromHtml("#F5F7FB");
        }

        //main section styling/ group boxes styling
        private void ApplySectionTheme()
        {
            //loops hrough all the group boxes
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    groupBox.BackColor = Color.White;
                    groupBox.ForeColor = ColorTranslator.FromHtml("#172033");
                    groupBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                }
            }
        }

        //Textbox styling, i wanted them to have a similar and cleaner look so i just manually gave them the same look
        //Input fields styling
        private void ApplyInputTheme()
        {
            //Module textbox
            txtModule.BackColor = ColorTranslator.FromHtml("#F8FAFC");
            txtModule.ForeColor = ColorTranslator.FromHtml("#172033");
            txtModule.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            txtModule.BorderStyle = BorderStyle.FixedSingle;

            //Assignment Name textbox
            txtAssignmentName.BackColor = ColorTranslator.FromHtml("#F8FAFC");
            txtAssignmentName.ForeColor = ColorTranslator.FromHtml("#172033");
            txtAssignmentName.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            txtAssignmentName.BorderStyle = BorderStyle.FixedSingle;

            //Search textbox
            txtSearch.BackColor = ColorTranslator.FromHtml("#F8FAFC");
            txtSearch.ForeColor = ColorTranslator.FromHtml("#172033");
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;

            //Keyword textbox
            txtKeyword.BackColor = ColorTranslator.FromHtml("#F8FAFC");
            txtKeyword.ForeColor = ColorTranslator.FromHtml("#172033");
            txtKeyword.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            txtKeyword.BorderStyle = BorderStyle.FixedSingle;
        }
        //Completion status dropdown styling, makes it look cooler idk
        private void ApplyComboBoxTheme()
        {
            //Completion Status ComboBox
            cmbStatus.BackColor = ColorTranslator.FromHtml("#E2E8F0");
            cmbStatus.ForeColor = ColorTranslator.FromHtml("#172033");
            cmbStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //date time picker box styling
        private void ApplyDatePickerTheme()
        {
            //Due Date DateTimePicker
            dtpDueDate.BackColor = ColorTranslator.FromHtml("#E2E8F0");
            dtpDueDate.ForeColor = ColorTranslator.FromHtml("#172033");
            dtpDueDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            dtpDueDate.Format = DateTimePickerFormat.Long;
        }
        //Assignment list styling
        private void ApplyListTheme()
        {
            //Main assignment list styling
            lstAssignments.BackColor = Color.White;
            lstAssignments.ForeColor = ColorTranslator.FromHtml("#172033");
            lstAssignments.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            //Removes the default border
            lstAssignments.BorderStyle = BorderStyle.FixedSingle;

            //Allows only one assignment to be selected at a time
            lstAssignments.SelectionMode = SelectionMode.One;
        }

        //Label styling
        private void ApplyLabelTheme()
        {
            //input labels
            lblModule.ForeColor = ColorTranslator.FromHtml("#172033");
            lblModule.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            lblAssignmentName.ForeColor = ColorTranslator.FromHtml("#172033");
            lblAssignmentName.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            lblDueDate.ForeColor = ColorTranslator.FromHtml("#172033");
            lblDueDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            lblCompletionStatus.ForeColor = ColorTranslator.FromHtml("#172033");
            lblCompletionStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            //display labels
            lblSearch.ForeColor = ColorTranslator.FromHtml("#172033");
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            //Summary labels
            lblDashboardSummary.ForeColor = ColorTranslator.FromHtml("#172033");
            lblDashboardSummary.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            lblModuleProgress.ForeColor = ColorTranslator.FromHtml("#172033");
            lblModuleProgress.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        }

        //Radio button styling
        private void ApplyRadioButtonTheme()
        {
            //Module sorting option
            radModule.ForeColor = ColorTranslator.FromHtml("#172033");
            radModule.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            //Date ascending sorting option
            radDateAsc.ForeColor = ColorTranslator.FromHtml("#172033");
            radDateAsc.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            //Date descending sorting option
            radDateDesc.ForeColor = ColorTranslator.FromHtml("#172033");
            radDateDesc.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        }

        //Add Assignment hover effect
        private void BtnAdd_MouseEnter(object sender, System.EventArgs e)
        {
            btnAdd.BackColor = ColorTranslator.FromHtml("#1D4ED8");
        }

        private void BtnAdd_MouseLeave(object sender, System.EventArgs e)
        {
            btnAdd.BackColor = ColorTranslator.FromHtml("#2563EB");
        }

        //Search butotn hover effect
        private void BtnSearch_MouseEnter(object sender, System.EventArgs e)
        {
            btnSearch.BackColor = ColorTranslator.FromHtml("#EFF6FF");
        }

        private void BtnSearch_MouseLeave(object sender, System.EventArgs e)
        {
            btnSearch.BackColor = Color.White;
        }

        //Sort button hover effect
        private void BtnSort_MouseEnter(object sender, System.EventArgs e)
        {
            btnSort.BackColor = ColorTranslator.FromHtml("#F1F5F9");
        }

        private void BtnSort_MouseLeave(object sender, System.EventArgs e)
        {
            btnSort.BackColor = Color.White;
        }

        //Delete button hover effect
        private void BtnDelete_MouseEnter(object sender, System.EventArgs e)
        {
            btnDelete.BackColor = ColorTranslator.FromHtml("#B91C1C");
        }

        private void BtnDelete_MouseLeave(object sender, System.EventArgs e)
        {
            btnDelete.BackColor = ColorTranslator.FromHtml("#DC2626");
        }

        //Find button hover effect
        private void BtnFind_MouseEnter(object sender, System.EventArgs e)
        {
            btnFind.BackColor = ColorTranslator.FromHtml("#EFF6FF");
        }

        private void BtnFind_MouseLeave(object sender, System.EventArgs e)
        {
            btnFind.BackColor = Color.White;
        }

        //Summary button hover effect
        private void BtnSummary_MouseEnter(object sender, System.EventArgs e)
        {
            btnSummary.BackColor = ColorTranslator.FromHtml("#EFF6FF");
        }

        private void BtnSummary_MouseLeave(object sender, System.EventArgs e)
        {
            btnSummary.BackColor = Color.White;
        }

        //View Progress button hover effect
        private void BtnViewProgress_MouseEnter(object sender, System.EventArgs e)
        {
            btnViewProgress.BackColor = ColorTranslator.FromHtml("#EFF6FF");
        }

        private void BtnViewProgress_MouseLeave(object sender, System.EventArgs e)
        {
            btnViewProgress.BackColor = Color.White;
        }
    }
}