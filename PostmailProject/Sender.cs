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
            Weight = weight;
            Capacity = capacity;
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
