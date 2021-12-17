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
    [Serializable]
    public partial class ReceiverForm : Form
    {
        int postoffice_number = default;
        double capacity = default;
        double weight = default;
        double price = default;
        double money = default;
        string phone_number;
        string Tname;
        string name;
        string surname;
        string patronymic;
        int previous_length = default;
        int count = default;

        bool sender_trash_parcel = true;
        bool receiver_trash_parcel = true;
        bool leave = false;

        string file_string;
        string[] items;

        Parcel<dynamic> temp_parcel = null;
        Sender<dynamic> temp_sender = null;
        Receiver<dynamic> temp_receiver = null;
        Queue<Sender<dynamic>> senders = new Queue<Sender<dynamic>>();
        List<Receiver<dynamic>> receivers = new List<Receiver<dynamic>>();
        Dictionary<Sender<dynamic>, Receiver<dynamic>> senders_receivers = new Dictionary<Sender<dynamic>, Receiver<dynamic>>();

        Parcel<dynamic>.ConsoleDelegate NotifyConsole1 = delegate (string message)
        {
            Console.WriteLine(message);
        };

        SenderReceiverInfo.ConsoleDelegate NotifyConsole2 = delegate (string message)
        {
            Console.WriteLine(message);
        };


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

        private void ReceiveDepartureBox_Enter(object sender, EventArgs e)
        {

        }

        private void ReceiveDepartureButton_Click(object sender, EventArgs e)
        {
            leave = false;

            if (receivers.Count() == 0)
            {
                MessageBox.Show("There isn`t such Receiver!");
            }

            foreach (var item in receivers)
            {
                if (item.Name == NameTextBox.Text && item.Surname == SurnameTextBox.Text && item.Patronymic == PatronymicTextBox.Text && item.Phone_number == PhoneNumberTextBox.Text && item.Postoffice_number == postoffice_number)
                {
                    if (item.Money > item.Price)
                    {
                        count = item.Parcels.Count;
                        for (int i = 0; i < count; i++)
                        {
                            item.Parcels.Dequeue();
                            if(item.Parcels.Count == 0)
                            {
                                receivers.Remove(item);
                                leave = true;
                                break;
                            }
                        }

                        if (leave == true)
                        {
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Receiver hasn`t enough money to take parcels!");
                    }
                }
                else
                {
                    MessageBox.Show("There isn`t such Receiver!");
                    break;
                }
            }
        }

        private void CheckReceivingLabel_Click(object sender, EventArgs e)
        {
            CheckReceivingLabel.Text = "";

            foreach (var item1 in senders)
            {
                foreach (var item2 in receivers)
                {
                    if (item1.Phone_number == item2.Phone_number && item1.Postoffice_number == item2.Postoffice_number)
                    {
                        senders_receivers.Add(item1, item2);
                    }
                }
            }

            foreach (KeyValuePair<Sender<dynamic>, Receiver<dynamic>> item in senders_receivers)
            {
                CheckReceivingLabel.Text += item.Key.GetInfo() + item.Value.GetInfo();
            }

            senders_receivers.Clear();
        }

        private void ReadFileButton_Click(object sender, EventArgs e)
        {
            using (StreamReader read_file = new StreamReader("file.txt"))
            {
                while ((file_string = read_file.ReadLine()) != null)
                {
                    items = file_string.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    if (items.Length == 2)
                    {
                        previous_length = 2;
                        receiver_trash_parcel = true;

                        postoffice_number = int.Parse(items[0]);
                        phone_number = items[1];

                        temp_sender = new Sender<dynamic>(postoffice_number, phone_number, default);
                        temp_sender.Notify += NotifyConsole2;
                        senders.Enqueue(temp_sender);
                    }
                    else if (items.Length == 3)
                    {
                        weight = double.Parse(items[0]);
                        capacity = double.Parse(items[1]);
                        Tname = items[2];

                        if (previous_length == 2)
                        {
                            foreach (var item in senders)
                            {
                                if (item.Phone_number == phone_number && item.Postoffice_number == postoffice_number)
                                {
                                    if (sender_trash_parcel == true)
                                    {
                                        item.Parcels.Pop();
                                        sender_trash_parcel = false;
                                    }

                                    temp_parcel = new Parcel<dynamic>(weight, capacity, Tname);
                                    temp_parcel.Notify += NotifyConsole1;
                                    item.Parcels.Push(temp_parcel);
                                }
                            }
                        }
                        else if (previous_length == 7)
                        {
                            foreach (var item in receivers)
                            {
                                if (item.Name == name && item.Surname == surname && item.Patronymic == patronymic && item.Phone_number == phone_number && item.Postoffice_number == postoffice_number && item.Price == price && item.Money == money)
                                {
                                    if (receiver_trash_parcel == true)
                                    {
                                        item.Parcels.Dequeue();
                                        receiver_trash_parcel = false;
                                    }

                                    temp_parcel = new Parcel<dynamic>(weight, capacity, Tname);
                                    temp_parcel.Notify += NotifyConsole1;
                                    item.Parcels.Enqueue(temp_parcel);
                                }
                            }
                        }
                    }
                    else if (items.Length == 7)
                    {
                        previous_length = 7;
                        sender_trash_parcel = true;

                        name = items[0];
                        surname = items[1];
                        patronymic = items[2];
                        postoffice_number = int.Parse(items[3]);
                        phone_number = items[4];
                        price = double.Parse(items[5]);
                        money = double.Parse(items[6]);

                        temp_receiver = new Receiver<dynamic>(name, surname, patronymic, postoffice_number, phone_number, price, money, new Parcel<dynamic>(1, 1, 1));
                        temp_receiver.Notify += NotifyConsole2;
                        receivers.Add(temp_receiver);
                    }
                }
            }
        }

        private void ReadBinaryFileButton_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("senders.dat", FileMode.OpenOrCreate))
            {
                senders = (Queue<Sender<dynamic>>)formatter.Deserialize(fs);
            }
        }
    }
}