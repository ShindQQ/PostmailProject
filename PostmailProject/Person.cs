using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PostmailProject
{
    abstract internal class Person : IComparable
    {
        public string Name { get; }
        public string Surname { get; }
        public string Patronymic { get; }
        public int Postoffice_number { get;  }
        public string Phone_number { get; }

        private string pattern = "[0-9]{3}-[0-9]{3}-[0-9]{4}";

        public IPrintable Printer { get; set; }

        protected Person(string name, string surname, string patronymic, int postoffice_number, string phone_number)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Postoffice_number = postoffice_number;

            if (Regex.IsMatch(Phone_number, pattern, RegexOptions.IgnoreCase))
            {
                Phone_number = phone_number;
            }
            else
            {
                Phone_number = string.Empty;
            }

            Printer = null;
        }

        public virtual string Print()
        {
            if (Printer != null)
            {
                return Printer.Print(this);
            }
            else
            {
                return GetInfo();
            }
        }
        
        public virtual string GetInfo()
        {
            return $"Name: {Name}, Surname: {Surname}, Patronymic: {Patronymic}, Phone number: {Phone_number}, Postoffice number: {Postoffice_number}"; ;
        }

        public int CompareTo(object obj)
        {
            return Postoffice_number.CompareTo((Sender)obj);
        }
    }
}
