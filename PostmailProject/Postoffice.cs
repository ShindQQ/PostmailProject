using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostmailProject
{
    internal class Postoffice<T> : Postmail<T>, ICloneable
        where T : notnull
    {
        public int Postoffice_number { get; }

        public Postoffice(string name, int postoffice_number, (T, T, T) location) : base(name, location)
        {
            if (postoffice_number <= 0)
            {
                throw new IntException("Postoffice number is less or equal to zero!", postoffice_number);
            }
            else
            {
                Postoffice_number = postoffice_number;
            }

            base.Postoffices_ammount++;
        }

        public override object Clone()
        {
            return MemberwiseClone() as Postoffice<T>;
        }
    }
}