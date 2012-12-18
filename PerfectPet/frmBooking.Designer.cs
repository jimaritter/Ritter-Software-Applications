namespace PerfectPet
{
    partial class frmBooking
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
            Telerik.WinControls.UI.AppointmentMappingInfo appointmentMappingInfo1 = new Telerik.WinControls.UI.AppointmentMappingInfo();
            Telerik.WinControls.UI.ResourceMappingInfo resourceMappingInfo1 = new Telerik.WinControls.UI.ResourceMappingInfo();
            Telerik.WinControls.UI.DateTimeInterval dateTimeInterval1 = new Telerik.WinControls.UI.DateTimeInterval();
            Telerik.WinControls.UI.SchedulerDailyPrintStyle schedulerDailyPrintStyle1 = new Telerik.WinControls.UI.SchedulerDailyPrintStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooking));
            this.schedulerBindingDataSource1 = new Telerik.WinControls.UI.SchedulerBindingDataSource();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.radSchedulerNavigator1 = new Telerik.WinControls.UI.RadSchedulerNavigator();
            this.scheduleBookings = new Telerik.WinControls.UI.RadScheduler();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.EventProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.ResourceProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // schedulerBindingDataSource1
            // 
            // 
            // 
            // 
            appointmentMappingInfo1.BackgroundId = "BackgroundId";
            appointmentMappingInfo1.Description = "Description";
            appointmentMappingInfo1.End = "EndDate";
            appointmentMappingInfo1.Location = "Location";
            appointmentMappingInfo1.MasterEventId = "MasterEventId";
            appointmentMappingInfo1.RecurrenceRule = "RecurrenceRule";
            appointmentMappingInfo1.ResourceId = "Resource_id";
            appointmentMappingInfo1.Resources = "Resources";
            appointmentMappingInfo1.Start = "Start";
            appointmentMappingInfo1.Summary = "Summary";
            appointmentMappingInfo1.UniqueId = "AppointmentId";
            appointmentMappingInfo1.Visible = "Visible";
            this.schedulerBindingDataSource1.EventProvider.Mapping = appointmentMappingInfo1;
            // 
            // 
            // 
            resourceMappingInfo1.Id = "Id";
            resourceMappingInfo1.Image = "Image";
            resourceMappingInfo1.Name = "Name";
            resourceMappingInfo1.Visible = "Visible";
            this.schedulerBindingDataSource1.ResourceProvider.Mapping = resourceMappingInfo1;
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            this.radSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(1044, 650);
            this.radSplitContainer1.TabIndex = 0;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.Text = "radSplitContainer1";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.radSchedulerNavigator1);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(1044, 106);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.3361669F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -218);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // radSchedulerNavigator1
            // 
            this.radSchedulerNavigator1.AssociatedScheduler = this.scheduleBookings;
            this.radSchedulerNavigator1.DateFormat = "yyyy/MM/dd";
            this.radSchedulerNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSchedulerNavigator1.Location = new System.Drawing.Point(0, 0);
            this.radSchedulerNavigator1.Name = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.NavigationStep = 7;
            this.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day;
            // 
            // 
            // 
            this.radSchedulerNavigator1.RootElement.StretchVertically = false;
            this.radSchedulerNavigator1.Size = new System.Drawing.Size(1044, 95);
            this.radSchedulerNavigator1.TabIndex = 0;
            this.radSchedulerNavigator1.Text = "radSchedulerNavigator1";
            this.radSchedulerNavigator1.ThemeName = "TelerikMetro";
            // 
            // scheduleBookings
            // 
            dateTimeInterval1.End = new System.DateTime(((long)(0)));
            dateTimeInterval1.Start = new System.DateTime(((long)(0)));
            this.scheduleBookings.AccessibleInterval = dateTimeInterval1;
            this.scheduleBookings.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Month;
            this.scheduleBookings.AppointmentTitleFormat = null;
            this.scheduleBookings.Culture = new System.Globalization.CultureInfo("en-US");
            this.scheduleBookings.DataSource = this.schedulerBindingDataSource1;
            this.scheduleBookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scheduleBookings.GroupType = Telerik.WinControls.UI.GroupType.None;
            this.scheduleBookings.HeaderFormat = "dd dddd";
            this.scheduleBookings.Location = new System.Drawing.Point(0, 0);
            this.scheduleBookings.Name = "scheduleBookings";
            schedulerDailyPrintStyle1.AppointmentFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            schedulerDailyPrintStyle1.DateEndRange = new System.DateTime(2012, 12, 15, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.DateHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            schedulerDailyPrintStyle1.DateStartRange = new System.DateTime(2012, 12, 10, 0, 0, 0, 0);
            schedulerDailyPrintStyle1.PageHeadingFont = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.scheduleBookings.PrintStyle = schedulerDailyPrintStyle1;
            this.scheduleBookings.ShowAllDayAppointmentStatus = true;
            this.scheduleBookings.Size = new System.Drawing.Size(1044, 541);
            this.scheduleBookings.TabIndex = 0;
            this.scheduleBookings.Text = "radScheduler1";
            this.scheduleBookings.ThemeName = "TelerikMetro";
            this.scheduleBookings.AppointmentSelected += new System.EventHandler<Telerik.WinControls.UI.SchedulerAppointmentEventArgs>(this.scheduleBookings_AppointmentSelected);
            ((Telerik.WinControls.UI.MonthViewVerticalHeader)(this.scheduleBookings.GetChildAt(0).GetChildAt(0).GetChildAt(1))).Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.scheduleBookings);
            this.splitPanel2.Location = new System.Drawing.Point(0, 109);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(1044, 541);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, 0.3361669F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 218);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 650);
            this.Controls.Add(this.radSplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfect Pet Kennel Management - Bookings";
            this.Load += new System.EventHandler(this.frmBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.EventProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerBindingDataSource1.ResourceProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            this.splitPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radSchedulerNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.SchedulerBindingDataSource schedulerBindingDataSource1;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.RadScheduler scheduleBookings;
        private Telerik.WinControls.UI.RadSchedulerNavigator radSchedulerNavigator1;
        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;

    }
}