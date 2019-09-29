using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenchmarkApp_6503Gin
{
    //Methods for responding to UI interactions
    public partial class Form1 : Form
    {
        List<Staff> staff = new List<Staff>(); 

        public Form1()
        {
            InitializeComponent();
        }

        //When load button is clicked, load in staff details from the file
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            staff.Clear();

            FileManager fm = new FileManager();

            staff = fm.LoadStaff();

            if (staff == null)
            {
                MessageBox.Show("Error Loading Staff", "File IO Error");
            }
            else
            {
                lbxStaff.Items.Clear();
                lbxStaff.Items.AddRange(staff.ToArray());
            }
        }

        //When the AZ button is clicked, sort the staff information alphabetically, in descending order
        private void SortAZ_Click(object sender, EventArgs e)
        {
            Filter cFilter = new Filter();

            staff = cFilter.SortAZ(staff);

            lbxStaff.Items.Clear();
            lbxStaff.Items.AddRange(staff.ToArray());
        }

        //When the ZA button is clicked, sort the staff information alphabetically, in ascending order
        private void SortZA_Click(object sender, EventArgs e)
        {
            Filter cFilter = new Filter();

            staff = cFilter.SortZA(staff);

            lbxStaff.Items.Clear();
            lbxStaff.Items.AddRange(staff.ToArray());
        }

        //When the search button is clicked, capture the text in the search text box and filter the results according to that text.
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            List<Staff> results = new List<Staff>();

            Filter cFilter = new Filter();

            string term = tbxSearch.Text;

            results = cFilter.Search(staff, term);

            lbxSearchResults.Items.Clear();
            lbxSearchResults.Items.AddRange(results.ToArray());
        }

        //When the save button is clicked, save the staff information to a text file. If the user chooses to view the file, open the saved text file.
        private void BtnSave_Click(object sender, EventArgs e)
        {

            try
            {
                FileManager fm = new FileManager();

                Staff c = (Staff)lbxSearchResults.SelectedItem;

                string fileName = c.FirstName + c.LastName + c.StaffID + ".txt";

                bool result = fm.SaveStaff(c, fileName);

                if (result == false)
                {
                    MessageBox.Show("Error Saving Staff", "File IO Error");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("View File?", "Save Success", MessageBoxButtons.YesNo);

                    if (dr.Equals(DialogResult.Yes))
                    {
                        System.Diagnostics.Process.Start(fileName);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a staff member", "Error");
            }
        }

        //If user clicks item in the staff last, display staff information in the text boxes.
        private void LbxSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Staff c = (Staff)lbxSearchResults.SelectedItem;

                tbxName.Text = c.FirstName + " " + c.LastName;
                tbxStaffID.Text = c.StaffID.ToString();
                tbxDOB.Text = c.DateOfBirth;
                tbxEmail.Text = c.Email;
                tbxSalary.Text = c.Salary.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
