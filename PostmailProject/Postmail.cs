using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostmailProject
{
    internal class Postmail<T> : ICloneable
        where T : notnull
    {
        public string Name { get; }
        public int Postoffices_ammount { get; set; }

        public (T, T, T) Location { get; set; }

        public Postmail(string name, (T, T, T) location)
        {
            Name = name;
            Location = location;

            Postoffices_ammount = default;
        }

        public virtual object Clone()
        {
            return MemberwiseClone() as Postmail<T>;
        }
    }
}