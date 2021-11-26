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
            // TODO: This line of code loads data into the 'santierDataSet1.employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.santierDataSet1.employees);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Update(this.santierDataSet1.employees);
        }
    }
}
