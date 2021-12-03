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
    public partial class PlatiControl : Telerik.WinControls.UI.RadForm
    {
        public PlatiControl()
        {
            InitializeComponent();
            radDateTimePicker1.DateTimePickerElement.Calendar.HeaderNavigationMode = Telerik.WinControls.UI.HeaderNavigationMode.Zoom;
            radDateTimePicker1.DateTimePickerElement.Calendar.ZoomLevel = Telerik.WinControls.UI.ZoomLevel.Months;
            radDateTimePicker1.DateTimePickerElement.Calendar.ZoomChanging += Calendar_ZoomChanging;

            radDateTimePicker1.DateTimePickerElement.Calendar.SelectionChanged += Calendar_SelectionChanged;

            var calendar = radDateTimePicker1.DateTimePickerElement.Calendar;
            var dateSelected = calendar.FocusedDate;
            var month = dateSelected.Month;
            var year = dateSelected.Year;

            for (int i = 1; i <= calendar.CurrentCalendar.GetDaysInMonth(year, month); i++)
            {
                radGridView1.Columns.Add(String.Format("{0}/{1}/{2}", i.ToString(), month.ToString(), year.ToString()));
            }
        }

        private void Calendar_SelectionChanged(object sender, EventArgs e)
        {
            var calendar = radDateTimePicker1.DateTimePickerElement.Calendar;
            var dateSelected = calendar.SelectedDate;
            var month = dateSelected.Month;
            var year = dateSelected.Year;

            int colCnt = radGridView1.Columns.Count;
            if (colCnt > 2)
            {
                for (int i = colCnt - 1; i > 1; i--)
                {
                    radGridView1.Columns.RemoveAt(i);
                }
            }
            for (int i = 1; i <= calendar.CurrentCalendar.GetDaysInMonth(year, month); i++)
            {
                radGridView1.Columns.Add(String.Format("{0}/{1}/{2}", i.ToString(), month.ToString(), year.ToString()));
            }
        }

        private void Calendar_ZoomChanging(object sender, CalendarZoomChangingEventArgs e)
        {
            e.Cancel = true;
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
