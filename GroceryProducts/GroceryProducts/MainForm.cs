using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GroceryProducts
{
    public partial class MainForm : Form
    {
        public DataTable GroceryProductTable = new DataTable();

        public MainForm()
        {
            InitializeComponent();
        }
        bool veryFirstAttempt = true;
        
        /// <summary>
        /// Loads the data into the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    //if first attempt at loading data
                    if(veryFirstAttempt)
                    {
                        bool firstPassOfAttempt = false;
                        foreach (string line in File.ReadLines(file))
                        {
                            string[] tempData = line.Split(',');
                            
                            //first pass because of headers needed to be loaded
                            if (!firstPassOfAttempt)
                            {
                                firstPassOfAttempt = true;
                                foreach (string input in tempData)
                                    GroceryProductTable.Columns.Add(input, typeof(string));
                            }
                            else
                            {
                                //this is to prevent bad data from being added to the set
                                if (tempData.Length == 9)
                                    GroceryProductTable.Rows.Add(tempData);
                            }
                        }
                    }
                    //any time attempting to load data after headers in existance
                    else 
                    {
                        bool firstPassOfAttempt = false;
                        foreach (string line in File.ReadLines(file))
                        {
                            string[] tempData = line.Split(',');
                            
                            //first pass skip because of headers alrady exist
                            if (!firstPassOfAttempt)
                                firstPassOfAttempt = true;
                            else
                            {
                                //this is to prevent bad data from being added to the set
                                if (tempData.Length == 9)
                                {
                                    GroceryProductTable.Rows.Add(tempData);
                                }
                            }
                        }
                    }
                    veryFirstAttempt = false;
                    dgvDisplayTable.DataSource = GroceryProductTable;
                    dgvDisplayTable.Refresh();
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //TODO: These are adds ons that I would attempt to do with more time
        //TODO: Future case: checkboxes to toggle between AND and OR and NOT and NOT LIKE for multiple search criteria
            //psuedo code: using a or multiple check boxes
        //TODO: Future case: put options for search date criteria to be between dates, instead of exact
            //psuedo code: open a new search bar to the left for beginning date, and right for end date
            //psuedo code: that way user can search through a time instead of literal numbers
        //TODO: Future case: search across all columns for a specific input
            //psuedo code: put "all" under the criteria option
        //TODO: Future case: searching one column with multiple criterias
            //psuedo code: use a delimiter for "IN" instead of "AND" i.g. "Department IN ('Produce','Pharmacy','Electronic')";
        //TODO: Future case: store data into object GroceryProductData so that I can manipulate during run time
            //Class attached to project
        //TODO: Future case: put in more than 3 criteria in a more efficient way
            //psuedo code: one possible
            //psuedo code: concatinate all the strings into one then have a check for number of criterias
            //psuedo code: which then can, using a loop, apply the individual criterias seperated by AND
        //TODO: Future case: handle null selected criteria
            //psuedo code: possible: set default - do a null check - or - for select position 0
        //TODO: Future case: make a utility class to handle all the loading, editing, etc, the data.
            //class attached to project with comments of future things

        /// <summary>
        /// Searches for the item based off the choosen criterias
        /// The user can choose up to 3 criterias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //assumes 3 criteria is being used
            bool doCrit1 = true;
            bool doCrit2 = true;
            bool doCrit3 = true;
                       
            //if criteria is null, empty, or only white space then turn off
            if (string.IsNullOrEmpty(tbxSearchBarForCrit1.Text) || string.IsNullOrWhiteSpace(tbxSearchBarForCrit1.Text))
                doCrit1 = false;
            
            if (string.IsNullOrEmpty(tbxSearchBarForCrit2.Text) || string.IsNullOrWhiteSpace(tbxSearchBarForCrit2.Text))
                doCrit2 = false;
                
            if (string.IsNullOrEmpty(tbxSearchBarForCrit3.Text) || string.IsNullOrWhiteSpace(tbxSearchBarForCrit3.Text))
                doCrit3 = false;

            //based off how many criteria, check for it
            //
            if (doCrit1 && doCrit2 && doCrit3)
            {
                DataView theDV = new DataView(GroceryProductTable);
                //format: Criteria LIKE text AND ... repeat
                //format: {#} the # will be the index after the the ,
                //format: {#} the { } means contains
                //format: % % means it starts
                theDV.RowFilter = string.Format("{0} LIKE '%{1}%' AND {2} LIKE '%{3}%' AND {4} LIKE '%{5}%'", 
                        cbxCriteria1.Text, tbxSearchBarForCrit1.Text, 
                        cbxCriteria2.Text, tbxSearchBarForCrit2.Text,
                        cbxCriteria3.Text, tbxSearchBarForCrit3.Text);
                //data searching
                dgvDisplayTable.DataSource = theDV;

                
            }
            else if (doCrit1 && doCrit2)
            {
                DataView theDV = new DataView(GroceryProductTable);
                theDV.RowFilter = string.Format("{0} LIKE '%{1}%' AND {2} LIKE '%{3}%'", 
                    cbxCriteria1.Text, tbxSearchBarForCrit1.Text, 
                    cbxCriteria2.Text, tbxSearchBarForCrit2.Text);
                dgvDisplayTable.DataSource = theDV;
            }
            else if (doCrit1)
            {
                DataView theDV = new DataView(GroceryProductTable);
                theDV.RowFilter = string.Format("{0} LIKE '%{1}%'", 
                    cbxCriteria1.Text, tbxSearchBarForCrit1.Text);
                dgvDisplayTable.DataSource = theDV;   
            }
            //no criteria chosen
            else
            {
                MessageBox.Show("type something to search and choose a criteria", "error", MessageBoxButtons.OK);
            }

            //display to user how many searchs found
            lblSearchAmount.Text = (dgvDisplayTable.RowCount-1).ToString();
        }

        /// <summary>
        /// Clears the data from the table
        /// It doesn't remove the headers (possible set data to null to fix?)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearData_Click(object sender, EventArgs e)
        {
            GroceryProductTable.Clear();
            dgvDisplayTable.Refresh();
        }

        
    }
}
