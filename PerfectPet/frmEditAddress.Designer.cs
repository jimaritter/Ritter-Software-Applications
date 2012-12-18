namespace PerfectPet
{
    partial class frmEditAddress
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
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnAddAddress = new Telerik.WinControls.UI.RadButton();
            this.ddlAddressType = new Telerik.WinControls.UI.RadDropDownList();
            this.lblAddressType = new Telerik.WinControls.UI.RadLabel();
            this.ddlState = new Telerik.WinControls.UI.RadDropDownList();
            this.lblZip = new Telerik.WinControls.UI.RadLabel();
            this.txtZip = new Telerik.WinControls.UI.RadTextBoxControl();
            this.lblState = new Telerik.WinControls.UI.RadLabel();
            this.lblCity = new Telerik.WinControls.UI.RadLabel();
            this.txtCity = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txtStreet = new Telerik.WinControls.UI.RadTextBoxControl();
            this.lblStreet = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlAddressType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAddressType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblZip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(223, 172);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 24);
            this.btnCancel.TabIndex = 60;
            this.btnCancel.Text = "Close";
            this.btnCancel.ThemeName = "VisualStudio2012Light";
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(116, 172);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(96, 24);
            this.btnAddAddress.TabIndex = 59;
            this.btnAddAddress.Text = "Save";
            this.btnAddAddress.ThemeName = "VisualStudio2012Light";
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // ddlAddressType
            // 
            this.ddlAddressType.DropDownAnimationEnabled = true;
            this.ddlAddressType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlAddressType.Location = new System.Drawing.Point(13, 58);
            this.ddlAddressType.MaxDropDownItems = 0;
            this.ddlAddressType.Name = "ddlAddressType";
            this.ddlAddressType.ShowImageInEditorArea = true;
            this.ddlAddressType.Size = new System.Drawing.Size(106, 20);
            this.ddlAddressType.TabIndex = 54;
            // 
            // lblAddressType
            // 
            this.lblAddressType.Location = new System.Drawing.Point(13, 40);
            this.lblAddressType.Name = "lblAddressType";
            this.lblAddressType.Size = new System.Drawing.Size(76, 18);
            this.lblAddressType.TabIndex = 66;
            this.lblAddressType.Text = "Address Type:";
            // 
            // ddlState
            // 
            this.ddlState.DropDownAnimationEnabled = true;
            this.ddlState.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlState.Location = new System.Drawing.Point(271, 109);
            this.ddlState.MaxDropDownItems = 0;
            this.ddlState.Name = "ddlState";
            this.ddlState.ShowImageInEditorArea = true;
            this.ddlState.Size = new System.Drawing.Size(55, 20);
            this.ddlState.TabIndex = 57;
            // 
            // lblZip
            // 
            this.lblZip.Location = new System.Drawing.Point(332, 84);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(24, 18);
            this.lblZip.TabIndex = 65;
            this.lblZip.Text = "Zip:";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(332, 108);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(87, 20);
            this.txtZip.TabIndex = 58;
            // 
            // lblState
            // 
            this.lblState.Location = new System.Drawing.Point(270, 84);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(34, 18);
            this.lblState.TabIndex = 64;
            this.lblState.Text = "State:";
            // 
            // lblCity
            // 
            this.lblCity.Location = new System.Drawing.Point(155, 84);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(28, 18);
            this.lblCity.TabIndex = 63;
            this.lblCity.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(153, 108);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(111, 20);
            this.txtCity.TabIndex = 56;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(13, 108);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(129, 20);
            this.txtStreet.TabIndex = 55;
            // 
            // lblStreet
            // 
            this.lblStreet.Location = new System.Drawing.Point(13, 84);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 18);
            this.lblStreet.TabIndex = 62;
            this.lblStreet.Text = "Street:";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(13, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(91, 22);
            this.radLabel1.TabIndex = 61;
            this.radLabel1.Text = "Add Address";
            // 
            // frmEditAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 208);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddAddress);
            this.Controls.Add(this.ddlAddressType);
            this.Controls.Add(this.lblAddressType);
            this.Controls.Add(this.ddlState);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.radLabel1);
            this.Name = "frmEditAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Address";
            this.Load += new System.EventHandler(this.frmEditAddress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlAddressType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAddressType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblZip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnAddAddress;
        private Telerik.WinControls.UI.RadDropDownList ddlAddressType;
        private Telerik.WinControls.UI.RadLabel lblAddressType;
        private Telerik.WinControls.UI.RadDropDownList ddlState;
        private Telerik.WinControls.UI.RadLabel lblZip;
        private Telerik.WinControls.UI.RadTextBoxControl txtZip;
        private Telerik.WinControls.UI.RadLabel lblState;
        private Telerik.WinControls.UI.RadLabel lblCity;
        private Telerik.WinControls.UI.RadTextBoxControl txtCity;
        private Telerik.WinControls.UI.RadTextBoxControl txtStreet;
        private Telerik.WinControls.UI.RadLabel lblStreet;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}