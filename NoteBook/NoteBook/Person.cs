using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook
{
    /// <summary>
    ///  Describe one person
    /// </summary>
    public class Person
    {
        string Pname;
        int Page;
        string Paddress;
        string Pphone;
        public Person(string name, int age, string address, string phone)
        {
            Pname = name;
            Page = age;
            Paddress = address;
            Pphone = phone;
        }

        public Person()
        {
            Pname = "<Enter name>";
            Page = 0;
            Paddress = "<Enter address>";
            Pphone = "<Enter phone>";
        }
        public string PersonName
        {
            get
            {
                return Pname;
            }
            set
            {
                Pname = value;
            }
        }
        public int PersonAge
        {
            get
            {
                return Page;
            }
            set
            {
                Page = value;
            }
        }
        public string PersonAddress
        {
            get
            {
                return Paddress;
            }
            set
            {
                Paddress = value;
            }
        }
        public string PersonPhone
        {
            get
            {
                return Pphone;
            }
            set
            {
                Pphone = value;
            }
        }

    }
}
