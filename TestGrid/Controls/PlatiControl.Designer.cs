namespace TestGrid.Controls
{
    partial class PlatiControl
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.santierDataSet = new TestGrid.santierDataSet();
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.paymentsTableAdapter = new TestGrid.santierDataSetTableAdapters.paymentsTableAdapter();
            this.radPanelMain = new Telerik.WinControls.UI.RadPanel();
            this.radPanelTop = new Telerik.WinControls.UI.RadPanel();
            this.radPanelLeft = new Telerik.WinControls.UI.RadPanel();
            this.radPanelBottom = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.santierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelMain)).BeginInit();
            this.radPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTop)).BeginInit();
            this.radPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelLeft)).BeginInit();
            this.radPanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelBottom)).BeginInit();
            this.radPanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radButton1.Location = new System.Drawing.Point(0, 0);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(592, 40);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "Salveaza";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.Color.Black;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(0, 0);
            this.radGridView1.Margin = new System.Windows.Forms.Padding(4);
            // 
            // 
            // 
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "PaymentID";
            gridViewDecimalColumn1.HeaderText = "PaymentID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.MinWidth = 80;
            gridViewDecimalColumn1.Name = "PaymentID";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.Width = 100;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "EmployeeID";
            gridViewDecimalColumn2.HeaderText = "EmployeeID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.MinWidth = 80;
            gridViewDecimalColumn2.Name = "EmployeeID";
            gridViewDecimalColumn2.Width = 100;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.FieldName = "Amount";
            gridViewDecimalColumn3.HeaderText = "Amount";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.MinWidth = 60;
            gridViewDecimalColumn3.Name = "Amount";
            gridViewDecimalColumn3.Width = 60;
            gridViewDateTimeColumn1.FieldName = "PaymentDate";
            gridViewDateTimeColumn1.HeaderText = "PaymentDate";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.MinWidth = 80;
            gridViewDateTimeColumn1.Name = "PaymentDate";
            gridViewDateTimeColumn1.Width = 100;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDateTimeColumn1});
            this.radGridView1.MasterTemplate.DataSource = this.paymentsBindingSource;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.radGridView1.RootElement.MaxSize = new System.Drawing.Size(0, 0);
            this.radGridView1.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.radGridView1.Size = new System.Drawing.Size(592, 340);
            this.radGridView1.TabIndex = 2;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "payments";
            this.paymentsBindingSource.DataSource = this.santierDataSet;
            // 
            // santierDataSet
            // 
            this.santierDataSet.DataSetName = "santierDataSet";
            this.santierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.CalendarSize = new System.Drawing.Size(290, 320);
            this.radDateTimePicker1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.radDateTimePicker1.CustomFormat = "MMMM yyyy";
            this.radDateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.radDateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.radDateTimePicker1.TabIndex = 3;
            this.radDateTimePicker1.TabStop = false;
            this.radDateTimePicker1.Text = "December 2021";
            this.radDateTimePicker1.Value = new System.DateTime(2021, 12, 1, 0, 0, 0, 0);
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // radPanelMain
            // 
            this.radPanelMain.Controls.Add(this.radGridView1);
            this.radPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanelMain.Location = new System.Drawing.Point(0, 24);
            this.radPanelMain.Name = "radPanelMain";
            this.radPanelMain.Size = new System.Drawing.Size(592, 340);
            this.radPanelMain.TabIndex = 1;
            // 
            // radPanelTop
            // 
            this.radPanelTop.Controls.Add(this.radPanelLeft);
            this.radPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanelTop.Location = new System.Drawing.Point(0, 0);
            this.radPanelTop.Name = "radPanelTop";
            this.radPanelTop.Size = new System.Drawing.Size(592, 24);
            this.radPanelTop.TabIndex = 2;
            // 
            // radPanelLeft
            // 
            this.radPanelLeft.Controls.Add(this.radDateTimePicker1);
            this.radPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.radPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.radPanelLeft.Name = "radPanelLeft";
            this.radPanelLeft.Size = new System.Drawing.Size(200, 24);
            this.radPanelLeft.TabIndex = 4;
            // 
            // radPanelBottom
            // 
            this.radPanelBottom.Controls.Add(this.radButton1);
            this.radPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanelBottom.Location = new System.Drawing.Point(0, 364);
            this.radPanelBottom.Name = "radPanelBottom";
            this.radPanelBottom.Size = new System.Drawing.Size(592, 40);
            this.radPanelBottom.TabIndex = 3;
            // 
            // PlatiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(592, 404);
            this.Controls.Add(this.radPanelMain);
            this.Controls.Add(this.radPanelTop);
            this.Controls.Add(this.radPanelBottom);
            this.Name = "PlatiControl";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Plati";
            this.Load += new System.EventHandler(this.PlatiControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.santierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelMain)).EndInit();
            this.radPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelTop)).EndInit();
            this.radPanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanelLeft)).EndInit();
            this.radPanelLeft.ResumeLayout(false);
            this.radPanelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelBottom)).EndInit();
            this.radPanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private santierDataSet santierDataSet;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private santierDataSetTableAdapters.paymentsTableAdapter paymentsTableAdapter;
        private Telerik.WinControls.UI.RadPanel radPanelMain;
        private Telerik.WinControls.UI.RadPanel radPanelTop;
        private Telerik.WinControls.UI.RadPanel radPanelBottom;
        private Telerik.WinControls.UI.RadPanel radPanelLeft;
    }
}
