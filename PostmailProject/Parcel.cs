using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostmailProject
{
    internal class Parcel<T> : ICloneable
    {
        public double Weight { get; }
        public double Capacity { get; }
        public T Name { get; set; }

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
        }

        public string GetInfo()
        {
            return $"\nName: {Name}, Weight: {Weight}, Capacity: {Capacity}";
        }

        public object Clone()
        {
            return MemberwiseClone() as Parcel<T>;
        }
    }
}