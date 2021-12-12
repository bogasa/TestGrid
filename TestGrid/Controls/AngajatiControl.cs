using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace TestGrid
{
    public partial class AngajatiControl : Telerik.WinControls.UI.RadForm
    {
        public AngajatiControl()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'santierDataSet.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.santierDataSet.employees);

            //this.radGridView1.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            //this.radGridView1.Columns["FirstName"].Width = 100;
            //this.radGridView1.Columns["LastName"].Width = 100;
            //this.radGridView1.Columns["Title"].Width = 70;
            //this.radGridView1.Columns["HireDate"].Width = 70;
            //this.radGridView1.Columns["Address"].Width = 110;
            //this.radGridView1.Columns["City"].Width = 110;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Update(this.santierDataSet.employees);
        }
    }
}
