
namespace Vezeeta
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBookAppointmentForm = new System.Windows.Forms.Button();
            this.btnDltAppointmentForm = new System.Windows.Forms.Button();
            this.btnBuyProductForm = new System.Windows.Forms.Button();
            this.btnDsplyPurchasesReport = new System.Windows.Forms.Button();
            this.btnDsplyAppointmentReport = new System.Windows.Forms.Button();
            this.bookAppointmentForm1 = new Vezeeta.BookAppointmentForm();
            this.buyProductForm1 = new Vezeeta.BuyProductForm();
            this.deleteAppointmentForm1 = new Vezeeta.DeleteAppointmentForm();
            this.displayAppointmentsReport1 = new Vezeeta.DisplayAppointmentsReport();
            this.displayPurchasesReport1 = new Vezeeta.DisplayPurchasesReport();
            this.home1 = new Vezeeta.Home();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBookAppointmentForm);
            this.panel1.Controls.Add(this.btnDltAppointmentForm);
            this.panel1.Controls.Add(this.btnBuyProductForm);
            this.panel1.Controls.Add(this.btnDsplyPurchasesReport);
            this.panel1.Controls.Add(this.btnDsplyAppointmentReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 696);
            this.panel1.TabIndex = 0;
            // 
            // btnBookAppointmentForm
            // 
            this.btnBookAppointmentForm.Location = new System.Drawing.Point(12, 129);
            this.btnBookAppointmentForm.Name = "btnBookAppointmentForm";
            this.btnBookAppointmentForm.Size = new System.Drawing.Size(189, 53);
            this.btnBookAppointmentForm.TabIndex = 4;
            this.btnBookAppointmentForm.Text = "Book Appointment ";
            this.btnBookAppointmentForm.UseVisualStyleBackColor = true;
            this.btnBookAppointmentForm.Click += new System.EventHandler(this.btnBookAppointmentForm_Click);
            // 
            // btnDltAppointmentForm
            // 
            this.btnDltAppointmentForm.Location = new System.Drawing.Point(12, 300);
            this.btnDltAppointmentForm.Name = "btnDltAppointmentForm";
            this.btnDltAppointmentForm.Size = new System.Drawing.Size(189, 53);
            this.btnDltAppointmentForm.TabIndex = 3;
            this.btnDltAppointmentForm.Text = "Delete Appointment";
            this.btnDltAppointmentForm.UseVisualStyleBackColor = true;
            this.btnDltAppointmentForm.Click += new System.EventHandler(this.btnDltAppointmentForm_Click);
            // 
            // btnBuyProductForm
            // 
            this.btnBuyProductForm.Location = new System.Drawing.Point(12, 208);
            this.btnBuyProductForm.Name = "btnBuyProductForm";
            this.btnBuyProductForm.Size = new System.Drawing.Size(189, 53);
            this.btnBuyProductForm.TabIndex = 2;
            this.btnBuyProductForm.Text = "Buy Product";
            this.btnBuyProductForm.UseVisualStyleBackColor = true;
            this.btnBuyProductForm.Click += new System.EventHandler(this.btnBuyProductForm_Click);
            // 
            // btnDsplyPurchasesReport
            // 
            this.btnDsplyPurchasesReport.Location = new System.Drawing.Point(12, 482);
            this.btnDsplyPurchasesReport.Name = "btnDsplyPurchasesReport";
            this.btnDsplyPurchasesReport.Size = new System.Drawing.Size(189, 53);
            this.btnDsplyPurchasesReport.TabIndex = 1;
            this.btnDsplyPurchasesReport.Text = "Display Purchases Report";
            this.btnDsplyPurchasesReport.UseVisualStyleBackColor = true;
            this.btnDsplyPurchasesReport.Click += new System.EventHandler(this.btnDsplyPurchasesReport_Click);
            // 
            // btnDsplyAppointmentReport
            // 
            this.btnDsplyAppointmentReport.Location = new System.Drawing.Point(12, 390);
            this.btnDsplyAppointmentReport.Name = "btnDsplyAppointmentReport";
            this.btnDsplyAppointmentReport.Size = new System.Drawing.Size(189, 53);
            this.btnDsplyAppointmentReport.TabIndex = 0;
            this.btnDsplyAppointmentReport.Text = "Display Appointment Report";
            this.btnDsplyAppointmentReport.UseVisualStyleBackColor = true;
            this.btnDsplyAppointmentReport.Click += new System.EventHandler(this.btnDsplyAppointmentReport_Click);
            // 
            // bookAppointmentForm1
            // 
            this.bookAppointmentForm1.Location = new System.Drawing.Point(224, 0);
            this.bookAppointmentForm1.Name = "bookAppointmentForm1";
            this.bookAppointmentForm1.Size = new System.Drawing.Size(720, 696);
            this.bookAppointmentForm1.TabIndex = 5;
            // 
            // buyProductForm1
            // 
            this.buyProductForm1.Location = new System.Drawing.Point(226, 0);
            this.buyProductForm1.Name = "buyProductForm1";
            this.buyProductForm1.Size = new System.Drawing.Size(718, 696);
            this.buyProductForm1.TabIndex = 6;
            // 
            // deleteAppointmentForm1
            // 
            this.deleteAppointmentForm1.Location = new System.Drawing.Point(224, 0);
            this.deleteAppointmentForm1.Name = "deleteAppointmentForm1";
            this.deleteAppointmentForm1.Size = new System.Drawing.Size(720, 693);
            this.deleteAppointmentForm1.TabIndex = 7;
            // 
            // displayAppointmentsReport1
            // 
            this.displayAppointmentsReport1.Location = new System.Drawing.Point(224, 0);
            this.displayAppointmentsReport1.Name = "displayAppointmentsReport1";
            this.displayAppointmentsReport1.Size = new System.Drawing.Size(720, 693);
            this.displayAppointmentsReport1.TabIndex = 8;
            // 
            // displayPurchasesReport1
            // 
            this.displayPurchasesReport1.Location = new System.Drawing.Point(226, 0);
            this.displayPurchasesReport1.Name = "displayPurchasesReport1";
            this.displayPurchasesReport1.Size = new System.Drawing.Size(718, 696);
            this.displayPurchasesReport1.TabIndex = 9;
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.home1.Location = new System.Drawing.Point(226, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(718, 693);
            this.home1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 696);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.displayPurchasesReport1);
            this.Controls.Add(this.displayAppointmentsReport1);
            this.Controls.Add(this.deleteAppointmentForm1);
            this.Controls.Add(this.buyProductForm1);
            this.Controls.Add(this.bookAppointmentForm1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDltAppointmentForm;
        private System.Windows.Forms.Button btnBuyProductForm;
        private System.Windows.Forms.Button btnDsplyPurchasesReport;
        private System.Windows.Forms.Button btnDsplyAppointmentReport;
        private System.Windows.Forms.Button btnBookAppointmentForm;
        private BookAppointmentForm bookAppointmentForm1;
        private BuyProductForm buyProductForm1;
        private DeleteAppointmentForm deleteAppointmentForm1;
        private DisplayAppointmentsReport displayAppointmentsReport1;
        private DisplayPurchasesReport displayPurchasesReport1;
        private Home home1;
    }
}

