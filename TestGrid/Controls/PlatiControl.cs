using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace TestGrid.Controls
{
    public partial class PlatiControl : Telerik.WinControls.UI.RadForm
    {
        public PlatiControl()
        {
            InitializeComponent();
            radDateTimePicker1.DateTimePickerElement.Calendar.HeaderNavigationMode = Telerik.WinControls.UI.HeaderNavigationMode.Zoom;
            radDateTimePicker1.DateTimePickerElement.Calendar.ZoomLevel = Telerik.WinControls.UI.ZoomLevel.Months;
        }

        private void PlatiControl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'santierDataSet.employees' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter1.Fill(this.santierDataSet.Payments);

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.paymentsTableAdapter1.Update(this.santierDataSet.Payments);
        }

    }
}
