namespace TestGrid.Controls
{
    partial class CalendarTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radCalendar1 = new Telerik.WinControls.UI.RadCalendar();
            this.radButtonTextBox1 = new Telerik.WinControls.UI.RadButtonTextBox();
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radCalendar1
            // 
            this.radCalendar1.HeaderHeight = 28;
            this.radCalendar1.HeaderWidth = 28;
            this.radCalendar1.Location = new System.Drawing.Point(1, 68);
            this.radCalendar1.Name = "radCalendar1";
            this.radCalendar1.Size = new System.Drawing.Size(385, 340);
            this.radCalendar1.TabIndex = 0;
            this.radCalendar1.SelectionChanged += new System.EventHandler(this.radCalendar1_SelectionChanged);
            // 
            // radButtonTextBox1
            // 
            this.radButtonTextBox1.Location = new System.Drawing.Point(255, 439);
            this.radButtonTextBox1.Name = "radButtonTextBox1";
            this.radButtonTextBox1.Size = new System.Drawing.Size(150, 28);
            this.radButtonTextBox1.TabIndex = 1;
            this.radButtonTextBox1.Text = "radButtonTextBox1";
            this.radButtonTextBox1.TextChanged += new System.EventHandler(this.radButtonTextBox1_TextChanged);
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.CalendarSize = new System.Drawing.Size(290, 320);
            this.radDateTimePicker1.Location = new System.Drawing.Point(13, 13);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.Size = new System.Drawing.Size(205, 28);
            this.radDateTimePicker1.TabIndex = 2;
            this.radDateTimePicker1.TabStop = false;
            this.radDateTimePicker1.Text = "Thursday, December 2, 2021";
            this.radDateTimePicker1.Value = new System.DateTime(2021, 12, 2, 16, 34, 43, 488);
            // 
            // CalendarTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 510);
            this.Controls.Add(this.radDateTimePicker1);
            this.Controls.Add(this.radButtonTextBox1);
            this.Controls.Add(this.radCalendar1);
            this.Name = "CalendarTest";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "RadForm1";
            ((System.ComponentModel.ISupportInitialize)(this.radCalendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadCalendar radCalendar1;
        private Telerik.WinControls.UI.RadButtonTextBox radButtonTextBox1;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
    }
}
