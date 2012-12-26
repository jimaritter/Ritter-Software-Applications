namespace PerfectPet
{
    partial class frmArrivalDeparture
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn4 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.tabParent = new Telerik.WinControls.UI.RadPageView();
            this.tabArrivals = new Telerik.WinControls.UI.RadPageViewPage();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.gridArrivals = new Telerik.WinControls.UI.RadGridView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.tabDepartures = new Telerik.WinControls.UI.RadPageViewPage();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.gridDepartures = new Telerik.WinControls.UI.RadGridView();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabParent)).BeginInit();
            this.tabParent.SuspendLayout();
            this.tabArrivals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArrivals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridArrivals.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.tabDepartures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartures.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // tabParent
            // 
            this.tabParent.Controls.Add(this.tabArrivals);
            this.tabParent.Controls.Add(this.tabDepartures);
            this.tabParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabParent.Location = new System.Drawing.Point(0, 0);
            this.tabParent.Name = "tabParent";
            this.tabParent.SelectedPage = this.tabArrivals;
            this.tabParent.Size = new System.Drawing.Size(861, 389);
            this.tabParent.TabIndex = 0;
            this.tabParent.Text = "radPageView1";
            this.tabParent.ThemeName = "TelerikMetro";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.tabParent.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            // 
            // tabArrivals
            // 
            this.tabArrivals.Controls.Add(this.btnClose);
            this.tabArrivals.Controls.Add(this.radGroupBox1);
            this.tabArrivals.Controls.Add(this.radLabel1);
            this.tabArrivals.Location = new System.Drawing.Point(5, 31);
            this.tabArrivals.Name = "tabArrivals";
            this.tabArrivals.Size = new System.Drawing.Size(851, 353);
            this.tabArrivals.Text = "Arrivals";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.gridArrivals);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Arrivals";
            this.radGroupBox1.Location = new System.Drawing.Point(21, 53);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 22, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 22, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(810, 246);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Arrivals";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            // 
            // gridArrivals
            // 
            this.gridArrivals.Location = new System.Drawing.Point(29, 25);
            // 
            // gridArrivals
            // 
            this.gridArrivals.MasterTemplate.AllowAddNewRow = false;
            this.gridArrivals.MasterTemplate.AllowDeleteRow = false;
            this.gridArrivals.MasterTemplate.AllowDragToGroup = false;
            this.gridArrivals.MasterTemplate.AllowEditRow = false;
            this.gridArrivals.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn2.FieldName = "Name";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Name";
            gridViewTextBoxColumn2.Name = "Name";
            gridViewTextBoxColumn2.Width = 148;
            gridViewTextBoxColumn3.FieldName = "Description";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Description";
            gridViewTextBoxColumn3.Name = "Description";
            gridViewTextBoxColumn3.Width = 148;
            gridViewTextBoxColumn4.FieldName = "Notes";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Notes";
            gridViewTextBoxColumn4.Name = "Notes";
            gridViewTextBoxColumn4.Width = 148;
            gridViewDateTimeColumn1.FieldName = "ArriveDate";
            gridViewDateTimeColumn1.FormatString = "";
            gridViewDateTimeColumn1.HeaderText = "Date";
            gridViewDateTimeColumn1.Name = "ArriveDate";
            gridViewDateTimeColumn1.Width = 148;
            gridViewDateTimeColumn2.FieldName = "ArriveTime";
            gridViewDateTimeColumn2.FormatString = "";
            gridViewDateTimeColumn2.HeaderText = "Time";
            gridViewDateTimeColumn2.Name = "ArriveTime";
            gridViewDateTimeColumn2.Width = 145;
            this.gridArrivals.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2});
            this.gridArrivals.MasterTemplate.EnableGrouping = false;
            this.gridArrivals.Name = "gridArrivals";
            this.gridArrivals.Size = new System.Drawing.Size(755, 200);
            this.gridArrivals.TabIndex = 0;
            this.gridArrivals.ThemeName = "TelerikMetro";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(21, 15);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(106, 21);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Todays Arrivals";
            // 
            // tabDepartures
            // 
            this.tabDepartures.Controls.Add(this.radGroupBox2);
            this.tabDepartures.Controls.Add(this.radLabel2);
            this.tabDepartures.Location = new System.Drawing.Point(5, 31);
            this.tabDepartures.Name = "tabDepartures";
            this.tabDepartures.Size = new System.Drawing.Size(851, 319);
            this.tabDepartures.Text = "Departures";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.gridDepartures);
            this.radGroupBox2.FooterImageIndex = -1;
            this.radGroupBox2.FooterImageKey = "";
            this.radGroupBox2.HeaderImageIndex = -1;
            this.radGroupBox2.HeaderImageKey = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox2.HeaderText = "Arrivals";
            this.radGroupBox2.Location = new System.Drawing.Point(22, 55);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(2, 22, 2, 2);
            // 
            // 
            // 
            this.radGroupBox2.RootElement.Padding = new System.Windows.Forms.Padding(2, 22, 2, 2);
            this.radGroupBox2.Size = new System.Drawing.Size(807, 246);
            this.radGroupBox2.TabIndex = 3;
            this.radGroupBox2.Text = "Arrivals";
            this.radGroupBox2.ThemeName = "TelerikMetro";
            // 
            // gridDepartures
            // 
            this.gridDepartures.Location = new System.Drawing.Point(26, 23);
            // 
            // 
            // 
            this.gridDepartures.MasterTemplate.AllowAddNewRow = false;
            this.gridDepartures.MasterTemplate.AllowDeleteRow = false;
            this.gridDepartures.MasterTemplate.AllowDragToGroup = false;
            this.gridDepartures.MasterTemplate.AllowEditRow = false;
            this.gridDepartures.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn5.FieldName = "Id";
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "Id";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "Id";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn6.FieldName = "Name";
            gridViewTextBoxColumn6.FormatString = "";
            gridViewTextBoxColumn6.HeaderText = "Name";
            gridViewTextBoxColumn6.Name = "Name";
            gridViewTextBoxColumn6.Width = 148;
            gridViewTextBoxColumn7.FieldName = "Description";
            gridViewTextBoxColumn7.FormatString = "";
            gridViewTextBoxColumn7.HeaderText = "Description";
            gridViewTextBoxColumn7.Name = "Description";
            gridViewTextBoxColumn7.Width = 148;
            gridViewTextBoxColumn8.FieldName = "Notes";
            gridViewTextBoxColumn8.FormatString = "";
            gridViewTextBoxColumn8.HeaderText = "Notes";
            gridViewTextBoxColumn8.Name = "Notes";
            gridViewTextBoxColumn8.Width = 148;
            gridViewDateTimeColumn3.FieldName = "DepartureDate";
            gridViewDateTimeColumn3.FormatString = "";
            gridViewDateTimeColumn3.HeaderText = "Date";
            gridViewDateTimeColumn3.Name = "DepartureDate";
            gridViewDateTimeColumn3.Width = 148;
            gridViewDateTimeColumn4.FieldName = "DepartureTime";
            gridViewDateTimeColumn4.FormatString = "";
            gridViewDateTimeColumn4.HeaderText = "Time";
            gridViewDateTimeColumn4.Name = "DepartureTime";
            gridViewDateTimeColumn4.Width = 145;
            this.gridDepartures.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewDateTimeColumn3,
            gridViewDateTimeColumn4});
            this.gridDepartures.MasterTemplate.EnableGrouping = false;
            this.gridDepartures.Name = "gridDepartures";
            this.gridDepartures.Size = new System.Drawing.Size(755, 200);
            this.gridDepartures.TabIndex = 1;
            this.gridDepartures.ThemeName = "TelerikMetro";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radLabel2.Location = new System.Drawing.Point(22, 17);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(106, 21);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Todays Arrivals";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(360, 317);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 24);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.ThemeName = "TelerikMetro";
            // 
            // frmArrivalDeparture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(861, 389);
            this.Controls.Add(this.tabParent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmArrivalDeparture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arrivals and Departures";
            this.Load += new System.EventHandler(this.frmArrivalDeparture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabParent)).EndInit();
            this.tabParent.ResumeLayout(false);
            this.tabArrivals.ResumeLayout(false);
            this.tabArrivals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridArrivals.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridArrivals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.tabDepartures.ResumeLayout(false);
            this.tabDepartures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartures.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadPageView tabParent;
        private Telerik.WinControls.UI.RadPageViewPage tabArrivals;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadPageViewPage tabDepartures;
        private Telerik.WinControls.UI.RadGridView gridArrivals;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadGridView gridDepartures;
        private Telerik.WinControls.UI.RadButton btnClose;
    }
}