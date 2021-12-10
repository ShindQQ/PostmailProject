using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostmailProject
{
    internal class Receiver<T> : Person, ICloneable
    {
        public double Price { get; }

        public List<Parcel<T>> Parcels = new List<Parcel<T>>();

        public override event ConsoleDelegate Notify;

        public Receiver(string name, string surname, string patronymic, int postoffice_number, string phone_number, double price, Parcel<T> parcel) : base(name, surname, patronymic, postoffice_number, phone_number)
        {
            Price = price;
            Parcels.Add(parcel);
        }

        public object Clone()
        {
            Notify?.Invoke("Clone - Receiver");

            return MemberwiseClone() as Receiver<T>;
        }

        public override string GetInfo()
        {
            Notify?.Invoke("GetInfo - Receiver");

            string res = base.GetInfo() + $", Price: {Price}\n";

            foreach (Parcel<T> parcel in Parcels)
            {
                res += parcel.GetInfo();
            }

            return res;
        }
    }
}