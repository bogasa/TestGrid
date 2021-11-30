using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using TestGrid.Controls;

namespace TestGrid
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        public MainForm()
        {
            InitializeComponent();
            AngajatiControl angajatiControl = new AngajatiControl();
            angajatiControl.TopLevel = false;
            radPageViewPage1.Controls.Add(angajatiControl);
            angajatiControl.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            angajatiControl.Dock = DockStyle.Fill;
            angajatiControl.Show();

            PontajControl pontajControl = new PontajControl();
            pontajControl.TopLevel = false;
            radPageViewPage2.Controls.Add(pontajControl);
            pontajControl.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pontajControl.Dock = DockStyle.Fill;
            pontajControl.Show();

            PlatiControl platiControl = new PlatiControl();
            platiControl.TopLevel = false;
            radPageViewPage3.Controls.Add(platiControl);
            platiControl.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            platiControl.Dock = DockStyle.Fill;
            platiControl.Show();

            //radPageView1.Pages[0].Controls.Add(angajatiControl);
            //angajatiControl.Dock = DockStyle.Fill;
            //angajatiControl.Height = radPageView1.Pages[0].Height;
        }
    }
}