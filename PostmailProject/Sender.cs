using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostmailProject
{
    internal class Sender : Person, ICloneable, ICountPrice
    {
        public double Weight { get; }
        public double Capacity { get; }

        public Sender(string name, string surname, string patronymic, int postoffice_number, string phone_number, double weight, double capacity) : base(name, surname, patronymic, postoffice_number,phone_number)
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
            
        }

        public object Clone()
        {
            return MemberwiseClone() as Sender;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Weight: {Weight}, Capacity: {Weight}"; ;
        }

        public double CountPrice()
        {
            return Weight * Capacity;
        }
    }
}