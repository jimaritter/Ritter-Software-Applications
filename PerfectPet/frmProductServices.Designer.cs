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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn3 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn4 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            this.tabParent = new Telerik.WinControls.UI.RadPageView();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.tabProducts = new Telerik.WinControls.UI.RadPageViewPage();
            this.tabServices = new Telerik.WinControls.UI.RadPageViewPage();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.gridProducts = new Telerik.WinControls.UI.RadGridView();
            this.radLabel17 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.gridServices = new Telerik.WinControls.UI.RadGridView();
            this.radLabel18 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tabParent)).BeginInit();
            this.tabParent.SuspendLayout();
            this.tabProducts.SuspendLayout();
            this.tabServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridServices.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel18)).BeginInit();
            this.SuspendLayout();
            // 
            // tabParent
            // 
            this.tabParent.Controls.Add(this.tabProducts);
            this.tabParent.Controls.Add(this.tabServices);
            this.tabParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabParent.Location = new System.Drawing.Point(0, 0);
            this.tabParent.Name = "tabParent";
            this.tabParent.SelectedPage = this.tabServices;
            this.tabParent.Size = new System.Drawing.Size(849, 443);
            this.tabParent.TabIndex = 0;
            this.tabParent.Text = "radPageView1";
            this.tabParent.ThemeName = "TelerikMetro";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.tabParent.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.radGroupBox1);
            this.tabProducts.Controls.Add(this.radLabel17);
            this.tabProducts.Location = new System.Drawing.Point(5, 31);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Size = new System.Drawing.Size(839, 407);
            this.tabProducts.Text = "Products";
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
            this.radGroupBox1.Size = new System.Drawing.Size(805, 331);
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
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Name";
            gridViewTextBoxColumn2.HeaderText = "Name";
            gridViewTextBoxColumn2.Name = "Name";
            gridViewTextBoxColumn2.Width = 121;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Description";
            gridViewTextBoxColumn3.HeaderText = "Description";
            gridViewTextBoxColumn3.Name = "Description";
            gridViewTextBoxColumn3.Width = 121;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "Cost";
            gridViewDecimalColumn1.HeaderText = "Cost";
            gridViewDecimalColumn1.Name = "Cost";
            gridViewDecimalColumn1.Width = 121;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "Retail";
            gridViewDecimalColumn2.HeaderText = "Retail";
            gridViewDecimalColumn2.Name = "Retail";
            gridViewDecimalColumn2.Width = 121;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "Active";
            gridViewCheckBoxColumn1.HeaderText = "Active";
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "Active";
            gridViewCheckBoxColumn1.Width = 121;
            gridViewCheckBoxColumn2.EnableExpressionEditor = false;
            gridViewCheckBoxColumn2.FieldName = "TaxExempt";
            gridViewCheckBoxColumn2.HeaderText = "Tax Exempt";
            gridViewCheckBoxColumn2.MinWidth = 20;
            gridViewCheckBoxColumn2.Name = "TaxExempt";
            gridViewCheckBoxColumn2.Width = 121;
            this.gridProducts.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewCheckBoxColumn1,
            gridViewCheckBoxColumn2});
            this.gridProducts.MasterTemplate.EnableFiltering = true;
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridProducts.Size = new System.Drawing.Size(743, 275);
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
            this.radGroupBox2.Size = new System.Drawing.Size(805, 331);
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
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Id";
            gridViewTextBoxColumn4.HeaderText = "Id";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "Id";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Name";
            gridViewTextBoxColumn5.HeaderText = "Name";
            gridViewTextBoxColumn5.Name = "Name";
            gridViewTextBoxColumn5.Width = 121;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "Description";
            gridViewTextBoxColumn6.HeaderText = "Description";
            gridViewTextBoxColumn6.Name = "Description";
            gridViewTextBoxColumn6.Width = 121;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "Cost";
            gridViewDecimalColumn3.HeaderText = "Cost";
            gridViewDecimalColumn3.Name = "Cost";
            gridViewDecimalColumn3.Width = 121;
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "Retail";
            gridViewDecimalColumn4.HeaderText = "Retail";
            gridViewDecimalColumn4.Name = "Retail";
            gridViewDecimalColumn4.Width = 121;
            gridViewCheckBoxColumn3.EnableExpressionEditor = false;
            gridViewCheckBoxColumn3.FieldName = "Active";
            gridViewCheckBoxColumn3.HeaderText = "Active";
            gridViewCheckBoxColumn3.MinWidth = 20;
            gridViewCheckBoxColumn3.Name = "Active";
            gridViewCheckBoxColumn3.Width = 121;
            gridViewCheckBoxColumn4.EnableExpressionEditor = false;
            gridViewCheckBoxColumn4.FieldName = "TaxExempt";
            gridViewCheckBoxColumn4.HeaderText = "Tax Exempt";
            gridViewCheckBoxColumn4.MinWidth = 20;
            gridViewCheckBoxColumn4.Name = "TaxExempt";
            gridViewCheckBoxColumn4.Width = 121;
            this.gridServices.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewDecimalColumn3,
            gridViewDecimalColumn4,
            gridViewCheckBoxColumn3,
            gridViewCheckBoxColumn4});
            this.gridServices.MasterTemplate.EnableFiltering = true;
            this.gridServices.Name = "gridServices";
            this.gridServices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridServices.Size = new System.Drawing.Size(743, 275);
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
            // frmProductServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 443);
            this.Controls.Add(this.tabParent);
            this.Name = "frmProductServices";
            this.Text = "Products and Services";
            this.Load += new System.EventHandler(this.frmProductServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabParent)).EndInit();
            this.tabParent.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);
            this.tabProducts.PerformLayout();
            this.tabServices.ResumeLayout(false);
            this.tabServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridServices.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel18)).EndInit();
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
    }
}