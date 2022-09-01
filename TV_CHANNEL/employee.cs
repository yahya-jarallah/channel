using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_CHANNEL
{
     class employee : person
    {
        long _salary;
       public employee()
        {
            _salary = Salary;
        }
        public long Salary
        {
            get { return this._salary; }
            set
            {
                long s = 0;
                do
                {
                  s = long.Parse(Console.ReadLine());
                   
                    if (s >= 100000)
                        this._salary = s;
                    else
                        Console.WriteLine(" \n\n\t\t\t\t\t invalid entry! enter the corect salary ( not less than 100000 ) : ");
                } while (s < 100000);

            }
        }
           public override  void print_data()
        {
            Console.WriteLine("\t\t\t\t\t***********************************************\n\n\n\t\t\t\t");
            Console.WriteLine("\t\t\t\t\t  person name is : " + Name);
            Console.WriteLine("\t\t\t\t\t  person number is : " + Id);
            Console.WriteLine("\t\t\t\t\t  person phone number is : " + Ph_number);
            Console.WriteLine("\t\t\t\t\t  person salary is : " + Salary);
            Console.WriteLine("\t\t\t\t\t***********************************************\n\n\n\t\t\t\t");
        }
        }
    }

