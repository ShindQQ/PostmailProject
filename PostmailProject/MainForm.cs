using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostmailProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SendParcelButton_Click(object sender, EventArgs e)
        {
            SenderForm senderForm = new SenderForm();
            senderForm.Show();
        }

        private void ReceiveParcelButton_Click(object sender, EventArgs e)
        {
            ReceiverForm receiverForm = new ReceiverForm();
            receiverForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}