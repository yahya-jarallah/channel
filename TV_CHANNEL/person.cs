using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_CHANNEL
{
     class person
    {
        string _name;
        int _Id;
        int _ph_number;
        public string Name
        {
            get { return this._name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    this._name = "NO NAME";
                else
                    this._name = value;
            }

        }
        public int Id
        {
            get { return this._Id; }
            set
            {
                if (value < 0)
                    Console.WriteLine("This Id should be non negative number");
                else
                    this._Id = value;
            }
        }
        public int Ph_number
        {
            get { return this._ph_number; }
            set
            {
                if (value <= 0 && value > 9)
                    Console.WriteLine("invalid phone number");
                else
                    this._ph_number = value;
            }
        }
       
        public virtual void print_data()
        {
            Console.WriteLine("\t\t\t\t\t***********************************************\n\n\n\t\t\t\t");
            Console.WriteLine("\t\t\t\t\t  person name is : " + Name);
            Console.WriteLine("\t\t\t\t\t  person number is : " + Id);
            Console.WriteLine("\t\t\t\t\t  person phone number is : " + Ph_number);
            Console.WriteLine("\t\t\t\t\t***********************************************\n\n\n\t\t\t\t");
        }

       

    }

    }
