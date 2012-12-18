namespace PerfectPet
{
    partial class frmAddPersonType
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
            this.btnAddPersonType = new Telerik.WinControls.UI.RadButton();
            this.listPeopleTypes = new Telerik.WinControls.UI.RadListControl();
            this.txtPersonType = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPersonType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPeopleTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(222, 172);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 24);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Close";
            this.btnCancel.ThemeName = "VisualStudio2012Light";
            // 
            // btnAddPersonType
            // 
            this.btnAddPersonType.Location = new System.Drawing.Point(115, 172);
            this.btnAddPersonType.Name = "btnAddPersonType";
            this.btnAddPersonType.Size = new System.Drawing.Size(96, 24);
            this.btnAddPersonType.TabIndex = 30;
            this.btnAddPersonType.Text = "Add";
            this.btnAddPersonType.ThemeName = "VisualStudio2012Light";
            this.btnAddPersonType.Click += new System.EventHandler(this.btnAddPersonType_Click);
            // 
            // listPeopleTypes
            // 
            this.listPeopleTypes.CaseSensitiveSort = true;
            this.listPeopleTypes.ItemHeight = 18;
            this.listPeopleTypes.Location = new System.Drawing.Point(166, 65);
            this.listPeopleTypes.Name = "listPeopleTypes";
            this.listPeopleTypes.Size = new System.Drawing.Size(227, 90);
            this.listPeopleTypes.TabIndex = 32;
            this.listPeopleTypes.ThemeName = "ControlDefault";
            // 
            // txtPersonType
            // 
            this.txtPersonType.Location = new System.Drawing.Point(12, 65);
            this.txtPersonType.Name = "txtPersonType";
            this.txtPersonType.Size = new System.Drawing.Size(132, 20);
            this.txtPersonType.TabIndex = 33;
            // 
            // radLabel6
            // 
            this.radLabel6.Location = new System.Drawing.Point(12, 43);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(119, 18);
            this.radLabel6.TabIndex = 35;
            this.radLabel6.Text = "Add New Person Type:";
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(166, 43);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(54, 18);
            this.radLabel5.TabIndex = 34;
            this.radLabel5.Text = "Available:";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(119, 22);
            this.radLabel1.TabIndex = 36;
            this.radLabel1.Text = "Add Person Type";
            // 
            // frmAddPersonType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(432, 208);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.listPeopleTypes);
            this.Controls.Add(this.txtPersonType);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddPersonType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAddPersonType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Person Type";
            this.Load += new System.EventHandler(this.frmAddPersonType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPersonType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPeopleTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnAddPersonType;
        private Telerik.WinControls.UI.RadListControl listPeopleTypes;
        private Telerik.WinControls.UI.RadTextBoxControl txtPersonType;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}