using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostmailProject
{
    internal class Receiver : Person, ICloneable
    {
        public double Price { get; }

        public Receiver(string name, string surname, string patronymic, int postoffice_number, string phone_number, double price) : base(name, surname, patronymic, postoffice_number, phone_number)
        {
            Price = price;
        }

        public object Clone()
        {
            return MemberwiseClone() as Receiver;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Price: {Price}"; ;
        }
    }
}
