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
        List<Sender<dynamic>> senders = new List<Sender<dynamic>>();

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
                temp_sender = new Sender<dynamic>(NameTextBox.Text, SurnameTextBox.Text, PatronymicTextBox.Text, postoffice_number, PhoneNumberTextBox.Text, temp_parcel);
                temp_parcel.Notify += NotifyConsole;
                temp_sender.Notify += NotifyConsole;
                senders.Add(temp_sender);
            }
            catch (DoubleException ex)
            {
                MessageBox.Show($"{ex.Message}, Value: {ex.Value}");
            }
        }

        private void AddParcelToDepartureButton_Click(object sender, EventArgs e)
        {
            foreach (var item in senders)
            {
                if (item.Name == NameTextBox.Text && item.Surname == SurnameTextBox.Text && item.Patronymic == PatronymicTextBox.Text && item.Postoffice_number == postoffice_number && item.Phone_number == PhoneNumberTextBox.Text)
                {
                    temp_sender = item;
                    break;
                }
            }

            try
            {
                temp_parcel = new Parcel<dynamic>(weight, capacity, ParcelNameTextBox.Text);
                temp_parcel.Notify += NotifyConsole;
                temp_sender?.Parcels.Push(temp_parcel);
            }
            catch (DoubleException ex)
            {
                MessageBox.Show($"{ex.Message}, Value: {ex.Value}");
            }
        }
    }
}