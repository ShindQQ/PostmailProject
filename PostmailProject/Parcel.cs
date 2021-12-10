using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostmailProject
{
    [Serializable]
    internal class Parcel<T> : ICloneable, IComparable
    {
        public double Weight { get; }
        public double Capacity { get; }
        public T Name { get; set; }

        public delegate void ConsoleDelegate(string message);
        public event ConsoleDelegate Notify;

        public Parcel(double weight, double capacity, T name)
        {
            if (weight <= 0)
            {
                
                throw new DoubleException("Weight is less or equal to zero!", weight);
            }
            else
            {
                Weight = weight;
            }

            if (capacity <= 0)
            {
                throw new DoubleException("Capacity is less or equal to zero!", capacity);
            }
            else
            {
                Capacity = capacity;
            }

            Name = name;

            Notify = null;
        }

        public string GetInfo()
        {
            Notify?.Invoke("GetInfo - Parcel");

            return $"Name: {Name}, Weight: {Weight}, Capacity: {Capacity}\n";
        }

        public object Clone()
        {
            Notify?.Invoke("Clone - Parcel");

            return MemberwiseClone() as Parcel<T>;
        }

        public int CompareTo(object obj)
        {
            return Name.ToString().CompareTo(((Parcel<T>)obj).Name.ToString());
        }

        public void Swap<Y>(ref Y arg1, ref Y arg2)
        {
            (arg1, arg2) = (arg2, arg1);
        }
    }
}