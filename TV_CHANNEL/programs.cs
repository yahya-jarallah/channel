using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_CHANNEL
{
    internal class programs
    {
        string _prog_name;
        int _prog_time;
        float _prog_duration;
        int _prog_num;
        public string prog_name
        {
            get { return this._prog_name; }
            set {
                if(string.IsNullOrWhiteSpace(value))
                    this._prog_name = "NO NAME";
                else
               this. _prog_name = value; }
        } 
        public int prog_time
        {
            get { return this. _prog_time; }
            set {
                int prog_t;
                do
                {
                     prog_t=int.Parse(Console.ReadLine());
                    if (prog_t <= 17)
                       this._prog_time = prog_t;
                    else
                        Console.WriteLine("\n\t\t\t\t\tinvalid entry !enter the corect times ( not more than 17 ) :") ;
                } while (prog_t > 17);
                }
        }
        public float prog_duration
        {
            get { return this. _prog_duration; }
            set {
                float prog_d;
                do
                {
                     prog_d=float.Parse(Console.ReadLine());
                    if (prog_d <= 2)

                      this.  _prog_duration = prog_d;
                    else
                        Console.WriteLine("\n\t\t\t\t\tinvalid entry! enter the corect duration ( not more than 2 ) :"); ;
                } while (prog_d > 2);

                }
        }
       public int prog_num
        {
            get
            {
                return this._prog_num;
            }
            set
            {
                int prog_no;
                do
                {
                  prog_no=int.Parse(Console.ReadLine());
                    if (prog_no <= 8)
                        this._prog_num = prog_no;
                    else
                       Console.WriteLine("\n\t\t\t\t\tinvalid entry ! enter the corect number :");
                } while (prog_no > 8);
              
            }
        }
        public virtual void print_program_data()
        {
            Console.WriteLine("\t\t\t\t\t***********************************************\n\n\n\t\t\t\t");
            Console.WriteLine("\t\t\t\t\t program name is : " + prog_name);
            Console.WriteLine("\t\t\t\t\t program time is : " + prog_time);
            Console.WriteLine("\t\t\t\t\t program duration is : " + prog_duration);
            Console.WriteLine("\t\t\t\t\t program name is : " + prog_num);
            Console.WriteLine("\t\t\t\t\t***********************************************\n\n\n\t\t\t\t");
        }
        
    }
}
