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

    [Serializable]
    class ReceiverShowNameSurname : IPrintable
    {
        string IPrintable.Print(object obj)
        {
            Receiver<dynamic> receiver  = obj as Receiver<dynamic>;
            return $"Name: {receiver.Name}, Surname: {receiver.Surname}, Patronymic: {receiver.Patronymic};";
        }
    }
}