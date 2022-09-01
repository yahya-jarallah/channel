using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_CHANNEL
{
    class advertisments : programs
    {
        string _company_name;
        int _repetition;
        double _price;
       public advertisments()
        {
            _company_name = Company_name;
            _repetition = Repetition;
            _price = Price;
        }

        public string Company_name
        {
            get { return this._company_name; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                    this._company_name = "NO NAME";
                else
                    this._company_name = value;
            }
        }
       
        
        public int Repetition
        {
            get { return this._repetition ;  }
            set {
              int rept;
               do
             {
                  rept=int.Parse(Console.ReadLine());
                  if (rept <= 14)

                  this._repetition  = rept;
                  else
                Console.WriteLine(" \n\n\t\t\t\t\t invalid entry !enter the corect number ( not more than 14 ) :") ;
             } while (rept > 14);

        }
        }
        public double Price
        {
            get { return this. _price; }
            set
            {
                double pr;
                int seconds = 30;
                int month = 30;
                int m3 = 90;
                int m6 = 120;
                int year = 360;
                do
                {
                    pr=double.Parse(Console.ReadLine());
                    if (pr == 30)
                    {
                        this._price = pr;
                       this._price = this._price * seconds * year; break;
                    }
                    else if (pr == 35)
                    {
                       this._price = pr;
                        this._price = this._price * seconds * m6; break;
                    }
                    else if (pr == 40)
                    {
                        this._price = pr;
                        this._price = this._price * seconds * m3; break;
                    }
                    else if (pr == 45)
                    {
                        this._price = pr;
                        this._price = this._price * seconds * month; break;
                    }
                    else
                       Console.WriteLine("\n\n\t\t\t\t\tinvalid entry!, enter the correct number (betwee(30 and 45)) :");
                } while (pr != 0);
              
            }
        }
        public override void print_program_data()

        {
            Console.WriteLine("\t\t\t\t\t***********************************************\n\n\n\t\t\t\t");
            Console.WriteLine("\t\t\t\t\t  programe name is : " + prog_name);
            Console.WriteLine("\t\t\t\t\t  program time is : " + prog_time);
            Console.WriteLine("\t\t\t\t\t  program duration is : " + prog_duration);
            Console.WriteLine("\t\t\t\t\t  program name is : " + prog_num);
            Console.WriteLine("\t\t\t\t\t  The company name is : " + Company_name);
            Console.WriteLine("\t\t\t\t\t  The number of repetition is : " + Repetition);
            Console.WriteLine("\t\t\t\t\t  The price is : " + Price) ;
            Console.WriteLine("\t\t\t\t\t***********************************************\n\n\n\t\t\t\t");
        }
    }

}
