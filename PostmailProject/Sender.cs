using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostmailProject
{
    internal class Sender<T> : Person, ICloneable
    {
        public List<Parcel<T>> Parcels = new List<Parcel<T>>();

        public override event ConsoleDelegate Notify;

        public Sender(string name, string surname, string patronymic, int postoffice_number, string phone_number, Parcel<T> parcel) : base(name, surname, patronymic, postoffice_number,phone_number)
        {
            Parcels.Add(parcel);
        }

        public object Clone()
        {
            Notify?.Invoke("Clone - Sender");

            return MemberwiseClone() as Sender<T>;
        }

        public override string GetInfo()
        {
            Notify?.Invoke("GetInfo - Sender");

            string res = base.GetInfo();

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