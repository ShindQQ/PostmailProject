using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PostmailProject
{
    [Serializable]
    abstract internal class SenderReceiverInfo : IComparable
    {
        public int Postoffice_number { get; }
        public string Phone_number { get; }

        [NonSerialized]
        private string pattern = "[0-9]{3}-[0-9]{3}-[0-9]{4}";
        
        public delegate void ConsoleDelegate(string message);
        [field: NonSerialized]
        public virtual event ConsoleDelegate Notify;

        protected SenderReceiverInfo(int postoffice_number, string phone_number)
        {
            if (postoffice_number <= 0)
            {
                throw new DoubleException("Postoffice number is less or equal to zero!", postoffice_number);
            }
            else
            {
                Postoffice_number = postoffice_number;
            }

            if (Regex.IsMatch(phone_number, pattern, RegexOptions.IgnoreCase))
            {
                Phone_number = phone_number;
            }
            else
            {
                Phone_number = string.Empty;
            }

            Notify = null;
        }
        
        public virtual string GetInfo()
        {
            Notify?.Invoke("GetInfo - Person");

            return $"Phone number: {Phone_number}, Postoffice number: {Postoffice_number}"; ;
        }

        public int CompareTo(object obj)
        {
            Notify?.Invoke("CompareTo - Person");

            return Postoffice_number.CompareTo(((SenderReceiverInfo)obj).Postoffice_number);
        }
    }
}