using System;
using System.Collections;
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
        bool check = true;

        Parcel<dynamic> temp_parcel = null;
        Sender<dynamic> temp_sender = null;
        Receiver<dynamic> temp_receiver = null;

        HashSet<Sender<dynamic>> senders = new HashSet<Sender<dynamic>>();
        List<Receiver<dynamic>> receivers = new List<Receiver<dynamic>>();
        SortedList<Sender<dynamic>, Receiver<dynamic>> senders_receivers = new SortedList<Sender<dynamic>, Receiver<dynamic>>();

        Parcel<dynamic>.ConsoleDelegate NotifyConsole1 = (string message) => Console.WriteLine(message);
        SenderReceiverInfo.ConsoleDelegate NotifyConsole2 = (string message) => Console.WriteLine(message);
        
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

            foreach(KeyValuePair<Sender<dynamic>, Receiver<dynamic>> item in senders_receivers)
            {
                ShowDepartmentLabel.Text += item.Key.GetInfo() + item.Value.GetInfo();
            }
        }

        private void SendDepartureButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in receivers)
                {
                    if (item.Name == NameTextBox.Text && item.Surname == SurnameTextBox.Text && item.Patronymic == PatronymicTextBox.Text && item.Phone_number == PhoneNumberTextBox.Text && item.Postoffice_number == postoffice_number && item.Price == price)
                    {
                        MessageBox.Show("Such Receiver already exists! You can add him a department!");
                        check = false;
                    }
                }
                if (check == true)
                {
                    temp_parcel = new Parcel<dynamic>(weight, capacity, ParcelNameTextBox.Text);
                    temp_sender = new Sender<dynamic>(postoffice_number, PhoneNumberTextBox.Text, temp_parcel);
                    price = temp_sender.CountPrice();
                    temp_receiver = new Receiver<dynamic>(NameTextBox.Text, SurnameTextBox.Text, PatronymicTextBox.Text, postoffice_number, PhoneNumberTextBox.Text, price, new Random().Next(((int)Math.Round(price) + 1) / 2, (int)Math.Round(price) * 2), temp_parcel);

                    temp_parcel.Notify += NotifyConsole1;
                    temp_sender.Notify += NotifyConsole2;
                    temp_receiver.Notify += NotifyConsole2;

                    senders.Add(temp_sender);
                    receivers.Add(temp_receiver);

                    senders_receivers.Add(temp_sender, temp_receiver);
                }
                check = true;
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
                                   select new { Send = send, Receive = receive }).FirstOrDefault();

            if (sender_receiver == null)
            {
                MessageBox.Show("There isn`t such Receiver!");
            }

            try
            {
                temp_parcel = new Parcel<dynamic>(weight, capacity, ParcelNameTextBox.Text);
                temp_parcel.Notify += NotifyConsole1;
                sender_receiver.Send?.Parcels.Push(temp_parcel);
                sender_receiver.Receive?.Parcels.Enqueue(temp_parcel);

                price = weight * capacity;
                sender_receiver.Receive.Price += price;
                sender_receiver.Receive.Money += new Random().Next(((int)Math.Round(price) + 1) / 2, (int)Math.Round(price) * 2);
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
            using (StreamWriter write_file = new StreamWriter("file.txt", false, System.Text.Encoding.Default))
            {
                foreach (var item1 in senders)
                {
                    write_file.Write(item1.Postoffice_number.ToString());
                    write_file.WriteLine(" " + item1.Phone_number);

                    foreach (var temp_parc in item1.Parcels)
                    {
                        write_file.Write(temp_parc.Weight.ToString());
                        write_file.Write(" " + temp_parc.Capacity.ToString());
                        write_file.WriteLine(" " + temp_parc.Name.ToString());
                    }

                    foreach (var item2 in receivers)
                    {
                        if (item1.Phone_number == item2.Phone_number && item1.Postoffice_number == item2.Postoffice_number)
                        {
                            write_file.Write(item2.Name);
                            write_file.Write(" " + item2.Surname);
                            write_file.Write(" " + item2.Patronymic);
                            write_file.Write(" " + item2.Postoffice_number.ToString());
                            write_file.Write(" " + item2.Phone_number);
                            write_file.Write(" " + item2.Price.ToString());
                            write_file.WriteLine(" " + item2.Money.ToString());

                            foreach (var temp_parc in item2.Parcels)
                            {
                                write_file.Write(temp_parc.Weight.ToString());
                                write_file.Write(" " + temp_parc.Capacity.ToString());
                                write_file.WriteLine(" " + temp_parc.Name.ToString());
                            }
                        }
                    }
                }
            }
        }
    }
}