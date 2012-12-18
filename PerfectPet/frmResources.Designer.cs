namespace PerfectPet
{
    partial class frmResources
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
            this.gridResources = new Telerik.WinControls.UI.RadGridView();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtDescription = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txtName = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            ((System.ComponentModel.ISupportInitialize)(this.gridResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResources.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridResources
            // 
            this.gridResources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridResources.Location = new System.Drawing.Point(0, 0);
            // 
            // gridResources
            // 
            this.gridResources.MasterTemplate.AllowAddNewRow = false;
            this.gridResources.MasterTemplate.AllowDeleteRow = false;
            this.gridResources.MasterTemplate.AllowDragToGroup = false;
            this.gridResources.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
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
            gridViewTextBoxColumn2.Width = 214;
            gridViewTextBoxColumn3.FieldName = "Description";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Description";
            gridViewTextBoxColumn3.Name = "Description";
            gridViewTextBoxColumn3.Width = 260;
            this.gridResources.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.gridResources.Name = "gridResources";
            this.gridResources.Size = new System.Drawing.Size(495, 174);
            this.gridResources.TabIndex = 0;
            this.gridResources.Text = "radGridView1";
            this.gridResources.ThemeName = "TelerikMetro";
            this.gridResources.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gridResources_CellEndEdit);
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
            this.radSplitContainer1.Size = new System.Drawing.Size(495, 303);
            this.radSplitContainer1.TabIndex = 1;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.Text = "radSplitContainer1";
            this.radSplitContainer1.ThemeName = "Office2010Silver";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.radButton1);
            this.splitPanel1.Controls.Add(this.radLabel3);
            this.splitPanel1.Controls.Add(this.radLabel1);
            this.splitPanel1.Controls.Add(this.txtDescription);
            this.splitPanel1.Controls.Add(this.txtName);
            this.splitPanel1.Controls.Add(this.radLabel2);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(495, 126);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.08017493F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -18);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            this.splitPanel1.ThemeName = "TelerikMetro";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(201, 91);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(93, 24);
            this.radButton1.TabIndex = 8;
            this.radButton1.Text = "Save";
            this.radButton1.ThemeName = "TelerikMetro";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(178, 35);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(66, 18);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "Description:";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(15, 35);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(39, 18);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "Name:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(178, 59);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(280, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 20);
            this.txtName.TabIndex = 2;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radLabel2.Location = new System.Drawing.Point(12, 8);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(155, 21);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Resource Management";
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.gridResources);
            this.splitPanel2.Location = new System.Drawing.Point(0, 129);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(495, 174);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, 0.08017493F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 18);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            this.splitPanel2.ThemeName = "Office2010Silver";
            // 
            // frmResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 303);
            this.Controls.Add(this.radSplitContainer1);
            this.Name = "frmResources";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resource Management";
            this.Load += new System.EventHandler(this.frmResources_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridResources.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            this.splitPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridResources;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBoxControl txtDescription;
        private Telerik.WinControls.UI.RadTextBoxControl txtName;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
    }
}