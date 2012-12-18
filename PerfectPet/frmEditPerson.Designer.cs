namespace PerfectPet
{
    partial class frmEditPerson
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.lblEmail = new Telerik.WinControls.UI.RadLabel();
            this.lblType = new Telerik.WinControls.UI.RadLabel();
            this.txtEmail = new Telerik.WinControls.UI.RadTextBoxControl();
            this.ddlPersonType = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.chkActive = new Telerik.WinControls.UI.RadCheckBox();
            this.btnSavePerson = new Telerik.WinControls.UI.RadButton();
            this.txtLastName = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txtMiddleName = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txtFirstName = new Telerik.WinControls.UI.RadTextBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPersonType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSavePerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddleName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(222, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 24);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.ThemeName = "VisualStudio2012Light";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(82, 22);
            this.radLabel1.TabIndex = 42;
            this.radLabel1.Text = "Edit Person";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(191, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 18);
            this.lblEmail.TabIndex = 41;
            this.lblEmail.Text = "Email:";
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(27, 102);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(33, 18);
            this.lblType.TabIndex = 40;
            this.lblType.Text = "Type:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(191, 124);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 20);
            this.txtEmail.TabIndex = 35;
            // 
            // ddlPersonType
            // 
            this.ddlPersonType.DropDownAnimationEnabled = true;
            this.ddlPersonType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlPersonType.Location = new System.Drawing.Point(27, 124);
            this.ddlPersonType.MaxDropDownItems = 0;
            this.ddlPersonType.Name = "ddlPersonType";
            this.ddlPersonType.ShowImageInEditorArea = true;
            this.ddlPersonType.Size = new System.Drawing.Size(129, 20);
            this.ddlPersonType.TabIndex = 34;
            this.ddlPersonType.Text = "Select person type...";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(27, 48);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(63, 18);
            this.radLabel4.TabIndex = 37;
            this.radLabel4.Text = "First Name:";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(119, 48);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(77, 18);
            this.radLabel3.TabIndex = 39;
            this.radLabel3.Text = "Middle Name:";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(214, 48);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(61, 18);
            this.radLabel2.TabIndex = 36;
            this.radLabel2.Text = "Last Name:";
            // 
            // chkActive
            // 
            this.chkActive.Location = new System.Drawing.Point(307, 74);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(51, 18);
            this.chkActive.TabIndex = 33;
            this.chkActive.Text = "Active";
            // 
            // btnSavePerson
            // 
            this.btnSavePerson.Location = new System.Drawing.Point(115, 171);
            this.btnSavePerson.Name = "btnSavePerson";
            this.btnSavePerson.Size = new System.Drawing.Size(96, 24);
            this.btnSavePerson.TabIndex = 38;
            this.btnSavePerson.Text = "Save";
            this.btnSavePerson.ThemeName = "VisualStudio2012Light";
            this.btnSavePerson.Click += new System.EventHandler(this.btnSavePerson_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(211, 72);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(84, 20);
            this.txtLastName.TabIndex = 32;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(119, 72);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(84, 20);
            this.txtMiddleName.TabIndex = 31;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(27, 72);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(84, 20);
            this.txtFirstName.TabIndex = 30;
            // 
            // frmEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(432, 208);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.ddlPersonType);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.btnSavePerson);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmEditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Person";
            this.Load += new System.EventHandler(this.frmEditPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPersonType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSavePerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddleName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel lblEmail;
        private Telerik.WinControls.UI.RadLabel lblType;
        private Telerik.WinControls.UI.RadTextBoxControl txtEmail;
        private Telerik.WinControls.UI.RadDropDownList ddlPersonType;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadCheckBox chkActive;
        private Telerik.WinControls.UI.RadButton btnSavePerson;
        private Telerik.WinControls.UI.RadTextBoxControl txtLastName;
        private Telerik.WinControls.UI.RadTextBoxControl txtMiddleName;
        private Telerik.WinControls.UI.RadTextBoxControl txtFirstName;
    }
}