using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
        double price = default;

        static string path = "file.dat";
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream write_file = new FileStream(path, FileMode.Create);

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

            foreach (var item1 in senders)
            {
                ShowDepartmentLabel.Text += item1.GetInfo();
                foreach (var item2 in receivers)
                {
                    if (item1.Phone_number == item2.Phone_number && item1.Postoffice_number == item2.Postoffice_number)
                    {
                        ShowDepartmentLabel.Text += item2.GetInfo();
                    }
                }
            }
        }

        private void SendDepartureButton_Click(object sender, EventArgs e)
        {
            try
            {
                temp_parcel = new Parcel<dynamic>(weight, capacity, ParcelNameTextBox.Text);
                temp_sender = new Sender<dynamic>(postoffice_number, PhoneNumberTextBox.Text, temp_parcel);
                price = temp_sender.CountPrice();
                temp_receiver = new Receiver<dynamic>(NameTextBox.Text, SurnameTextBox.Text, PatronymicTextBox.Text, postoffice_number, PhoneNumberTextBox.Text, price, new Random().Next(((int)Math.Round(price) + 1) / 2, (int)Math.Round(price) * 2), temp_parcel);

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
                                  from receive in receivers
                                  where send.Postoffice_number == postoffice_number && send.Phone_number == PhoneNumberTextBox.Text && send.Phone_number == receive.Phone_number && send.Postoffice_number == receive.Postoffice_number
                                  select new {Send = send, Receive = receive}).Take(1);

            try
            {
                foreach (var item in sender_receiver)
                {
                    temp_parcel = new Parcel<dynamic>(weight, capacity, ParcelNameTextBox.Text);
                    temp_parcel.Notify += NotifyConsole;
                    item.Send?.Parcels.Enqueue(temp_parcel);
                    item.Receive?.Parcels.Add(temp_parcel);

                    price = weight * capacity;
                    item.Receive.Price += price;
                    item.Receive.Money += new Random().Next(((int)Math.Round(price) + 1) / 2, (int)Math.Round(price) * 2);
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

        private void WriteFileButton_Click(object sender, EventArgs e)
        {
            foreach (var item1 in senders)
            {
                formatter.Serialize(write_file, item1);
                foreach (var item2 in receivers)
                {
                    if (item1.Phone_number == item2.Phone_number && item1.Postoffice_number == item2.Postoffice_number)
                    {
                        formatter.Serialize(write_file, item2);
                    }
                }
            }
        }
    }
}