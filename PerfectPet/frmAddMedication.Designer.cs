namespace PerfectPet
{
    partial class frmAddMedication
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
            this.btnAddMedication = new Telerik.WinControls.UI.RadButton();
            this.txtName = new Telerik.WinControls.UI.RadTextBoxControl();
            this.lblStreet = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtDescription = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtDirections = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtQuantity = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddMedication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(280, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 24);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Close";
            this.btnCancel.ThemeName = "VisualStudio2012Light";
            // 
            // btnAddMedication
            // 
            this.btnAddMedication.Location = new System.Drawing.Point(173, 253);
            this.btnAddMedication.Name = "btnAddMedication";
            this.btnAddMedication.Size = new System.Drawing.Size(96, 24);
            this.btnAddMedication.TabIndex = 47;
            this.btnAddMedication.Text = "Add";
            this.btnAddMedication.ThemeName = "VisualStudio2012Light";
            this.btnAddMedication.Click += new System.EventHandler(this.btnAddMedication_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(129, 20);
            this.txtName.TabIndex = 46;
            // 
            // lblStreet
            // 
            this.lblStreet.Location = new System.Drawing.Point(12, 40);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(39, 18);
            this.lblStreet.TabIndex = 50;
            this.lblStreet.Text = "Name:";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(113, 22);
            this.radLabel1.TabIndex = 49;
            this.radLabel1.Text = "Add Medication";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(148, 64);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(213, 20);
            this.txtDescription.TabIndex = 51;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(148, 40);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(66, 18);
            this.radLabel2.TabIndex = 52;
            this.radLabel2.Text = "Description:";
            // 
            // txtDirections
            // 
            this.txtDirections.Location = new System.Drawing.Point(12, 123);
            this.txtDirections.Multiline = true;
            this.txtDirections.Name = "txtDirections";
            this.txtDirections.Size = new System.Drawing.Size(512, 101);
            this.txtDirections.TabIndex = 53;
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(12, 99);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(59, 18);
            this.radLabel3.TabIndex = 54;
            this.radLabel3.Text = "Directions:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(376, 64);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(129, 20);
            this.txtQuantity.TabIndex = 55;
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(376, 40);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(52, 18);
            this.radLabel4.TabIndex = 56;
            this.radLabel4.Text = "Quantity:";
            // 
            // frmAddMedication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(559, 289);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.txtDirections);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddMedication);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.radLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAddMedication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Medication";
            this.Load += new System.EventHandler(this.frmAddMedication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddMedication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnAddMedication;
        private Telerik.WinControls.UI.RadTextBoxControl txtName;
        private Telerik.WinControls.UI.RadLabel lblStreet;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBoxControl txtDescription;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBoxControl txtDirections;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBoxControl txtQuantity;
        private Telerik.WinControls.UI.RadLabel radLabel4;
    }
}