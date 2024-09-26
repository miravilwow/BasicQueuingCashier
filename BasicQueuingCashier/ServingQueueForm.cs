using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingCashier
{

    public partial class ServingQueueForm : Form
    {
     
        public ServingQueueForm()
        {
            InitializeComponent();
        }
        private void InitializeTimer()
        {
        }

        private void UpdateQeueDisplay_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                lblStudentQeueu.Text = CashierClass.CashierQueue.Peek();
            }
            else
            {
                lblStudentQeueu.Text = "No students in queue";
            }
        }
    }
}
