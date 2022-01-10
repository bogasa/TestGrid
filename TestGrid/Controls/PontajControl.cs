using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Data.SqlClient;

namespace TestGrid.Controls
{
    public partial class PontajControl : Telerik.WinControls.UI.RadForm
    {
        private SqlConnection sqlConn;
        private SqlDataAdapter dbDataAdapter;
        private DataTable dtPlati;
        public PontajControl()
        {
            sqlConn = new SqlConnection(Properties.Settings.Default.santierConnectionString);
            dbDataAdapter = new SqlDataAdapter("SELECT t.Timesheetid, t.EmployeeId, e.FirstName, e.LastName AS Employee FROM employees e LEFT JOIN timesheets t on t.EmployeeId = e.EmployeeId", sqlConn);
            dtPlati = new DataTable();

            InitializeComponent();
            radDateTimePicker1.DateTimePickerElement.Calendar.HeaderNavigationMode = Telerik.WinControls.UI.HeaderNavigationMode.Zoom;
            radDateTimePicker1.DateTimePickerElement.Calendar.ZoomLevel = Telerik.WinControls.UI.ZoomLevel.Months;
            radDateTimePicker1.DateTimePickerElement.Calendar.ZoomChanging += Calendar_ZoomChanging;

            radDateTimePicker1.DateTimePickerElement.Calendar.SelectionChanged += Calendar_SelectionChanged;


            var calendar = radDateTimePicker1.DateTimePickerElement.Calendar;
            var dateSelected = calendar.FocusedDate;
            var month = dateSelected.Month;
            var year = dateSelected.Year;

            dbDataAdapter.Fill(dtPlati);
            radGridView1.DataSource = dtPlati;

            for (int i = 1; i <= calendar.CurrentCalendar.GetDaysInMonth(year, month); i++)
            {
                radGridView1.Columns.Add(String.Format("{0}/{1}", i.ToString(), month.ToString()));
                radGridView1.Columns[i].Width = 40;
            }
            radGridView1.Columns.Add("Total");
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
                for (int i = colCnt - 1; i > 4; i--)
                {
                    radGridView1.Columns.RemoveAt(i);
                }
            }
            for (int i = 1; i <= calendar.CurrentCalendar.GetDaysInMonth(year, month); i++)
            {
                radGridView1.Columns.Add(String.Format("{0}/{1}", i.ToString(), month.ToString()));
                radGridView1.Columns[i].Width = 40;
            }
            radGridView1.Columns.Add("Total");
        }

        private void Calendar_ZoomChanging(object sender, CalendarZoomChangingEventArgs e)
        {
            e.Cancel = true;
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'santierDataSet.timesheets' table. You can move, or remove it, as needed.
            this.timesheetsTableAdapter.Fill(this.santierDataSet.timesheets);

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.timesheetsTableAdapter.Update(this.santierDataSet.timesheets);
        }
    }
}
