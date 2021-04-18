using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDetail
{
    public partial class Form1 : Form
    {   

        #region "Constructor"
        
        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region "Events"

        /// <summary>
        /// Save student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        
        {
            if (txtFname.Text.Trim() == string.Empty)
            {
                MessageBox.Show(" err value");
                return;
            }
            if (Convert.ToString(cbDepartment.SelectedItem) == "")
            {
                MessageBox.Show(" Select Your Department ");
                return;
            }
            if (lbElectives.SelectedItems.Count == 0)
            {
                MessageBox.Show(" Select Your Electives");
                return;
            }
        }        
        private void btnCancel_Click(object sender, EventArgs e)
        
        {
            this.Close();
            dtpDOB.MaxDate = DateTime.Now.AddYears(-5);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dtpDOB.MaxDate = DateTime.Now.AddYears(-5);
            dtpDOB.MinDate = DateTime.Now.AddYears(-50);
            cbDepartment.Items.Add("Bcom(CA)");
            cbDepartment.Items.Add("Bsc(CS)");
            cbDepartment.Items.Add("BBA");
            cbDepartment.Items.Add("Bcom");
            cbDepartment.Items.Add("Bsc(IT)");
            lbElectives.Items.Add("French");
            lbElectives.Items.Add("Tamil");
            lbElectives.Items.Add("English");
        }

        #endregion
       
    }
}
