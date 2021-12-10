using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostmailProject
{
    [Serializable]
    internal class Receiver<T> : SenderReceiverInfo, ICloneable
    {
        public string Name { get; }
        public string Surname { get; }
        public string Patronymic { get; }
        public double Price { get; set; }
        public double Money { get; set; }
        
        public List<Parcel<T>> Parcels = new List<Parcel<T>>();

        public IPrintable Printer { get; set; }
        public override event ConsoleDelegate Notify;

        public Receiver(string name, string surname, string patronymic, int postoffice_number, string phone_number, double price, double money, Parcel<T> parcel) : base(postoffice_number, phone_number)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;

            if (price <= 0)
            {
                throw new DoubleException("Price is less or equal to zero!", price);
            }
            else
            {
                Price = price;
            }
            
            if (money <= 0)
            {
                throw new DoubleException("Money is less or equal to zero!", money);
            }
            else
            {
                Money = money;
            }

            Parcels.Add(parcel);

            Printer = null;
        }

        public string Print()
        {
            Notify?.Invoke("Print - Receiver");

            if (Printer != null)
            {
                return Printer.Print(this);
            }
            else
            {
                return GetInfo();
            }
        }

        public object Clone()
        {
            Notify?.Invoke("Clone - Receiver");

            return MemberwiseClone() as Receiver<T>;
        }

        public override string GetInfo()
        {
            Notify?.Invoke("GetInfo - Receiver");

            string res = "Receiver: " + $"Name: {Name}, Surname: {Surname}, Patronymic: {Patronymic} " + base.GetInfo() + $", Price: {Price}, Money: {Money}\n";

            foreach (Parcel<T> parcel in Parcels)
            {
                res += parcel.GetInfo();
            }

            return res;
        }
    }
}