using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostmailProject
{
    internal class Sender<T> : Person, ICloneable, ICountPrice
    {
        public List<Parcel<T>> Parcels = new List<Parcel<T>>();

        public Sender(string name, string surname, string patronymic, int postoffice_number, string phone_number, Parcel<T> parcel) : base(name, surname, patronymic, postoffice_number,phone_number)
        {
            Parcels.Add(parcel);
        }

        public object Clone()
        {
            return MemberwiseClone() as Sender<T>;
        }

        public override string GetInfo()
        {
            var parcels = from parcel in Parcels select parcel;
            string res = base.GetInfo();

            foreach (Parcel<T> parcel in parcels)
            {
               res += parcel.GetInfo();
            }

            return res;
        }

        public double CountPrice()
        {
            var parcels = from parcel in Parcels select parcel;
            double res = default;

            foreach (Parcel<T> parcel in parcels)
            {
                res += parcel.Weight * parcel.Capacity; ;
            }

            return res;
        }
    }
}