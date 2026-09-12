using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace FIRSTBYTE_HACKATHON_2026
{
    public partial class FrmModuleTracker : Form
    {
        //Declare the list.
        private List<CstudentTracker> assignmentList = new List<CstudentTracker>();
        public FrmModuleTracker()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //declare.
            string status;
            // Create a new instance of a tracker class.
            CstudentTracker studentTracker = new CstudentTracker();
            
                //Assign form input values to the object properties.
                studentTracker._Module = txtModule.Text.Trim();
                studentTracker._AssignmentName = txtAssignmentName.Text.Trim();
                studentTracker._DueDate = dtpDueDate.Value;

                if (cmbStatus.SelectedIndex != -1)
                {
                    status = cmbStatus.SelectedItem.ToString();
                }
                else
                {
                    status = "Pending";
                }

                studentTracker._CompletionStatus = status;
            
         
            // Add to the list
            assignmentList.Add(studentTracker);

            //Call the method
            RefreshDataGrid();

        }

        private void RefreshDataGrid()
        {
            // Clear existing items to prevent duplicates.
            lstAssignments.Items.Clear();

            //Display  the data into the user. 
            foreach (CstudentTracker item in assignmentList)
            {
               
                string displayString = $"{item._Module} - {item._AssignmentName} ({item._DueDate.ToShortDateString()}) [{item._CompletionStatus}]";
                lstAssignments.Items.Add(displayString);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if an item is actually selected in the list box
            if (lstAssignments.SelectedIndex != -1)
            {
                // Get the index of the selected item
                int selectedIndex = lstAssignments.SelectedIndex;

                // Remove the item from the master list using the same index
                assignmentList.RemoveAt(selectedIndex);

                // Refresh the ListBox display to reflect the deletion
                RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("Please select an assignment to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Capture the search keyword and convert to lowercase for case-insensitive matching
            string searchTerm = txtSearch.Text.Trim().ToLower();

            // Clear current items in the list box
            lstAssignments.Items.Clear();

            // If the search box is empty, reload all records via RefreshDataGrid
            if (string.IsNullOrEmpty(searchTerm))
            {
                RefreshDataGrid();
                return;
            }

            // Loop through the master list to find matching records
            foreach (CstudentTracker item in assignmentList)
            {
                // Check if the search term matches either the module code or the assignment name
                if (item._Module.ToLower().Contains(searchTerm) || item._AssignmentName.ToLower().Contains(searchTerm))
                {
                    string displayString = $"{item._Module} - {item._AssignmentName} ({item._DueDate.ToShortDateString()}) [{item._CompletionStatus}]";
                    lstAssignments.Items.Add(displayString);
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // Sort the master list by due date in ascending order using LINQ
            assignmentList = assignmentList.OrderBy(x => x._DueDate).ToList();

            // Refresh the ListBox display to show the sorted items
            RefreshDataGrid();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            // Capture the search target from the input box
            string target = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(target))
            {
                MessageBox.Show("Please enter a value to find.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Search through the list to find the matching item index
            int foundIndex = -1;
            for (int i = 0; i < assignmentList.Count; i++)
            {
                if (assignmentList[i]._Module.ToLower().Contains(target) || assignmentList[i]._AssignmentName.ToLower().Contains(target))
                {
                    foundIndex = i;
                    break; // Stop at the first match
                }
            }

            // If found, highlight/select it directly in the ListBox
            if (foundIndex != -1)
            {
                lstAssignments.SelectedIndex = foundIndex;
            }
            else
            {
                MessageBox.Show("No matching assignment found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void radModule_CheckedChanged(object sender, EventArgs e)
        {
            // Check if the radio button is selected, then sort and refresh
            if (radModule.Checked)
            {
                assignmentList = assignmentList.OrderBy(x => x._Module).ToList();
                RefreshDataGrid();
            }
        }

        private void radDateAsc_CheckedChanged(object sender, EventArgs e)
        {
            if (radDateAsc.Checked)
            {
                // Sort the list by due date in ascending order
                assignmentList = assignmentList.OrderBy(x => x._DueDate).ToList();
                RefreshDataGrid();
            }
        }

        private void radDateDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (radDateDesc.Checked)
            {
                // Sort the list by due date in descending order
                assignmentList = assignmentList.OrderByDescending(x => x._DueDate).ToList();
                RefreshDataGrid();
            }
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            int totalAssignments = assignmentList.Count;
            int overdueCount = 0;

            // Count overdue assignments based on the current date
            foreach (CstudentTracker item in assignmentList)
            {
                if (item._DueDate.Date < DateTime.Now.Date && !item._CompletionStatus.Equals("Completed", StringComparison.OrdinalIgnoreCase))
                {
                    overdueCount++;
                }
            }

            // Display total and overdue matching the dashboard layout
            lblDashboardSummary.Text = $"Total: {totalAssignments} | Overdue: {overdueCount}";

            // Calculate specific module progress percentage (e.g., for a selected module or overall completion)
            if (totalAssignments > 0)
            {
                int completedCount = assignmentList.Count(x => x._CompletionStatus.Equals("Completed", StringComparison.OrdinalIgnoreCase));
                int percentage = (completedCount * 100) / totalAssignments;
                lblModuleProgress.Text = $"Module Progress: {percentage}%";
            }
            else
            {
                lblModuleProgress.Text = "Module Progress: 0%";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Assignments saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        private void FrmModuleTracker_Load(object sender, EventArgs e)
        {
           
        }

        private void grpInputFormArea_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
