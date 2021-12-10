using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostmailProject
{
    internal class Sender<T> : SenderReceiverInfo, ICloneable
    {
        public Queue<Parcel<T>> Parcels = new Queue<Parcel<T>>();

        public override event ConsoleDelegate Notify;

        public Sender(int postoffice_number, string phone_number, Parcel<T> parcel) : base(postoffice_number, phone_number)
        {
            Parcels.Enqueue(parcel);
        }

        public object Clone()
        {
            Notify?.Invoke("Clone - Sender");

            return MemberwiseClone() as Sender<T>;
        }

        public override string GetInfo()
        {
            Notify?.Invoke("GetInfo - Sender");

            string res = "Sender: " + base.GetInfo() + "\n";

            foreach (Parcel<T> parcel in Parcels)
            {
                res += parcel.GetInfo();
            }

            return res;
        }

        public double CountPrice()
        {
            Notify?.Invoke("CountPrice - Sender");

            double res = default;

            foreach (Parcel<T> parcel in Parcels)
            {
                res += parcel.Weight * parcel.Capacity; ;
            }

            return res;
        }
    }
}