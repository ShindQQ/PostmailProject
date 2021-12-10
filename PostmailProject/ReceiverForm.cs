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
    [Serializable]
    public partial class ReceiverForm : Form
    {
        int postoffice_number = default;
        double capacity = default;
        double weight = default;
        double price = default;

        Parcel<dynamic> temp_parcel = null;
        Sender<dynamic> temp_sender = null;
        Receiver<dynamic> temp_receiver = null;
        Stack<Sender<dynamic>> senders = new Stack<Sender<dynamic>>();
        List<Receiver<dynamic>> receivers = new List<Receiver<dynamic>>();

        public ReceiverForm()
        {
            InitializeComponent();
        }

        private void ReceiveDepartmentTab_Click(object sender, EventArgs e)
        {

        }

        private void SendParcelBox_Enter(object sender, EventArgs e)
        {

        }

        private void ReceiverBox_Enter(object sender, EventArgs e)
        {

        }

        private void NameBox_Enter(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SurnameBox_Enter(object sender, EventArgs e)
        {

        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatronymicBox_Enter(object sender, EventArgs e)
        {

        }

        private void PatronymicTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PostOfficeNumberBox_Enter(object sender, EventArgs e)
        {
            if (!int.TryParse(PostOfficeNumberTextBox.Text, out postoffice_number))
            {
                MessageBox.Show("Wrong data for postoffice number!");
            }
        }

        private void PostOfficeNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneNumberBox_Enter(object sender, EventArgs e)
        {

        }

        private void PhoneNumberTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ReceiveDepartureBox_Enter(object sender, EventArgs e)
        {

        }

        private void ReceiveDepartureButton_Click(object sender, EventArgs e)
        {

        }

        private void CheckReceivingLabel_Click(object sender, EventArgs e)
        {
            CheckReceivingLabel.Text = "";

            foreach (var item1 in senders)
            {
                CheckReceivingLabel.Text += item1.GetInfo();
                foreach (var item2 in receivers)
                {
                    if (item1.Phone_number == item2.Phone_number && item1.Postoffice_number == item2.Postoffice_number)
                    {
                        CheckReceivingLabel.Text += item2.GetInfo();
                    }
                }
            }
        }

        private void ReadFileButton_Click(object sender, EventArgs e)
        {

        }
    }
}
