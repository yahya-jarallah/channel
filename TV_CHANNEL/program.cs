using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_CHANNEL
{
     class program : programs
    {
        string _type;
       public program()
        {
            _type = Type;
        }

        public string Type
        {
            get { return this._type; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                    this._type = "NO NAME";
                else
                    this._type = value;
            }
        }
        public override void print_program_data()
        {
            Console.WriteLine("\t\t\t\t\t***********************************************\n\n\n\t\t\t\t");
            Console.WriteLine("\t\t\t\t\t programe name is : " + prog_name);
            Console.WriteLine("\t\t\t\t\t program time is : " + prog_time);
            Console.WriteLine("\t\t\t\t\t program duration is : " + prog_duration);
            Console.WriteLine("\t\t\t\t\t program name is : " + prog_num);
            Console.WriteLine("\t\t\t\t\t program type is : " + Type);
            Console.WriteLine("\t\t\t\t\t***********************************************\n\n\n\t\t\t\t");
        }

    }
      
    }
   
