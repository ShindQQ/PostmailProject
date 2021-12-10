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
    public partial class SenderForm : Form
    {
        int postoffice_number = default;
        double capacity = default;
        double weight = default;

        Parcel<dynamic> temp_parcel = null;
        Sender<dynamic> temp_sender = null;
        Receiver<dynamic> temp_receiver = null;
        HashSet<Sender<dynamic>> senders = new HashSet<Sender<dynamic>>();
        List<Receiver<dynamic>> receivers = new List<Receiver<dynamic>>();

        void NotifyConsole(string message)
        {
            Console.WriteLine(message);
        }
        
        public SenderForm()
        {
            InitializeComponent();
        }

        private void CreateDepartmentTab_Click(object sender, EventArgs e)
        {

        }

        private void SendParcelBox_Enter(object sender, EventArgs e)
        {

        }

        private void SenderBox_Enter(object sender, EventArgs e)
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

        }

        private void PostOfficeNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(PostOfficeNumberTextBox.Text, out postoffice_number))
            {
                MessageBox.Show("Wrong data for postoffice number!");
            }
        }

        private void PhoneNumberBox_Enter(object sender, EventArgs e)
        {

        }

        private void PhoneNumberTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ParcelBox_Enter(object sender, EventArgs e)
        {

        }

        private void ParcelNameBox_Enter(object sender, EventArgs e)
        {

        }

        private void ParcelNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ParcelCapacityBox_Enter(object sender, EventArgs e)
        {

        }

        private void ParcelCapacityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(ParcelCapacityTextBox.Text, out capacity))
            {
                MessageBox.Show("Wrong capacity for parcel!");
            }
        }

        private void ParcelWeightBox_Enter(object sender, EventArgs e)
        {

        }

        private void ParcelWeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(ParcelWeightTextBox.Text, out weight))
            {
                MessageBox.Show("Wrong weight for parcel!");
            }
        }

        private void CreateDepartureBox_Enter(object sender, EventArgs e)
        {

        }

        private void ShowDepartmentLabel_Click(object sender, EventArgs e)
        {
            ShowDepartmentLabel.Text = "";

            foreach (var item in senders)
            {
                ShowDepartmentLabel.Text += item.GetInfo();
            }
        }

        private void SendDepartureButton_Click(object sender, EventArgs e)
        {
            try
            {
                temp_parcel = new Parcel<dynamic>(weight, capacity, ParcelNameTextBox.Text);
                temp_sender = new Sender<dynamic>(postoffice_number, PhoneNumberTextBox.Text, temp_parcel);
                temp_receiver = new Receiver<dynamic>(NameTextBox.Text, SurnameTextBox.Text, PatronymicTextBox.Text, postoffice_number, PhoneNumberTextBox.Text, temp_sender.CountPrice(), temp_parcel);

                temp_parcel.Notify += NotifyConsole;
                temp_sender.Notify += NotifyConsole;
                temp_receiver.Notify += NotifyConsole;

                senders.Add(temp_sender);
                receivers.Add(temp_receiver);
            }
            catch (DoubleException ex)
            {
                MessageBox.Show($"{ex.Message}, Value: {ex.Value}");
            }
            catch (IntException ex)
            {
                MessageBox.Show($"{ex.Message}, Value: {ex.Value}");
            }
        }

        private void AddParcelToDepartureButton_Click(object sender, EventArgs e)
        {
            var sender_receiver = (from send in senders
                                  from res in receivers
                                  where send.Postoffice_number == postoffice_number && send.Phone_number == PhoneNumberTextBox.Text
                                  select new {Send = send, Res = res}).Take(1);

            try
            {
                foreach (var item in sender_receiver)
                {
                    temp_parcel = new Parcel<dynamic>(weight, capacity, ParcelNameTextBox.Text);
                    temp_parcel.Notify += NotifyConsole;
                    item.Send?.Parcels.Enqueue(temp_parcel);
                    item.Res?.Parcels.Add(temp_parcel);
                }
            }
            catch (DoubleException ex)
            {
                MessageBox.Show($"{ex.Message}, Value: {ex.Value}");
            }
            catch (IntException ex)
            {
                MessageBox.Show($"{ex.Message}, Value: {ex.Value}");
            }
        }
    }
}