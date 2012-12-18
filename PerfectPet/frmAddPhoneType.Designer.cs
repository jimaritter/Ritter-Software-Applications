namespace PerfectPet
{
    partial class frmAddPhoneType
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
            this.listPhoneTypes = new Telerik.WinControls.UI.RadListControl();
            this.txtPhoneType = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnAddPersonType = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPhoneTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPersonType)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(116, 22);
            this.radLabel1.TabIndex = 43;
            this.radLabel1.Text = "Add Phone Type";
            // 
            // listPhoneTypes
            // 
            this.listPhoneTypes.CaseSensitiveSort = true;
            this.listPhoneTypes.ItemHeight = 18;
            this.listPhoneTypes.Location = new System.Drawing.Point(166, 65);
            this.listPhoneTypes.Name = "listPhoneTypes";
            this.listPhoneTypes.Size = new System.Drawing.Size(227, 90);
            this.listPhoneTypes.TabIndex = 39;
            this.listPhoneTypes.ThemeName = "ControlDefault";
            // 
            // txtPhoneType
            // 
            this.txtPhoneType.Location = new System.Drawing.Point(12, 65);
            this.txtPhoneType.Name = "txtPhoneType";
            this.txtPhoneType.Size = new System.Drawing.Size(132, 20);
            this.txtPhoneType.TabIndex = 40;
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(12, 43);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(117, 18);
            this.radLabel6.TabIndex = 42;
            this.radLabel6.Text = "Add New Phone Type:";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(166, 43);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(54, 18);
            this.radLabel5.TabIndex = 41;
            this.radLabel5.Text = "Available:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(222, 172);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 24);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Close";
            this.btnCancel.ThemeName = "VisualStudio2012Light";
            // 
            // btnAddPersonType
            // 
            this.btnAddPersonType.Location = new System.Drawing.Point(115, 172);
            this.btnAddPersonType.Name = "btnAddPersonType";
            this.btnAddPersonType.Size = new System.Drawing.Size(96, 24);
            this.btnAddPersonType.TabIndex = 37;
            this.btnAddPersonType.Text = "Add";
            this.btnAddPersonType.ThemeName = "VisualStudio2012Light";
            this.btnAddPersonType.Click += new System.EventHandler(this.btnAddPersonType_Click);
            // 
            // frmAddPhoneType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(432, 208);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.listPhoneTypes);
            this.Controls.Add(this.txtPhoneType);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddPersonType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAddPhoneType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Phone Type";
            this.Load += new System.EventHandler(this.frmAddPhoneType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPhoneTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPersonType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadListControl listPhoneTypes;
        private Telerik.WinControls.UI.RadTextBoxControl txtPhoneType;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnAddPersonType;
    }
}