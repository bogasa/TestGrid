using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace TestGrid.Controls
{
    public partial class PontajControl : Telerik.WinControls.UI.RadForm
    {
        public PontajControl()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'santierDataSet.timesheets' table. You can move, or remove it, as needed.
            this.timesheetsTableAdapter.Fill(this.santierDataSet.timesheets);
            // TODO: This line of code loads data into the 'santierDataSet.timesheets' table. You can move, or remove it, as needed.
            //this.timesheetsTableAdapter.Fill(this.santierDataSet.timesheets);

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.timesheetsTableAdapter.Update(this.santierDataSet.timesheets);
        }
    }
}
