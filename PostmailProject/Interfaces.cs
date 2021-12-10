using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostmailProject
{
    internal interface IPrintable
    {
        string Print(object obj);
    }

    internal interface SenderReceiverInfo
    {
        int Postoffice_number { get; }
        string Phone_number { get; }
        const string pattern = "[0-9]{3}-[0-9]{3}-[0-9]{4}";
    }

    class PersonShowNameSurname : IPrintable
    {
        string IPrintable.Print(object obj)
        {
            Person person  = obj as Person;
            return $"Name: {person.Name}, Surname: {person.Surname}, Patronymic: {person.Patronymic};";
        }
    }
}