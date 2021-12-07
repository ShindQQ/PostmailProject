using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostmailProject
{
    internal class Postoffice : Postmail, ICloneable
    {
        public int Postoffice_number { get; }

        public Postoffice(string name, int postoffice_number) : base(name)
        {
            Postoffice_number = postoffice_number;
            base.Postoffices_ammount++;
        }

        public override object Clone()
        {
            return MemberwiseClone() as Postoffice;
        }
    }
}
