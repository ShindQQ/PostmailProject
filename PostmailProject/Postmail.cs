using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostmailProject
{
    internal class Postmail : ICloneable
    {
        public string Name { get; }
        public int Postoffices_ammount { get; set; }

        public Postmail(string name)
        {
            Name = name;
            Postoffices_ammount = default;
        }

        public virtual object Clone()
        {
            return MemberwiseClone() as Postmail;
        }
    }
}
