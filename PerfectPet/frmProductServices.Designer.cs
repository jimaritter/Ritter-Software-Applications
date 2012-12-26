namespace PerfectPet
{
    partial class frmProductServices
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn5 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn6 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn7 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn8 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn7 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn8 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            this.tabParent = new Telerik.WinControls.UI.RadPageView();
            this.tabProducts = new Telerik.WinControls.UI.RadPageViewPage();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.gridProducts = new Telerik.WinControls.UI.RadGridView();
            this.radLabel17 = new Telerik.WinControls.UI.RadLabel();
            this.tabServices = new Telerik.WinControls.UI.RadPageViewPage();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.gridServices = new Telerik.WinControls.UI.RadGridView();
            this.radLabel18 = new Telerik.WinControls.UI.RadLabel();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.btnClose = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabParent)).BeginInit();
            this.tabParent.SuspendLayout();
            this.tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel17)).BeginInit();
            this.tabServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridServices.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // tabParent
            // 
            this.tabParent.Controls.Add(this.tabProducts);
            this.tabParent.Controls.Add(this.tabServices);
            this.tabParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabParent.Location = new System.Drawing.Point(0, 0);
            this.tabParent.Name = "tabParent";
            this.tabParent.SelectedPage = this.tabProducts;
            this.tabParent.Size = new System.Drawing.Size(849, 443);
            this.tabParent.TabIndex = 0;
            this.tabParent.Text = "radPageView1";
            this.tabParent.ThemeName = "TelerikMetro";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.tabParent.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.btnClose);
            this.tabProducts.Controls.Add(this.radGroupBox1);
            this.tabProducts.Controls.Add(this.radLabel17);
            this.tabProducts.Location = new System.Drawing.Point(5, 31);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Size = new System.Drawing.Size(839, 407);
            this.tabProducts.Text = "Products";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.gridProducts);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Current Products";
            this.radGroupBox1.Location = new System.Drawing.Point(16, 53);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 22, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 22, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(805, 285);
            this.radGroupBox1.TabIndex = 32;
            this.radGroupBox1.Text = "Current Products";
            this.radGroupBox1.ThemeName = "TelerikMetro";
            // 
            // gridProducts
            // 
            this.gridProducts.BackColor = System.Drawing.Color.White;
            this.gridProducts.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridProducts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridProducts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridProducts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridProducts.Location = new System.Drawing.Point(34, 34);
            // 
            // gridProducts
            // 
            this.gridProducts.MasterTemplate.AllowColumnChooser = false;
            this.gridProducts.MasterTemplate.AllowDeleteRow = false;
            this.gridProducts.MasterTemplate.AllowDragToGroup = false;
            this.gridProducts.MasterTemplate.AllowRowResize = false;
            this.gridProducts.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "Id";
            gridViewTextBoxColumn7.HeaderText = "Id";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "Id";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "Name";
            gridViewTextBoxColumn8.HeaderText = "Name";
            gridViewTextBoxColumn8.Name = "Name";
            gridViewTextBoxColumn8.Width = 121;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "Description";
            gridViewTextBoxColumn9.HeaderText = "Description";
            gridViewTextBoxColumn9.Name = "Description";
            gridViewTextBoxColumn9.Width = 121;
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "Cost";
            gridViewDecimalColumn5.HeaderText = "Cost";
            gridViewDecimalColumn5.Name = "Cost";
            gridViewDecimalColumn5.Width = 121;
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "Retail";
            gridViewDecimalColumn6.HeaderText = "Retail";
            gridViewDecimalColumn6.Name = "Retail";
            gridViewDecimalColumn6.Width = 121;
            gridViewCheckBoxColumn5.EnableExpressionEditor = false;
            gridViewCheckBoxColumn5.FieldName = "Active";
            gridViewCheckBoxColumn5.HeaderText = "Active";
            gridViewCheckBoxColumn5.MinWidth = 20;
            gridViewCheckBoxColumn5.Name = "Active";
            gridViewCheckBoxColumn5.Width = 121;
            gridViewCheckBoxColumn6.EnableExpressionEditor = false;
            gridViewCheckBoxColumn6.FieldName = "TaxExempt";
            gridViewCheckBoxColumn6.HeaderText = "Tax Exempt";
            gridViewCheckBoxColumn6.MinWidth = 20;
            gridViewCheckBoxColumn6.Name = "TaxExempt";
            gridViewCheckBoxColumn6.Width = 121;
            this.gridProducts.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewDecimalColumn5,
            gridViewDecimalColumn6,
            gridViewCheckBoxColumn5,
            gridViewCheckBoxColumn6});
            this.gridProducts.MasterTemplate.EnableFiltering = true;
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridProducts.Size = new System.Drawing.Size(743, 233);
            this.gridProducts.TabIndex = 29;
            this.gridProducts.Text = "Products";
            this.gridProducts.ThemeName = "TelerikMetro";
            this.gridProducts.UserAddedRow += new Telerik.WinControls.UI.GridViewRowEventHandler(this.gridProducts_UserAddedRow);
            this.gridProducts.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gridProducts_CellValueChanged);
            // 
            // radLabel17
            // 
            this.radLabel17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radLabel17.Location = new System.Drawing.Point(16, 19);
            this.radLabel17.Name = "radLabel17";
            this.radLabel17.Size = new System.Drawing.Size(98, 21);
            this.radLabel17.TabIndex = 31;
            this.radLabel17.Text = "Your Products";
            // 
            // tabServices
            // 
            this.tabServices.Controls.Add(this.radGroupBox2);
            this.tabServices.Controls.Add(this.radLabel18);
            this.tabServices.Location = new System.Drawing.Point(5, 31);
            this.tabServices.Name = "tabServices";
            this.tabServices.Size = new System.Drawing.Size(839, 407);
            this.tabServices.Text = "Services";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.gridServices);
            this.radGroupBox2.FooterImageIndex = -1;
            this.radGroupBox2.FooterImageKey = "";
            this.radGroupBox2.HeaderImageIndex = -1;
            this.radGroupBox2.HeaderImageKey = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox2.HeaderText = "Current Services";
            this.radGroupBox2.Location = new System.Drawing.Point(17, 55);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(2, 22, 2, 2);
            // 
            // 
            // 
            this.radGroupBox2.RootElement.Padding = new System.Windows.Forms.Padding(2, 22, 2, 2);
            this.radGroupBox2.Size = new System.Drawing.Size(805, 285);
            this.radGroupBox2.TabIndex = 33;
            this.radGroupBox2.Text = "Current Services";
            this.radGroupBox2.ThemeName = "TelerikMetro";
            // 
            // gridServices
            // 
            this.gridServices.BackColor = System.Drawing.Color.White;
            this.gridServices.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridServices.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridServices.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridServices.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridServices.Location = new System.Drawing.Point(34, 34);
            // 
            // gridServices
            // 
            this.gridServices.MasterTemplate.AllowColumnChooser = false;
            this.gridServices.MasterTemplate.AllowDeleteRow = false;
            this.gridServices.MasterTemplate.AllowDragToGroup = false;
            this.gridServices.MasterTemplate.AllowRowResize = false;
            this.gridServices.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "Id";
            gridViewTextBoxColumn10.HeaderText = "Id";
            gridViewTextBoxColumn10.IsVisible = false;
            gridViewTextBoxColumn10.Name = "Id";
            gridViewTextBoxColumn10.ReadOnly = true;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "Name";
            gridViewTextBoxColumn11.HeaderText = "Name";
            gridViewTextBoxColumn11.Name = "Name";
            gridViewTextBoxColumn11.Width = 121;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "Description";
            gridViewTextBoxColumn12.HeaderText = "Description";
            gridViewTextBoxColumn12.Name = "Description";
            gridViewTextBoxColumn12.Width = 121;
            gridViewDecimalColumn7.EnableExpressionEditor = false;
            gridViewDecimalColumn7.FieldName = "Cost";
            gridViewDecimalColumn7.HeaderText = "Cost";
            gridViewDecimalColumn7.Name = "Cost";
            gridViewDecimalColumn7.Width = 121;
            gridViewDecimalColumn8.EnableExpressionEditor = false;
            gridViewDecimalColumn8.FieldName = "Retail";
            gridViewDecimalColumn8.HeaderText = "Retail";
            gridViewDecimalColumn8.Name = "Retail";
            gridViewDecimalColumn8.Width = 121;
            gridViewCheckBoxColumn7.EnableExpressionEditor = false;
            gridViewCheckBoxColumn7.FieldName = "Active";
            gridViewCheckBoxColumn7.HeaderText = "Active";
            gridViewCheckBoxColumn7.MinWidth = 20;
            gridViewCheckBoxColumn7.Name = "Active";
            gridViewCheckBoxColumn7.Width = 121;
            gridViewCheckBoxColumn8.EnableExpressionEditor = false;
            gridViewCheckBoxColumn8.FieldName = "TaxExempt";
            gridViewCheckBoxColumn8.HeaderText = "Tax Exempt";
            gridViewCheckBoxColumn8.MinWidth = 20;
            gridViewCheckBoxColumn8.Name = "TaxExempt";
            gridViewCheckBoxColumn8.Width = 121;
            this.gridServices.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewDecimalColumn7,
            gridViewDecimalColumn8,
            gridViewCheckBoxColumn7,
            gridViewCheckBoxColumn8});
            this.gridServices.MasterTemplate.EnableFiltering = true;
            this.gridServices.Name = "gridServices";
            this.gridServices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridServices.Size = new System.Drawing.Size(743, 234);
            this.gridServices.TabIndex = 29;
            this.gridServices.Text = "Services";
            this.gridServices.ThemeName = "TelerikMetro";
            this.gridServices.UserAddedRow += new Telerik.WinControls.UI.GridViewRowEventHandler(this.gridServices_UserAddedRow);
            this.gridServices.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gridServices_CellValueChanged);
            // 
            // radLabel18
            // 
            this.radLabel18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.radLabel18.Location = new System.Drawing.Point(17, 21);
            this.radLabel18.Name = "radLabel18";
            this.radLabel18.Size = new System.Drawing.Size(93, 21);
            this.radLabel18.TabIndex = 32;
            this.radLabel18.Text = "Your Services";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(354, 363);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 24);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.ThemeName = "TelerikMetro";
            // 
            // frmProductServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(849, 443);
            this.Controls.Add(this.tabParent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmProductServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products and Services";
            this.Load += new System.EventHandler(this.frmProductServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabParent)).EndInit();
            this.tabParent.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);
            this.tabProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel17)).EndInit();
            this.tabServices.ResumeLayout(false);
            this.tabServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridServices.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView tabParent;
        private Telerik.WinControls.UI.RadPageViewPage tabProducts;
        private Telerik.WinControls.UI.RadPageViewPage tabServices;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView gridProducts;
        private Telerik.WinControls.UI.RadLabel radLabel17;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGridView gridServices;
        private Telerik.WinControls.UI.RadLabel radLabel18;
        private Telerik.WinControls.UI.RadButton btnClose;
    }
}