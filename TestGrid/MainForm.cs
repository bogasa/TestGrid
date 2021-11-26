using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace TestGrid
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        public MainForm()
        {
            InitializeComponent();
            Control angajatiControl = new AngajatiControl();
            radPageView1.Pages[0].Controls.Add(angajatiControl);
            angajatiControl.Dock = DockStyle.Fill;
            angajatiControl.Height = radPageView1.Pages[0].Height;
        }
    }
}
