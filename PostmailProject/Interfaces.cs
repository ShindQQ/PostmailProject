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

    internal interface ICountPrice
    {
        double CountPrice();
    }

    class PersonShowName : IPrintable
    {
        string IPrintable.Print(object obj)
        {
            Person person  = obj as Person;
            return $"Name: {person.Name}, Surname: {person.Surname}, Patronymic: {person.Patronymic};";
        }
    }
}
