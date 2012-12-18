namespace PerfectPet
{
    partial class frmAddAddressType
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.txtAddressType = new Telerik.WinControls.UI.RadTextBoxControl();
            this.listAddressTypes = new Telerik.WinControls.UI.RadListControl();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnAddPersonType = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddressType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAddressTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPersonType)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(127, 22);
            this.radLabel1.TabIndex = 29;
            this.radLabel1.Text = "Add Address Type";
            // 
            // radLabel7
            // 
            this.radLabel7.Location = new System.Drawing.Point(14, 40);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(125, 18);
            this.radLabel7.TabIndex = 33;
            this.radLabel7.Text = "Add New Address Type:";
            // 
            // radLabel8
            // 
            this.radLabel8.Location = new System.Drawing.Point(175, 40);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(54, 18);
            this.radLabel8.TabIndex = 32;
            this.radLabel8.Text = "Available:";
            // 
            // txtAddressType
            // 
            this.txtAddressType.Location = new System.Drawing.Point(14, 64);
            this.txtAddressType.Name = "txtAddressType";
            this.txtAddressType.Size = new System.Drawing.Size(143, 20);
            this.txtAddressType.TabIndex = 31;
            // 
            // listAddressTypes
            // 
            this.listAddressTypes.CaseSensitiveSort = true;
            this.listAddressTypes.ItemHeight = 18;
            this.listAddressTypes.Location = new System.Drawing.Point(175, 62);
            this.listAddressTypes.Name = "listAddressTypes";
            this.listAddressTypes.Size = new System.Drawing.Size(225, 84);
            this.listAddressTypes.TabIndex = 30;
            this.listAddressTypes.ThemeName = "ControlDefault";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(222, 172);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 24);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Close";
            this.btnCancel.ThemeName = "VisualStudio2012Light";
            // 
            // btnAddPersonType
            // 
            this.btnAddPersonType.Location = new System.Drawing.Point(115, 172);
            this.btnAddPersonType.Name = "btnAddPersonType";
            this.btnAddPersonType.Size = new System.Drawing.Size(96, 24);
            this.btnAddPersonType.TabIndex = 34;
            this.btnAddPersonType.Text = "Add";
            this.btnAddPersonType.ThemeName = "VisualStudio2012Light";
            this.btnAddPersonType.Click += new System.EventHandler(this.btnAddPersonType_Click);
            // 
            // frmAddAddressType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(432, 208);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddPersonType);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.radLabel8);
            this.Controls.Add(this.txtAddressType);
            this.Controls.Add(this.listAddressTypes);
            this.Controls.Add(this.radLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAddAddressType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Address Type";
            this.Load += new System.EventHandler(this.frmAddAddressType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddressType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAddressTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPersonType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadTextBoxControl txtAddressType;
        private Telerik.WinControls.UI.RadListControl listAddressTypes;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnAddPersonType;
    }
}