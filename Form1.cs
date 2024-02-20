using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vezeeta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBookAppointmentForm_Click(object sender, EventArgs e)
        {
            home1.Hide();
            buyProductForm1.Hide();
            deleteAppointmentForm1.Hide();
            displayAppointmentsReport1.Hide();
            displayPurchasesReport1.Hide();

            bookAppointmentForm1.Show();
            bookAppointmentForm1.BringToFront();
        }

        private void btnBuyProductForm_Click(object sender, EventArgs e)
        {
            home1.Hide();
            bookAppointmentForm1.Hide();
            deleteAppointmentForm1.Hide();
            displayAppointmentsReport1.Hide();
            displayPurchasesReport1.Hide();

            buyProductForm1.Show();
            buyProductForm1.BringToFront();
        }

        private void btnDltAppointmentForm_Click(object sender, EventArgs e)
        {
            home1.Hide();
            bookAppointmentForm1.Hide();
            buyProductForm1.Hide();
            displayAppointmentsReport1.Hide();
            displayPurchasesReport1.Hide();

            deleteAppointmentForm1.Show();
            deleteAppointmentForm1.BringToFront();
        }

        private void btnDsplyAppointmentReport_Click(object sender, EventArgs e)
        {
            home1.Hide();
            bookAppointmentForm1.Hide();
            buyProductForm1.Hide();
            deleteAppointmentForm1.Hide();
            displayPurchasesReport1.Hide();

            displayAppointmentsReport1.Show();
            displayAppointmentsReport1.BringToFront();
        }

        private void btnDsplyPurchasesReport_Click(object sender, EventArgs e)
        {
            home1.Hide();
            bookAppointmentForm1.Hide();
            buyProductForm1.Hide();
            deleteAppointmentForm1.Hide();
            displayAppointmentsReport1.Hide();

            displayPurchasesReport1.Show();
            displayPurchasesReport1.BringToFront();
        }
    }
}
