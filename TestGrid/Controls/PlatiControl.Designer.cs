﻿namespace TestGrid.Controls
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
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.santierDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.santierDataSet = new TestGrid.santierDataSet();
            this.paymentsTableAdapter1 = new TestGrid.santierDataSetTableAdapters.PaymentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.santierDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.santierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radButton1.Location = new System.Drawing.Point(0, 368);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(592, 36);
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
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "PaymentID";
            gridViewDecimalColumn1.HeaderText = "PaymentID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.MinWidth = 8;
            gridViewDecimalColumn1.Name = "PaymentID";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn1.Width = 102;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "EmployeeID";
            gridViewDecimalColumn2.HeaderText = "EmployeeID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.MinWidth = 8;
            gridViewDecimalColumn2.Name = "EmployeeID";
            gridViewDecimalColumn2.Width = 113;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "SumaPlata";
            gridViewDecimalColumn3.HeaderText = "SumaPlata";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.MinWidth = 8;
            gridViewDecimalColumn3.Name = "SumaPlata";
            gridViewDecimalColumn3.Width = 173;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "DataPlata";
            gridViewDateTimeColumn1.HeaderText = "DataPlata";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.MinWidth = 8;
            gridViewDateTimeColumn1.Name = "DataPlata";
            gridViewDateTimeColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Descending;
            gridViewDateTimeColumn1.Width = 174;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewDateTimeColumn1});
            this.radGridView1.MasterTemplate.DataSource = this.santierDataSetBindingSource;
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "DataPlata";
            this.radGridView1.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(592, 368);
            this.radGridView1.TabIndex = 2;
            // 
            // santierDataSetBindingSource
            // 
            this.santierDataSetBindingSource.DataMember = "Payments";
            this.santierDataSetBindingSource.DataSource = this.santierDataSet;
            // 
            // santierDataSet
            // 
            this.santierDataSet.DataSetName = "santierDataSet";
            this.santierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsTableAdapter1
            // 
            this.paymentsTableAdapter1.ClearBeforeFill = true;
            // 
            // PlatiControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(592, 404);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radButton1);
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
            ((System.ComponentModel.ISupportInitialize)(this.santierDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.santierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.BindingSource santierDataSetBindingSource;
        private santierDataSet santierDataSet;
        private santierDataSetTableAdapters.PaymentsTableAdapter paymentsTableAdapter1;
    }
}
