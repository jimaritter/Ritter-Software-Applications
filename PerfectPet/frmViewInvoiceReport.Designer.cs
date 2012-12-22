namespace PerfectPet
{
    partial class frmViewInvoiceReport
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
            this.invoiceReportViewer = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // invoiceReportViewer
            // 
            this.invoiceReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceReportViewer.Location = new System.Drawing.Point(0, 0);
            this.invoiceReportViewer.Name = "invoiceReportViewer";
            this.invoiceReportViewer.Size = new System.Drawing.Size(853, 531);
            this.invoiceReportViewer.TabIndex = 0;
            // 
            // frmViewInvoiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 531);
            this.Controls.Add(this.invoiceReportViewer);
            this.Name = "frmViewInvoiceReport";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.frmViewInvoiceReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.ReportViewer.WinForms.ReportViewer invoiceReportViewer;
    }
}